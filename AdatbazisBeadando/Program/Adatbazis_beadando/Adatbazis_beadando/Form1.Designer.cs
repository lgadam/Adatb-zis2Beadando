namespace Adatbazis_beadando
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_sorozatszam = new System.Windows.Forms.TextBox();
            this.tb_tipus = new System.Windows.Forms.TextBox();
            this.tb_gyarto = new System.Windows.Forms.TextBox();
            this.tb_processzor = new System.Windows.Forms.TextBox();
            this.tb_videokartya = new System.Windows.Forms.TextBox();
            this.tb_ram = new System.Windows.Forms.TextBox();
            this.tb_processzororajel = new System.Windows.Forms.TextBox();
            this.dgv_laptopok = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hozzadas_button = new System.Windows.Forms.Button();
            this.button_torles = new System.Windows.Forms.Button();
            this.tb_kepernyomeret = new System.Windows.Forms.TextBox();
            this.button_listazas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_laptopok)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_sorozatszam
            // 
            this.tb_sorozatszam.Location = new System.Drawing.Point(144, 247);
            this.tb_sorozatszam.Name = "tb_sorozatszam";
            this.tb_sorozatszam.Size = new System.Drawing.Size(161, 20);
            this.tb_sorozatszam.TabIndex = 0;
            this.tb_sorozatszam.Leave += new System.EventHandler(this.tb_sorozatszam_Leave);
            // 
            // tb_tipus
            // 
            this.tb_tipus.Location = new System.Drawing.Point(144, 281);
            this.tb_tipus.Name = "tb_tipus";
            this.tb_tipus.Size = new System.Drawing.Size(161, 20);
            this.tb_tipus.TabIndex = 1;
            // 
            // tb_gyarto
            // 
            this.tb_gyarto.Location = new System.Drawing.Point(144, 319);
            this.tb_gyarto.Name = "tb_gyarto";
            this.tb_gyarto.Size = new System.Drawing.Size(161, 20);
            this.tb_gyarto.TabIndex = 2;
            // 
            // tb_processzor
            // 
            this.tb_processzor.Location = new System.Drawing.Point(144, 356);
            this.tb_processzor.Name = "tb_processzor";
            this.tb_processzor.Size = new System.Drawing.Size(161, 20);
            this.tb_processzor.TabIndex = 3;
            // 
            // tb_videokartya
            // 
            this.tb_videokartya.Location = new System.Drawing.Point(144, 394);
            this.tb_videokartya.Name = "tb_videokartya";
            this.tb_videokartya.Size = new System.Drawing.Size(161, 20);
            this.tb_videokartya.TabIndex = 4;
            // 
            // tb_ram
            // 
            this.tb_ram.Location = new System.Drawing.Point(490, 247);
            this.tb_ram.Name = "tb_ram";
            this.tb_ram.Size = new System.Drawing.Size(161, 20);
            this.tb_ram.TabIndex = 5;
            // 
            // tb_processzororajel
            // 
            this.tb_processzororajel.Location = new System.Drawing.Point(490, 319);
            this.tb_processzororajel.Name = "tb_processzororajel";
            this.tb_processzororajel.Size = new System.Drawing.Size(161, 20);
            this.tb_processzororajel.TabIndex = 7;
            // 
            // dgv_laptopok
            // 
            this.dgv_laptopok.AllowUserToAddRows = false;
            this.dgv_laptopok.AllowUserToDeleteRows = false;
            this.dgv_laptopok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_laptopok.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_laptopok.Location = new System.Drawing.Point(43, 12);
            this.dgv_laptopok.Name = "dgv_laptopok";
            this.dgv_laptopok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_laptopok.Size = new System.Drawing.Size(688, 210);
            this.dgv_laptopok.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sorozatszam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "tipus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "gyarto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "processzor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "videókártya";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ram(gb)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "képernyőméret(col)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "processzororajel(Mhz)";
            // 
            // hozzadas_button
            // 
            this.hozzadas_button.Location = new System.Drawing.Point(330, 356);
            this.hozzadas_button.Name = "hozzadas_button";
            this.hozzadas_button.Size = new System.Drawing.Size(84, 40);
            this.hozzadas_button.TabIndex = 17;
            this.hozzadas_button.Text = "Hozzáadás";
            this.hozzadas_button.UseVisualStyleBackColor = true;
            this.hozzadas_button.Click += new System.EventHandler(this.hozzadas_button_Click);
            // 
            // button_torles
            // 
            this.button_torles.Location = new System.Drawing.Point(437, 356);
            this.button_torles.Name = "button_torles";
            this.button_torles.Size = new System.Drawing.Size(118, 40);
            this.button_torles.TabIndex = 18;
            this.button_torles.Text = "Törlés";
            this.button_torles.UseVisualStyleBackColor = true;
            this.button_torles.Click += new System.EventHandler(this.button_torles_Click);
            // 
            // tb_kepernyomeret
            // 
            this.tb_kepernyomeret.Location = new System.Drawing.Point(490, 284);
            this.tb_kepernyomeret.Name = "tb_kepernyomeret";
            this.tb_kepernyomeret.Size = new System.Drawing.Size(161, 20);
            this.tb_kepernyomeret.TabIndex = 19;
            // 
            // button_listazas
            // 
            this.button_listazas.Location = new System.Drawing.Point(681, 250);
            this.button_listazas.Name = "button_listazas";
            this.button_listazas.Size = new System.Drawing.Size(84, 40);
            this.button_listazas.TabIndex = 20;
            this.button_listazas.Text = "Frissítés";
            this.button_listazas.UseVisualStyleBackColor = true;
            this.button_listazas.Click += new System.EventHandler(this.button_listazas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_listazas);
            this.Controls.Add(this.tb_kepernyomeret);
            this.Controls.Add(this.button_torles);
            this.Controls.Add(this.hozzadas_button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_laptopok);
            this.Controls.Add(this.tb_processzororajel);
            this.Controls.Add(this.tb_ram);
            this.Controls.Add(this.tb_videokartya);
            this.Controls.Add(this.tb_processzor);
            this.Controls.Add(this.tb_gyarto);
            this.Controls.Add(this.tb_tipus);
            this.Controls.Add(this.tb_sorozatszam);
            this.Name = "Form1";
            this.Text = "Foldal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_laptopok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_sorozatszam;
        private System.Windows.Forms.TextBox tb_tipus;
        private System.Windows.Forms.TextBox tb_gyarto;
        private System.Windows.Forms.TextBox tb_processzor;
        private System.Windows.Forms.TextBox tb_videokartya;
        private System.Windows.Forms.TextBox tb_ram;
        private System.Windows.Forms.TextBox tb_processzororajel;
        private System.Windows.Forms.DataGridView dgv_laptopok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button hozzadas_button;
        private System.Windows.Forms.Button button_torles;
        private System.Windows.Forms.TextBox tb_kepernyomeret;
        private System.Windows.Forms.Button button_listazas;
    }
}

