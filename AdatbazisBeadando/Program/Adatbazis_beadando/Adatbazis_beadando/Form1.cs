using Adatbazis_beadando.Models.Manager;
using Adatbazis_beadando.Models.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adatbazis_beadando
{
    public partial class Form1 : Form
    {
        LaptopokTabla tablaManager;
        List<Laptopok> rekords_LaptopokList;
        BackgroundWorker bgWorker;
        public Form1()
        {
            
            tablaManager = new LaptopokTabla();
            rekords_LaptopokList = new List<Laptopok>();
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerComplete;
            InitializeComponent();
        }

        private void button_torles_Click(object sender, EventArgs e)
        {
            int ToroltSorok = 0;
            foreach (DataGridViewRow selectedRows in dgv_laptopok.SelectedRows)
            {
                Laptopok TorlendoRekord = new Laptopok();
                TorlendoRekord.Sorozatszam = selectedRows.Cells["sorozatszam"].Value.ToString();

                ToroltSorok += tablaManager.Delete(TorlendoRekord);
            }

            MessageBox.Show(string.Format("{0} sor törlésre került", ToroltSorok));
            if (ToroltSorok != 0)
            {
                bgWorker.RunWorkerAsync();
            }
        }
        private void button_listazas_Click(object sender, EventArgs e)
        {
            dgv_laptopok.Refresh();
        }
        private void hozzadas_button_Click(object sender, EventArgs e)
        {
            try
            {
                Laptopok laptop = new Laptopok()
                {
                    Sorozatszam = tb_sorozatszam.Text,
                    Tipus = tb_tipus.Text,
                    Gyartonev = tb_gyarto.Text,
                    Processzor = tb_processzor.Text,
                    Videokartya = tb_videokartya.Text,
                    Ram = int.Parse(tb_ram.Text),
                    Kepernyomeret = int.Parse(tb_kepernyomeret.Text),
                    Processzororajel = int.Parse(tb_processzororajel.Text)
                };
                tablaManager.Insert(laptop);
                bgWorker.RunWorkerAsync();

                MessageBox.Show("sikeres adatfeltöltés!");
                /*
                tb_sorozatszam.Clear();
                tb_tipus.Clear();
                tb_gyarto.Clear();
                tb_processzor.Clear();
                tb_videokartya.Clear();
                tb_ram.Clear();
                tb_processzororajel.Clear();
                tb_kepernyomeret.Clear();
                */
            }
            catch (Exception)
            {
                MessageBox.Show("Sikertelen adatfeltöltés! Ellenőrizd az adatfelvitelt..");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bgWorker.WorkerSupportsCancellation = true;
            InitDataGridView();
            bgWorker.RunWorkerAsync();
        }
        private void InitDataGridView()
        {
            dgv_laptopok.Rows.Clear();
            dgv_laptopok.Columns.Clear();

            DataGridViewColumn SorozatszamColumn = new DataGridViewColumn()
            {
                Name = "sorozatszam",
                HeaderText = "sorozatszam",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

            };
            dgv_laptopok.Columns.Add(SorozatszamColumn);

            DataGridViewColumn GyartoColumn = new DataGridViewColumn()
            {
                Name = "gyarto",
                HeaderText = "Gyártó",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

            };
            dgv_laptopok.Columns.Add(GyartoColumn);

            DataGridViewColumn TipusCoulmn = new DataGridViewColumn()
            {
                Name = "tipus",
                HeaderText = "Típus",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            };
            dgv_laptopok.Columns.Add(TipusCoulmn);
        }
        private void BgWorker_RunWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            FillDataGridView();
        }
        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            rekords_LaptopokList = tablaManager.Select();
        }
        private void FillDataGridView()
        {
            DataGridViewRow[] dataGridViewRows = new DataGridViewRow[rekords_LaptopokList.Count];

            for (int i = 0; i < rekords_LaptopokList.Count; i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();

                DataGridViewCell SorozatszamCell = new DataGridViewTextBoxCell();
                SorozatszamCell.Value = rekords_LaptopokList[i].Sorozatszam;
                dataGridViewRow.Cells.Add(SorozatszamCell);


                DataGridViewCell GyartoCell = new DataGridViewTextBoxCell();
                GyartoCell.Value = rekords_LaptopokList[i].Gyartonev;
                dataGridViewRow.Cells.Add(GyartoCell);

                DataGridViewCell TipusCell = new DataGridViewTextBoxCell();
                TipusCell.Value = rekords_LaptopokList[i].Tipus;
                dataGridViewRow.Cells.Add(TipusCell);


                dataGridViewRows[i] = dataGridViewRow;
            }
            dgv_laptopok.Rows.Clear();
            dgv_laptopok.Rows.AddRange(dataGridViewRows);
        }
        private void tb_sorozatszam_Leave(object sender, EventArgs e)
        {
            string actual = tb_sorozatszam.Text;
            bool Correct = tablaManager.CheckSorozatszam(actual);
            tb_sorozatszam.BackColor = Correct ? Color.White : Color.Yellow;
        }
    }
}
