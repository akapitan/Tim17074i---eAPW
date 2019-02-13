namespace eAPW
{
    partial class FrmRezervacijaPrikaz
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
            this.bntNatrag = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntNatrag
            // 
            this.bntNatrag.Location = new System.Drawing.Point(27, 343);
            this.bntNatrag.Name = "bntNatrag";
            this.bntNatrag.Size = new System.Drawing.Size(117, 46);
            this.bntNatrag.TabIndex = 19;
            this.bntNatrag.Text = "Natrag";
            this.bntNatrag.UseVisualStyleBackColor = true;
            this.bntNatrag.Click += new System.EventHandler(this.bntNatrag_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 165);
            this.dataGridView1.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(184, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(110, 64);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(184, 22);
            this.txtPrezime.TabIndex = 16;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(110, 29);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(184, 22);
            this.txtIme.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ime";
            // 
            // FrmRezervacijaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 423);
            this.Controls.Add(this.bntNatrag);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRezervacijaPrikaz";
            this.Text = "FrmRezervacijaPrikaz";
            this.Load += new System.EventHandler(this.FrmRezervacijaPrikaz_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmRezervacijaPrikaz_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntNatrag;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}