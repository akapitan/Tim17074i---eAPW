using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace eAPW
{
    public partial class FrmReportDjeloviProdaniUZadnjihX : Form
    {
        public FrmReportDjeloviProdaniUZadnjihX()
        {
            InitializeComponent();
        }
        int lokacijaId = int.Parse(ConfigurationManager.AppSettings["LokacijaID"]);

        private void FrmReportDjeloviProdaniUZadnjihX_Load(object sender, EventArgs e)
        {
            reportViewer1.Width = (int)(this.Width * 0.9);            
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            DateTime time1 = dateTimePicker1.Value;
            DateTime time2 = dateTimePicker2.Value;

            this.DjelovaProdanihUZadnjihXTableAdapter.Fill(this.ProgramskoInzenjerstvoDBDataSet.DjelovaProdanihUZadnjihX, time1.ToShortDateString(),  time2.ToShortDateString(), lokacijaId);

            this.reportViewer1.RefreshReport();
        }
    }
}
