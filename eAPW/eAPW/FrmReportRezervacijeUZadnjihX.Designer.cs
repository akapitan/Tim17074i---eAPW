namespace eAPW
{
    partial class FrmReportRezervacijeUZadnjihX
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProgramskoInzenjerstvoDBDataSet = new eAPW.ProgramskoInzenjerstvoDBDataSet();
            this.BrojRezervacijaUZadnjihXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BrojRezervacijaUZadnjihXTableAdapter = new eAPW.ProgramskoInzenjerstvoDBDataSetTableAdapters.BrojRezervacijaUZadnjihXTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramskoInzenjerstvoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrojRezervacijaUZadnjihXBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BrojRezervacijaUZadnjihXBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eAPW.ReportRezervacijeUZadnjih.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1176, 463);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProgramskoInzenjerstvoDBDataSet
            // 
            this.ProgramskoInzenjerstvoDBDataSet.DataSetName = "ProgramskoInzenjerstvoDBDataSet";
            this.ProgramskoInzenjerstvoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BrojRezervacijaUZadnjihXBindingSource
            // 
            this.BrojRezervacijaUZadnjihXBindingSource.DataMember = "BrojRezervacijaUZadnjihX";
            this.BrojRezervacijaUZadnjihXBindingSource.DataSource = this.ProgramskoInzenjerstvoDBDataSet;
            // 
            // BrojRezervacijaUZadnjihXTableAdapter
            // 
            this.BrojRezervacijaUZadnjihXTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(418, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(646, 18);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 8;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Odaberi Vremenski Raspon";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(418, 18);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // FrmReportRezervacijeUZadnjihX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 570);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportRezervacijeUZadnjihX";
            this.Text = "FrmReportRezervacijeUZadnjihX";
            this.Load += new System.EventHandler(this.FrmReportRezervacijeUZadnjihX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProgramskoInzenjerstvoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrojRezervacijaUZadnjihXBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BrojRezervacijaUZadnjihXBindingSource;
        private ProgramskoInzenjerstvoDBDataSet ProgramskoInzenjerstvoDBDataSet;
        private ProgramskoInzenjerstvoDBDataSetTableAdapters.BrojRezervacijaUZadnjihXTableAdapter BrojRezervacijaUZadnjihXTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}