namespace eAPW
{
    partial class FrmRacuni
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
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnNoviVeleprodaja = new System.Windows.Forms.Button();
            this.bntNovi = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.cboxZaposlenik = new System.Windows.Forms.ComboBox();
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
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(741, 469);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(90, 44);
            this.btnIzbrisi.TabIndex = 15;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(645, 469);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(90, 44);
            this.btnPrikazi.TabIndex = 16;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnNoviVeleprodaja
            // 
            this.btnNoviVeleprodaja.Location = new System.Drawing.Point(535, 469);
            this.btnNoviVeleprodaja.Name = "btnNoviVeleprodaja";
            this.btnNoviVeleprodaja.Size = new System.Drawing.Size(104, 44);
            this.btnNoviVeleprodaja.TabIndex = 17;
            this.btnNoviVeleprodaja.Text = "Veleprodaja";
            this.btnNoviVeleprodaja.UseVisualStyleBackColor = true;
            this.btnNoviVeleprodaja.Click += new System.EventHandler(this.btnNoviVeleprodaja_Click);
            // 
            // bntNovi
            // 
            this.bntNovi.Location = new System.Drawing.Point(439, 469);
            this.bntNovi.Name = "bntNovi";
            this.bntNovi.Size = new System.Drawing.Size(90, 44);
            this.bntNovi.TabIndex = 18;
            this.bntNovi.Text = "Novi";
            this.bntNovi.UseVisualStyleBackColor = true;
            this.bntNovi.Click += new System.EventHandler(this.bntNovi_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(26, 469);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(90, 44);
            this.btnIzlaz.TabIndex = 19;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // cboxZaposlenik
            // 
            this.cboxZaposlenik.FormattingEnabled = true;
            this.cboxZaposlenik.Location = new System.Drawing.Point(137, 10);
            this.cboxZaposlenik.Name = "cboxZaposlenik";
            this.cboxZaposlenik.Size = new System.Drawing.Size(200, 24);
            this.cboxZaposlenik.TabIndex = 14;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(137, 92);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.ReadOnly = true;
            this.txtIznos.Size = new System.Drawing.Size(200, 22);
            this.txtIznos.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Popis računa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Iznos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Iznos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Zaposlenik";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(137, 53);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 287);
            this.dataGridView1.TabIndex = 6;
            // 
            // FrmRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 585);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnNoviVeleprodaja);
            this.Controls.Add(this.bntNovi);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.cboxZaposlenik);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmRacuni";
            this.Text = "FrmRacuni";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnNoviVeleprodaja;
        private System.Windows.Forms.Button bntNovi;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.ComboBox cboxZaposlenik;
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