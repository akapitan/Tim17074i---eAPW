namespace eAPW
{
    partial class FrmReportDjeloviProdaniUZadnjihX2
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
            this.BrojDjelovaProdanihUZadnjihXNaLokacijiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasetViews = new eAPW.DatasetViews();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BrojDjelovaProdanihUZadnjihXNaLokacijiTableAdapter = new eAPW.DatasetViewsTableAdapters.BrojDjelovaProdanihUZadnjihXNaLokacijiTableAdapter();
            this.BtnIzlaz = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.BrojDjelovaProdanihUZadnjihXNaLokacijiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetViews)).BeginInit();
            this.SuspendLayout();
            // 
            // BrojDjelovaProdanihUZadnjihXNaLokacijiBindingSource
            // 
            this.BrojDjelovaProdanihUZadnjihXNaLokacijiBindingSource.DataMember = "BrojDjelovaProdanihUZadnjihXNaLokaciji";
            this.BrojDjelovaProdanihUZadnjihXNaLokacijiBindingSource.DataSource = this.DatasetViews;
            // 
            // DatasetViews
            // 
            this.DatasetViews.DataSetName = "DatasetViews";
            this.DatasetViews.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReportDjelovaProdanihUZadnjihX2";
            reportDataSource1.Value = this.BrojDjelovaProdanihUZadnjihXNaLokacijiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eAPW.ReportDjelovaProdanihUZadnjihX2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(910, 386);
            this.reportViewer1.TabIndex = 0;
            // 
            // BrojDjelovaProdanihUZadnjihXNaLokacijiTableAdapter
            // 
            this.BrojDjelovaProdanihUZadnjihXNaLokacijiTableAdapter.ClearBeforeFill = true;
            // 
            // BtnIzlaz
            // 
            this.BtnIzlaz.Location = new System.Drawing.Point(764, 470);
            this.BtnIzlaz.Name = "BtnIzlaz";
            this.BtnIzlaz.Size = new System.Drawing.Size(159, 46);
            this.BtnIzlaz.TabIndex = 1;
            this.BtnIzlaz.Text = "Izlaz";
            this.BtnIzlaz.UseVisualStyleBackColor = true;
            this.BtnIzlaz.Click += new System.EventHandler(this.BtnIzlaz_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(646, 30);
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
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Odaberi Vremenski Raspon";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(418, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // FrmReportDjeloviProdaniUZadnjihX2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 572);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnIzlaz);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportDjeloviProdaniUZadnjihX2";
            this.Text = "FrmReportDjeloviProdaniUZadnjihX2";
            this.Load += new System.EventHandler(this.FrmReportDjeloviProdaniUZadnjihX2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BrojDjelovaProdanihUZadnjihXNaLokacijiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetViews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BrojDjelovaProdanihUZadnjihXNaLokacijiBindingSource;
        private DatasetViews DatasetViews;
        private DatasetViewsTableAdapters.BrojDjelovaProdanihUZadnjihXNaLokacijiTableAdapter BrojDjelovaProdanihUZadnjihXNaLokacijiTableAdapter;
        private System.Windows.Forms.Button BtnIzlaz;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}