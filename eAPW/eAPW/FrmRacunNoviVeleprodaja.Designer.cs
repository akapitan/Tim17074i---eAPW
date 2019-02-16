namespace eAPW
{
    partial class FrmRacunNoviVeleprodaja
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
            this.btnPregledTvrtke = new System.Windows.Forms.Button();
            this.btnDodajNovuTvrtku = new System.Windows.Forms.Button();
            this.cboxTvrtka = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bntIzdaj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPregledTvrtke
            // 
            this.btnPregledTvrtke.Location = new System.Drawing.Point(695, 75);
            this.btnPregledTvrtke.Name = "btnPregledTvrtke";
            this.btnPregledTvrtke.Size = new System.Drawing.Size(139, 39);
            this.btnPregledTvrtke.TabIndex = 48;
            this.btnPregledTvrtke.Text = "Pregled tvrtke";
            this.btnPregledTvrtke.UseVisualStyleBackColor = true;
            this.btnPregledTvrtke.Click += new System.EventHandler(this.btnPregledTvrtke_Click);
            // 
            // btnDodajNovuTvrtku
            // 
            this.btnDodajNovuTvrtku.Location = new System.Drawing.Point(550, 75);
            this.btnDodajNovuTvrtku.Name = "btnDodajNovuTvrtku";
            this.btnDodajNovuTvrtku.Size = new System.Drawing.Size(139, 39);
            this.btnDodajNovuTvrtku.TabIndex = 47;
            this.btnDodajNovuTvrtku.Text = "Dodaj tvrtku";
            this.btnDodajNovuTvrtku.UseVisualStyleBackColor = true;
            this.btnDodajNovuTvrtku.Click += new System.EventHandler(this.btnDodajNovuTvrtku_Click);
            // 
            // cboxTvrtka
            // 
            this.cboxTvrtka.FormattingEnabled = true;
            this.cboxTvrtka.Location = new System.Drawing.Point(550, 24);
            this.cboxTvrtka.Name = "cboxTvrtka";
            this.cboxTvrtka.Size = new System.Drawing.Size(279, 24);
            this.cboxTvrtka.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tvrtka";
            // 
            // bntIzdaj
            // 
            this.bntIzdaj.Location = new System.Drawing.Point(739, 463);
            this.bntIzdaj.Name = "bntIzdaj";
            this.bntIzdaj.Size = new System.Drawing.Size(90, 44);
            this.bntIzdaj.TabIndex = 41;
            this.bntIzdaj.Text = "Izdaj";
            this.bntIzdaj.UseVisualStyleBackColor = true;
            this.bntIzdaj.Click += new System.EventHandler(this.bntIzdaj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(646, 463);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(90, 44);
            this.btnIzbrisi.TabIndex = 42;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(550, 463);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(90, 44);
            this.btnDodaj.TabIndex = 43;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(27, 463);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(90, 44);
            this.btnIzlaz.TabIndex = 44;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.Location = new System.Drawing.Point(136, 21);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.ReadOnly = true;
            this.txtZaposlenik.Size = new System.Drawing.Size(234, 22);
            this.txtZaposlenik.TabIndex = 39;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(136, 97);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.ReadOnly = true;
            this.txtIznos.Size = new System.Drawing.Size(234, 22);
            this.txtIznos.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Popis stavki";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Iznos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Iznos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Zaposlenik";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(136, 58);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(234, 22);
            this.dtpDatum.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 287);
            this.dataGridView1.TabIndex = 32;
            // 
            // FrmRacunNoviVeleprodaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 544);
            this.Controls.Add(this.btnPregledTvrtke);
            this.Controls.Add(this.btnDodajNovuTvrtku);
            this.Controls.Add(this.cboxTvrtka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bntIzdaj);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmRacunNoviVeleprodaja";
            this.Text = "Veleprodaja Novi račun";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmRacunNoviVeleprodaja_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPregledTvrtke;
        private System.Windows.Forms.Button btnDodajNovuTvrtku;
        private System.Windows.Forms.ComboBox cboxTvrtka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bntIzdaj;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.TextBox txtZaposlenik;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}