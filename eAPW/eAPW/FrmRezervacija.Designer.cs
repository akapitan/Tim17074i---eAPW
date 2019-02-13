namespace eAPW
{
    partial class FrmRezervacija
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
            this.bntNovi = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(732, 394);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(90, 44);
            this.btnIzbrisi.TabIndex = 2;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(636, 394);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(90, 44);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // bntNovi
            // 
            this.bntNovi.Location = new System.Drawing.Point(540, 394);
            this.bntNovi.Name = "bntNovi";
            this.bntNovi.Size = new System.Drawing.Size(90, 44);
            this.bntNovi.TabIndex = 0;
            this.bntNovi.Text = "Nova rezervacija";
            this.bntNovi.UseVisualStyleBackColor = true;
            this.bntNovi.Click += new System.EventHandler(this.bntNovi_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(17, 394);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(90, 44);
            this.btnIzlaz.TabIndex = 3;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Popis narudžba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Iznos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 287);
            this.dataGridView1.TabIndex = 20;
            // 
            // FrmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 478);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.bntNovi);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmRezervacija";
            this.Text = "FrmRezervacija";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmRezervacija_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button bntNovi;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}