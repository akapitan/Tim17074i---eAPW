namespace eAPW
{
    partial class FrmReportRezervacijeUZadnjih2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatasetViews = new eAPW.DatasetViews();
            this.BrojRezervacijaUZadnjihXNaLokacijiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BrojRezervacijaUZadnjihXNaLokacijiTableAdapter = new eAPW.DatasetViewsTableAdapters.BrojRezervacijaUZadnjihXNaLokacijiTableAdapter();
            this.BtnIzlaz = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrojRezervacijaUZadnjihXNaLokacijiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "ReportRezervacijeUZadnjih";
            reportDataSource2.Value = this.BrojRezervacijaUZadnjihXNaLokacijiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eAPW.ReportRezervacijeUZadnjih2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 75);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(818, 352);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatasetViews
            // 
            this.DatasetViews.DataSetName = "DatasetViews";
            this.DatasetViews.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BrojRezervacijaUZadnjihXNaLokacijiBindingSource
            // 
            this.BrojRezervacijaUZadnjihXNaLokacijiBindingSource.DataMember = "BrojRezervacijaUZadnjihXNaLokaciji";
            this.BrojRezervacijaUZadnjihXNaLokacijiBindingSource.DataSource = this.DatasetViews;
            // 
            // BrojRezervacijaUZadnjihXNaLokacijiTableAdapter
            // 
            this.BrojRezervacijaUZadnjihXNaLokacijiTableAdapter.ClearBeforeFill = true;
            // 
            // BtnIzlaz
            // 
            this.BtnIzlaz.Location = new System.Drawing.Point(735, 434);
            this.BtnIzlaz.Name = "BtnIzlaz";
            this.BtnIzlaz.Size = new System.Drawing.Size(96, 35);
            this.BtnIzlaz.TabIndex = 1;
            this.BtnIzlaz.Text = "Izlaz";
            this.BtnIzlaz.UseVisualStyleBackColor = true;
            this.BtnIzlaz.Click += new System.EventHandler(this.BtnIzlaz_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(643, 20);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 12;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Odaberi Vremenski Raspon";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(415, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // FrmReportRezervacijeUZadnjih2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 492);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnIzlaz);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportRezervacijeUZadnjih2";
            this.Text = "FrmReportRezervacijeUZadnjih2";
            this.Load += new System.EventHandler(this.FrmReportRezervacijeUZadnjih2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatasetViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrojRezervacijaUZadnjihXNaLokacijiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BrojRezervacijaUZadnjihXNaLokacijiBindingSource;
        private DatasetViews DatasetViews;
        private DatasetViewsTableAdapters.BrojRezervacijaUZadnjihXNaLokacijiTableAdapter BrojRezervacijaUZadnjihXNaLokacijiTableAdapter;
        private System.Windows.Forms.Button BtnIzlaz;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}