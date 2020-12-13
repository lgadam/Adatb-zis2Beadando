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
            this.tb_sorozatszam = new System.Windows.Forms.TextBox();
            this.tb_tipus = new System.Windows.Forms.TextBox();
            this.tb_gyarto = new System.Windows.Forms.TextBox();
            this.tb_processzor = new System.Windows.Forms.TextBox();
            this.tb_videokartya = new System.Windows.Forms.TextBox();
            this.tb_ram = new System.Windows.Forms.TextBox();
            this.tb_kepernyomeret = new System.Windows.Forms.TextBox();
            this.tb_processzororajel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_sorozatszam
            // 
            this.tb_sorozatszam.Location = new System.Drawing.Point(144, 247);
            this.tb_sorozatszam.Name = "tb_sorozatszam";
            this.tb_sorozatszam.Size = new System.Drawing.Size(161, 20);
            this.tb_sorozatszam.TabIndex = 0;
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
            this.tb_ram.TextChanged += new System.EventHandler(this.tb_ram_TextChanged);
            // 
            // tb_kepernyomeret
            // 
            this.tb_kepernyomeret.Location = new System.Drawing.Point(490, 281);
            this.tb_kepernyomeret.Name = "tb_kepernyomeret";
            this.tb_kepernyomeret.Size = new System.Drawing.Size(161, 20);
            this.tb_kepernyomeret.TabIndex = 6;
            // 
            // tb_processzororajel
            // 
            this.tb_processzororajel.Location = new System.Drawing.Point(490, 319);
            this.tb_processzororajel.Name = "tb_processzororajel";
            this.tb_processzororajel.Size = new System.Drawing.Size(161, 20);
            this.tb_processzororajel.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 210);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_processzororajel);
            this.Controls.Add(this.tb_kepernyomeret);
            this.Controls.Add(this.tb_ram);
            this.Controls.Add(this.tb_videokartya);
            this.Controls.Add(this.tb_processzor);
            this.Controls.Add(this.tb_gyarto);
            this.Controls.Add(this.tb_tipus);
            this.Controls.Add(this.tb_sorozatszam);
            this.Name = "Form1";
            this.Text = "Foldal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox tb_kepernyomeret;
        private System.Windows.Forms.TextBox tb_processzororajel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

