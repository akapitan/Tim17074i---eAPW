namespace eAPW
{
    partial class FrmSkladiste
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvDjeloviNaSkladistima = new System.Windows.Forms.DataGridView();
            this.txtPromjeniNaSkladistu = new System.Windows.Forms.TextBox();
            this.btnPromjeniNaSkladistu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjeloviNaSkladistima)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(106, 36);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(144, 22);
            this.txtPretraga.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Pretraga";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(27, 430);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(90, 44);
            this.btnIzlaz.TabIndex = 24;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(541, 328);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dgvDjeloviNaSkladistima
            // 
            this.dgvDjeloviNaSkladistima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDjeloviNaSkladistima.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDjeloviNaSkladistima.Location = new System.Drawing.Point(584, 86);
            this.dgvDjeloviNaSkladistima.Name = "dgvDjeloviNaSkladistima";
            this.dgvDjeloviNaSkladistima.RowTemplate.Height = 24;
            this.dgvDjeloviNaSkladistima.Size = new System.Drawing.Size(390, 268);
            this.dgvDjeloviNaSkladistima.TabIndex = 23;
            this.dgvDjeloviNaSkladistima.SelectionChanged += new System.EventHandler(this.dgvDjeloviNaSkladistima_SelectionChanged);
            // 
            // txtPromjeniNaSkladistu
            // 
            this.txtPromjeniNaSkladistu.Location = new System.Drawing.Point(677, 380);
            this.txtPromjeniNaSkladistu.Name = "txtPromjeniNaSkladistu";
            this.txtPromjeniNaSkladistu.Size = new System.Drawing.Size(144, 22);
            this.txtPromjeniNaSkladistu.TabIndex = 26;
            
            // 
            // btnPromjeniNaSkladistu
            // 
            this.btnPromjeniNaSkladistu.Location = new System.Drawing.Point(827, 369);
            this.btnPromjeniNaSkladistu.Name = "btnPromjeniNaSkladistu";
            this.btnPromjeniNaSkladistu.Size = new System.Drawing.Size(129, 45);
            this.btnPromjeniNaSkladistu.TabIndex = 27;
            this.btnPromjeniNaSkladistu.Text = "Promjeni na skladištu";
            this.btnPromjeniNaSkladistu.UseVisualStyleBackColor = true;
            this.btnPromjeniNaSkladistu.Click += new System.EventHandler(this.btnPromjeniNaSkladistu_Click);
            // 
            // FrmSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 500);
            this.Controls.Add(this.btnPromjeniNaSkladistu);
            this.Controls.Add(this.txtPromjeniNaSkladistu);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dgvDjeloviNaSkladistima);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmSkladiste";
            this.Text = "Skladište";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDjeloviNaSkladistima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvDjeloviNaSkladistima;
        private System.Windows.Forms.TextBox txtPromjeniNaSkladistu;
        private System.Windows.Forms.Button btnPromjeniNaSkladistu;
    }
}