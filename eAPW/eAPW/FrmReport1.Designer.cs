namespace eAPW
{
    partial class FrmReport1
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
            this.TrgovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProgramskoInzenjerstvoDBDataSet = new eAPW.ProgramskoInzenjerstvoDBDataSet();
            this.TrgovinaTableAdapter = new eAPW.ProgramskoInzenjerstvoDBDataSetTableAdapters.TrgovinaTableAdapter();
            this.Lokacija1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Lokacija1TableAdapter = new eAPW.ProgramskoInzenjerstvoDBDataSetTableAdapters.Lokacija1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TrgovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramskoInzenjerstvoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lokacija1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Lokacija1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eAPW.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(972, 466);
            this.reportViewer1.TabIndex = 0;
            // 
            // TrgovinaBindingSource
            // 
            this.TrgovinaBindingSource.DataMember = "Trgovina";
            this.TrgovinaBindingSource.DataSource = this.ProgramskoInzenjerstvoDBDataSet;
            // 
            // ProgramskoInzenjerstvoDBDataSet
            // 
            this.ProgramskoInzenjerstvoDBDataSet.DataSetName = "ProgramskoInzenjerstvoDBDataSet";
            this.ProgramskoInzenjerstvoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TrgovinaTableAdapter
            // 
            this.TrgovinaTableAdapter.ClearBeforeFill = true;
            // 
            // Lokacija1BindingSource
            // 
            this.Lokacija1BindingSource.DataMember = "Lokacija1";
            this.Lokacija1BindingSource.DataSource = this.ProgramskoInzenjerstvoDBDataSet;
            // 
            // Lokacija1TableAdapter
            // 
            this.Lokacija1TableAdapter.ClearBeforeFill = true;
            // 
            // FrmReport1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 489);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReport1";
            this.Text = "FrmReport1";
            this.Load += new System.EventHandler(this.FrmReport1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrgovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramskoInzenjerstvoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lokacija1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TrgovinaBindingSource;
        private ProgramskoInzenjerstvoDBDataSet ProgramskoInzenjerstvoDBDataSet;
        private ProgramskoInzenjerstvoDBDataSetTableAdapters.TrgovinaTableAdapter TrgovinaTableAdapter;
        private System.Windows.Forms.BindingSource Lokacija1BindingSource;
        private ProgramskoInzenjerstvoDBDataSetTableAdapters.Lokacija1TableAdapter Lokacija1TableAdapter;
    }
}