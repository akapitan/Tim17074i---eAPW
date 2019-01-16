namespace eAPW
{
    partial class FrmRezervacijaNovi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtKupacPrezime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKupacEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKupacIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntIzdaj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvKupacRezervacija = new System.Windows.Forms.DataGridView();
            this.dgvPopisProizvodaKojegNemaNaSkladistu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupacRezervacija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisProizvodaKojegNemaNaSkladistu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtKupacPrezime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKupacEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKupacIme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 105);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci naručitelja";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(414, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 22);
            this.textBox2.TabIndex = 32;
            // 
            // txtKupacPrezime
            // 
            this.txtKupacPrezime.Location = new System.Drawing.Point(78, 62);
            this.txtKupacPrezime.Name = "txtKupacPrezime";
            this.txtKupacPrezime.Size = new System.Drawing.Size(234, 22);
            this.txtKupacPrezime.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Prezime";
            // 
            // txtKupacEmail
            // 
            this.txtKupacEmail.Location = new System.Drawing.Point(414, 34);
            this.txtKupacEmail.Name = "txtKupacEmail";
            this.txtKupacEmail.Size = new System.Drawing.Size(234, 22);
            this.txtKupacEmail.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Email";
            // 
            // txtKupacIme
            // 
            this.txtKupacIme.Location = new System.Drawing.Point(78, 34);
            this.txtKupacIme.Name = "txtKupacIme";
            this.txtKupacIme.Size = new System.Drawing.Size(234, 22);
            this.txtKupacIme.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ime";
            // 
            // bntIzdaj
            // 
            this.bntIzdaj.Location = new System.Drawing.Point(724, 448);
            this.bntIzdaj.Name = "bntIzdaj";
            this.bntIzdaj.Size = new System.Drawing.Size(90, 44);
            this.bntIzdaj.TabIndex = 34;
            this.bntIzdaj.Text = "Izdaj";
            this.bntIzdaj.UseVisualStyleBackColor = true;
            this.bntIzdaj.Click += new System.EventHandler(this.bntIzdaj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(631, 448);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(90, 44);
            this.btnIzbrisi.TabIndex = 35;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(535, 448);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(90, 44);
            this.btnDodaj.TabIndex = 36;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(12, 448);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(90, 44);
            this.btnIzlaz.TabIndex = 37;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Popis stavki";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Iznos";
            // 
            // dgvKupacRezervacija
            // 
            this.dgvKupacRezervacija.AllowUserToAddRows = false;
            this.dgvKupacRezervacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKupacRezervacija.Location = new System.Drawing.Point(495, 155);
            this.dgvKupacRezervacija.Name = "dgvKupacRezervacija";
            this.dgvKupacRezervacija.RowTemplate.Height = 24;
            this.dgvKupacRezervacija.Size = new System.Drawing.Size(319, 287);
            this.dgvKupacRezervacija.TabIndex = 30;
            // 
            // dgvPopisProizvodaKojegNemaNaSkladistu
            // 
            this.dgvPopisProizvodaKojegNemaNaSkladistu.AllowUserToAddRows = false;
            this.dgvPopisProizvodaKojegNemaNaSkladistu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisProizvodaKojegNemaNaSkladistu.Location = new System.Drawing.Point(7, 155);
            this.dgvPopisProizvodaKojegNemaNaSkladistu.Name = "dgvPopisProizvodaKojegNemaNaSkladistu";
            this.dgvPopisProizvodaKojegNemaNaSkladistu.RowTemplate.Height = 24;
            this.dgvPopisProizvodaKojegNemaNaSkladistu.Size = new System.Drawing.Size(472, 287);
            this.dgvPopisProizvodaKojegNemaNaSkladistu.TabIndex = 31;
            // 
            // FrmRezervacijaNovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntIzdaj);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvKupacRezervacija);
            this.Controls.Add(this.dgvPopisProizvodaKojegNemaNaSkladistu);
            this.Name = "FrmRezervacijaNovi";
            this.Text = "FrmRezervacijaNovi";
            this.Load += new System.EventHandler(this.FrmRezervacijaNovi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupacRezervacija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisProizvodaKojegNemaNaSkladistu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtKupacPrezime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKupacEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKupacIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntIzdaj;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvKupacRezervacija;
        private System.Windows.Forms.DataGridView dgvPopisProizvodaKojegNemaNaSkladistu;
    }
}