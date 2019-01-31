namespace eAPW
{
    partial class FrmReportStanjeNaSkladistu
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
            this.StanjeNaSkladistuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StanjeNaSkladistuTableAdapter = new eAPW.ProgramskoInzenjerstvoDBDataSetTableAdapters.StanjeNaSkladistuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramskoInzenjerstvoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StanjeNaSkladistuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StanjeNaSkladistuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eAPW.ReportStanjeNaSkladištu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(883, 536);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProgramskoInzenjerstvoDBDataSet
            // 
            this.ProgramskoInzenjerstvoDBDataSet.DataSetName = "ProgramskoInzenjerstvoDBDataSet";
            this.ProgramskoInzenjerstvoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StanjeNaSkladistuBindingSource
            // 
            this.StanjeNaSkladistuBindingSource.DataMember = "StanjeNaSkladistu";
            this.StanjeNaSkladistuBindingSource.DataSource = this.ProgramskoInzenjerstvoDBDataSet;
            // 
            // StanjeNaSkladistuTableAdapter
            // 
            this.StanjeNaSkladistuTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportStanjeNaSkladistu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 561);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportStanjeNaSkladistu";
            this.Text = "FrmReportStanjeNaSkladistu";
            this.Load += new System.EventHandler(this.FrmReportStanjeNaSkladistu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProgramskoInzenjerstvoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StanjeNaSkladistuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StanjeNaSkladistuBindingSource;
        private ProgramskoInzenjerstvoDBDataSet ProgramskoInzenjerstvoDBDataSet;
        private ProgramskoInzenjerstvoDBDataSetTableAdapters.StanjeNaSkladistuTableAdapter StanjeNaSkladistuTableAdapter;
    }
}