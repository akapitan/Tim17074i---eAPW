﻿namespace eAPW
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
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnicko = new System.Windows.Forms.TextBox();
            this.buttonPrijavaOdustani = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(130, 55);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(100, 22);
            this.txtLozinka.TabIndex = 15;
            // 
            // txtKorisnicko
            // 
            this.txtKorisnicko.Location = new System.Drawing.Point(130, 27);
            this.txtKorisnicko.Name = "txtKorisnicko";
            this.txtKorisnicko.Size = new System.Drawing.Size(100, 22);
            this.txtKorisnicko.TabIndex = 14;
            // 
            // buttonPrijavaOdustani
            // 
            this.buttonPrijavaOdustani.Location = new System.Drawing.Point(130, 116);
            this.buttonPrijavaOdustani.Name = "buttonPrijavaOdustani";
            this.buttonPrijavaOdustani.Size = new System.Drawing.Size(75, 23);
            this.buttonPrijavaOdustani.TabIndex = 17;
            this.buttonPrijavaOdustani.Text = "Odustani";
            this.buttonPrijavaOdustani.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lozinka";
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Location = new System.Drawing.Point(49, 116);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(75, 23);
            this.buttonPrijava.TabIndex = 16;
            this.buttonPrijava.Text = "Prijava";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Korisničko ime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 182);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnicko);
            this.Controls.Add(this.buttonPrijavaOdustani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

