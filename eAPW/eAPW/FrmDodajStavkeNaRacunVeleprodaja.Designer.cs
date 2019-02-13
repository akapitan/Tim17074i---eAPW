namespace eAPW
{
    partial class FrmDodajStavkeNaRacunVeleprodaja
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelektiraniNaziv = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPopisStavki = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisStavki)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSelektiraniNaziv);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Location = new System.Drawing.Point(26, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 60);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selektirani predmet";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(312, 30);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(127, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Količina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // txtSelektiraniNaziv
            // 
            this.txtSelektiraniNaziv.Location = new System.Drawing.Point(69, 25);
            this.txtSelektiraniNaziv.Name = "txtSelektiraniNaziv";
            this.txtSelektiraniNaziv.ReadOnly = true;
            this.txtSelektiraniNaziv.Size = new System.Drawing.Size(162, 22);
            this.txtSelektiraniNaziv.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(474, 21);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(92, 35);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(26, 545);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(92, 35);
            this.btnOdustani.TabIndex = 13;
            this.btnOdustani.Text = "Natrag";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(93, 24);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(162, 22);
            this.txtPretraga.TabIndex = 12;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pretraga";
            // 
            // dgvPopisStavki
            // 
            this.dgvPopisStavki.AllowUserToAddRows = false;
            this.dgvPopisStavki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisStavki.Location = new System.Drawing.Point(26, 140);
            this.dgvPopisStavki.Name = "dgvPopisStavki";
            this.dgvPopisStavki.ReadOnly = true;
            this.dgvPopisStavki.RowTemplate.Height = 24;
            this.dgvPopisStavki.Size = new System.Drawing.Size(596, 347);
            this.dgvPopisStavki.TabIndex = 10;
            this.dgvPopisStavki.SelectionChanged += new System.EventHandler(this.dgvPopisStavki_SelectionChanged);
            // 
            // FrmDodajStavkeNaRacunVeleprodaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPopisStavki);
            this.Name = "FrmDodajStavkeNaRacunVeleprodaja";
            this.Text = "eAPW  Dodaj stavke na račun";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmDodajStavkeNaRacunVeleprodaja_HelpRequested);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisStavki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelektiraniNaziv;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPopisStavki;
    }
}