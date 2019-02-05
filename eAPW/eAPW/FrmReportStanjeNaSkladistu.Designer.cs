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
            this.BtnIzlaz = new System.Windows.Forms.Button();
            this.DatasetViews = new eAPW.DatasetViews();
            this.StanjeNaSkladistuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StanjeNaSkladistuTableAdapter = new eAPW.DatasetViewsTableAdapters.StanjeNaSkladistuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StanjeNaSkladistuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "StanjeNaSkladistu";
            reportDataSource1.Value = this.StanjeNaSkladistuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eAPW.ReportStanjeNaSkladistu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(860, 412);
            this.reportViewer1.TabIndex = 0;
            // 
            // BtnIzlaz
            // 
            this.BtnIzlaz.Location = new System.Drawing.Point(711, 432);
            this.BtnIzlaz.Name = "BtnIzlaz";
            this.BtnIzlaz.Size = new System.Drawing.Size(162, 41);
            this.BtnIzlaz.TabIndex = 1;
            this.BtnIzlaz.Text = "Izlaz";
            this.BtnIzlaz.UseVisualStyleBackColor = true;
            this.BtnIzlaz.Click += new System.EventHandler(this.BtnIzlaz_Click);
            // 
            // DatasetViews
            // 
            this.DatasetViews.DataSetName = "DatasetViews";
            this.DatasetViews.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StanjeNaSkladistuBindingSource
            // 
            this.StanjeNaSkladistuBindingSource.DataMember = "StanjeNaSkladistu";
            this.StanjeNaSkladistuBindingSource.DataSource = this.DatasetViews;
            // 
            // StanjeNaSkladistuTableAdapter
            // 
            this.StanjeNaSkladistuTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportStanjeNaSkladistu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 485);
            this.Controls.Add(this.BtnIzlaz);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportStanjeNaSkladistu";
            this.Text = "FrmReportStanjeNaSkladistu";
            this.Load += new System.EventHandler(this.FrmReportStanjeNaSkladistu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatasetViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StanjeNaSkladistuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button BtnIzlaz;
        private System.Windows.Forms.BindingSource StanjeNaSkladistuBindingSource;
        private DatasetViews DatasetViews;
        private DatasetViewsTableAdapters.StanjeNaSkladistuTableAdapter StanjeNaSkladistuTableAdapter;
    }
}