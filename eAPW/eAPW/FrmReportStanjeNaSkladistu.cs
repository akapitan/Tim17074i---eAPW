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
    /// <summary>
    /// Klasa forme sa izvještajem o stanju na skladištu sa lokacije
    /// </summary>
    public partial class FrmReportStanjeNaSkladistu : Form
    {
        /// <summary>
        /// Konstruktor forme FrmReportStanjeNaSkladistu
        /// </summary>
        public FrmReportStanjeNaSkladistu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Prikazuje početne podatke na kontroli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReportStanjeNaSkladistu_Load(object sender, EventArgs e)
        {
            int lokacijaId = int.Parse(ConfigurationManager.AppSettings["LokacijaID"]);

            BindingList<StanjeNaSkladistu> listaStanjeNaSkladistu = null;
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                listaStanjeNaSkladistu = new BindingList<StanjeNaSkladistu>( db.StanjeNaSkladistus.Where(x => x.id == lokacijaId).ToList());
            }
            StanjeNaSkladistuBindingSource.DataSource = listaStanjeNaSkladistu;

            this.reportViewer1.RefreshReport();
        }

        /// <summary>
        /// Izlaz iz forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
