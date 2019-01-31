namespace eAPW
{
    partial class FrmReportDjeloviProdaniUZadnjihX
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
            this.DjelovaProdanihUZadnjihXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProgramskoInzenjerstvoDBDataSet = new eAPW.ProgramskoInzenjerstvoDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DjelovaProdanihUZadnjihXTableAdapter = new eAPW.ProgramskoInzenjerstvoDBDataSetTableAdapters.DjelovaProdanihUZadnjihXTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DjelovaProdanihUZadnjihXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramskoInzenjerstvoDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DjelovaProdanihUZadnjihXBindingSource
            // 
            this.DjelovaProdanihUZadnjihXBindingSource.DataMember = "DjelovaProdanihUZadnjihX";
            this.DjelovaProdanihUZadnjihXBindingSource.DataSource = this.ProgramskoInzenjerstvoDBDataSet;
            // 
            // ProgramskoInzenjerstvoDBDataSet
            // 
            this.ProgramskoInzenjerstvoDBDataSet.DataSetName = "ProgramskoInzenjerstvoDBDataSet";
            this.ProgramskoInzenjerstvoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DjelovaProdanihUZadnjihXBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eAPW.ReportDjelovaProdanihUZadnjihX.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(21, 106);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1154, 570);
            this.reportViewer1.TabIndex = 0;
            // 
            // DjelovaProdanihUZadnjihXTableAdapter
            // 
            this.DjelovaProdanihUZadnjihXTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(419, 37);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberi Vremenski Raspon";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(647, 37);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 3;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(419, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmReportDjeloviProdaniUZadnjihX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 701);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportDjeloviProdaniUZadnjihX";
            this.Text = "FrmReportDjeloviProdaniUZadnjihX";
            this.Load += new System.EventHandler(this.FrmReportDjeloviProdaniUZadnjihX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DjelovaProdanihUZadnjihXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramskoInzenjerstvoDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DjelovaProdanihUZadnjihXBindingSource;
        private ProgramskoInzenjerstvoDBDataSet ProgramskoInzenjerstvoDBDataSet;
        private ProgramskoInzenjerstvoDBDataSetTableAdapters.DjelovaProdanihUZadnjihXTableAdapter DjelovaProdanihUZadnjihXTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}