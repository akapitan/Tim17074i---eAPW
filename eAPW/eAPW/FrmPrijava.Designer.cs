namespace eAPW
{
    partial class FrmPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrijava));
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnicko = new System.Windows.Forms.TextBox();
            this.buttonPrijavaOdustani = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(300, 83);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(212, 22);
            this.txtLozinka.TabIndex = 15;
            this.txtLozinka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLozinka_KeyDown);
            // 
            // txtKorisnicko
            // 
            this.txtKorisnicko.Location = new System.Drawing.Point(300, 55);
            this.txtKorisnicko.Name = "txtKorisnicko";
            this.txtKorisnicko.Size = new System.Drawing.Size(212, 22);
            this.txtKorisnicko.TabIndex = 14;
            this.txtKorisnicko.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKorisnicko_KeyDown);
            // 
            // buttonPrijavaOdustani
            // 
            this.buttonPrijavaOdustani.Location = new System.Drawing.Point(373, 137);
            this.buttonPrijavaOdustani.Name = "buttonPrijavaOdustani";
            this.buttonPrijavaOdustani.Size = new System.Drawing.Size(86, 32);
            this.buttonPrijavaOdustani.TabIndex = 17;
            this.buttonPrijavaOdustani.Text = "Odustani";
            this.buttonPrijavaOdustani.UseVisualStyleBackColor = true;
            this.buttonPrijavaOdustani.Click += new System.EventHandler(this.buttonPrijavaOdustani_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lozinka";
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Location = new System.Drawing.Point(283, 137);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(84, 32);
            this.buttonPrijava.TabIndex = 16;
            this.buttonPrijava.Text = "Prijava";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Korisničko ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Poslovnica";
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(300, 29);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.ReadOnly = true;
            this.txtLokacija.Size = new System.Drawing.Size(212, 22);
            this.txtLokacija.TabIndex = 14;
            this.txtLokacija.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKorisnicko_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 196);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.txtKorisnicko);
            this.Controls.Add(this.buttonPrijavaOdustani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrijava";
            this.Text = "Prijava";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmPrijava_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnicko;
        private System.Windows.Forms.Button buttonPrijavaOdustani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

