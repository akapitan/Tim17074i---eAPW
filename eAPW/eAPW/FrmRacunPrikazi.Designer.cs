namespace eAPW
{
    partial class FrmRacunPrikazi
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
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.txtIzdao = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntNatrag
            // 
            this.bntNatrag.Location = new System.Drawing.Point(30, 342);
            this.bntNatrag.Name = "bntNatrag";
            this.bntNatrag.Size = new System.Drawing.Size(117, 46);
            this.bntNatrag.TabIndex = 11;
            this.bntNatrag.Text = "Natrag";
            this.bntNatrag.UseVisualStyleBackColor = true;
            this.bntNatrag.Click += new System.EventHandler(this.bntNatrag_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 165);
            this.dataGridView1.TabIndex = 10;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(113, 101);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.ReadOnly = true;
            this.txtIznos.Size = new System.Drawing.Size(145, 22);
            this.txtIznos.TabIndex = 7;
            // 
            // txtIzdao
            // 
            this.txtIzdao.Location = new System.Drawing.Point(113, 63);
            this.txtIzdao.Name = "txtIzdao";
            this.txtIzdao.ReadOnly = true;
            this.txtIzdao.Size = new System.Drawing.Size(145, 22);
            this.txtIzdao.TabIndex = 8;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(113, 28);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(145, 22);
            this.txtDatum.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Iznos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Izdao";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datum";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ispis računa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRacunPrikazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntNatrag);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtIzdao);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRacunPrikazi";
            this.Text = "FrmRacunPrikazi";
            this.Load += new System.EventHandler(this.FrmRacunPrikazi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntNatrag;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.TextBox txtIzdao;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}