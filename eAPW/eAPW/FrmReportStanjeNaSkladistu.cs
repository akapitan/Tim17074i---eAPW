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
    public partial class FrmReportStanjeNaSkladistu : Form
    {
        public FrmReportStanjeNaSkladistu()
        {
            InitializeComponent();
        }

        private void FrmReportStanjeNaSkladistu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ProgramskoInzenjerstvoDBDataSet.StanjeNaSkladistu' table. You can move, or remove it, as needed.
            int lokacijaId = int.Parse(ConfigurationManager.AppSettings["LokacijaID"]);
            this.StanjeNaSkladistuTableAdapter.Fill(this.ProgramskoInzenjerstvoDBDataSet.StanjeNaSkladistu, lokacijaId);

            this.reportViewer1.RefreshReport();
        }
    }
}
