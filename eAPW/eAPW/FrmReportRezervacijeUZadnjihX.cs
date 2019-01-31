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
    public partial class FrmReportRezervacijeUZadnjihX : Form
    {
        public FrmReportRezervacijeUZadnjihX()
        {
            InitializeComponent();
        }

        int lokacijaId = int.Parse(ConfigurationManager.AppSettings["LokacijaID"]);

        private void FrmReportRezervacijeUZadnjihX_Load(object sender, EventArgs e)
        {
            reportViewer1.Width = (int)(this.Width * 0.9);

            comboBox1.Items.Add("U zadnjih godinu dana");
            comboBox1.Items.Add("U zadnjih 6 mjeseci");
            comboBox1.Items.Add("U zadnjih 3 mjeseca");
            comboBox1.Items.Add("U zadnjih mjesec");

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {

            DateTime time1 = dateTimePicker1.Value;
            DateTime time2 = dateTimePicker2.Value;
            this.BrojRezervacijaUZadnjihXTableAdapter.Fill(this.ProgramskoInzenjerstvoDBDataSet.BrojRezervacijaUZadnjihX, time1, time2, lokacijaId);

            this.reportViewer1.RefreshReport();
        }
    }
}
