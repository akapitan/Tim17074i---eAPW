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

            comboBox1.Items.Add("U zadnjih godinu dana");
            comboBox1.Items.Add("U zadnjih 6 mjeseci");
            comboBox1.Items.Add("U zadnjih 3 mjeseca");
            comboBox1.Items.Add("U zadnjih mjesec");
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            DateTime time1 = dateTimePicker1.Value;
            DateTime time2 = dateTimePicker2.Value;

            this.DjelovaProdanihUZadnjihXTableAdapter.Fill(this.ProgramskoInzenjerstvoDBDataSet.DjelovaProdanihUZadnjihX, time1.ToShortDateString(),  time2.ToShortDateString(), lokacijaId);

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    this.DjelovaProdanihUZadnjihXTableAdapter.Fill(this.ProgramskoInzenjerstvoDBDataSet.DjelovaProdanihUZadnjihX, DateTime.Now.AddDays(-365).ToShortDateString(), DateTime.Now.ToShortDateString(), lokacijaId);
                    this.reportViewer1.RefreshReport();
                    break;
                case 1:
                    this.DjelovaProdanihUZadnjihXTableAdapter.Fill(this.ProgramskoInzenjerstvoDBDataSet.DjelovaProdanihUZadnjihX, DateTime.Now.AddDays(-183).ToShortDateString(), DateTime.Now.ToShortDateString(), lokacijaId);
                    this.reportViewer1.RefreshReport();
                    break;
                case 2:
                    this.DjelovaProdanihUZadnjihXTableAdapter.Fill(this.ProgramskoInzenjerstvoDBDataSet.DjelovaProdanihUZadnjihX, DateTime.Now.AddDays(-92).ToShortDateString(), DateTime.Now.ToShortDateString(), lokacijaId);
                    this.reportViewer1.RefreshReport();
                    break;
                case 3:
                    this.DjelovaProdanihUZadnjihXTableAdapter.Fill(this.ProgramskoInzenjerstvoDBDataSet.DjelovaProdanihUZadnjihX, DateTime.Now.AddDays(-31).ToShortDateString(), DateTime.Now.ToShortDateString(), lokacijaId);
                    this.reportViewer1.RefreshReport();
                    break;
                default:
                    break;
            }
        }
    }
}
