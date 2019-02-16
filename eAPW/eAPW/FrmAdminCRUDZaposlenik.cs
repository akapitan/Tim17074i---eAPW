using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAPW
{
    /// <summary>
    /// Klasa forme za upravljanje zaposlenicima
    /// </summary>
    public partial class FrmAdminCRUDZaposlenik : Form
    {
        /// <summary>
        /// Konstruktor forme FrmAdminCRUDZaposlenik
        /// </summary>
        public FrmAdminCRUDZaposlenik()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Izlaz iz forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Prikazuje početne podatke na kontroli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFormAdminCRUDZaposlenik_Load(object sender, EventArgs e)
        {
            ProvjeriZaposlenika();
        }
        private void ProvjeriZaposlenika()
        {

            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                List<Zaposlenik> ls = new List<Zaposlenik>();
                foreach (Zaposlenik z in db.Zaposleniks)
                {
                    ls.Add(z);
                }
                dataGridView1.DataSource = new BindingSource(ls, null);
                dataGridView1.Columns["Zaposlenik_has_Tip"].Visible = false;

            }
        }


        /// <summary>
        /// Otvara formu FrmAdminCRUDZaposlenikNovi za unos novog zaposlenika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovi_Click(object sender, EventArgs e)
        {
            FrmAdminCRUDZaposlenikNovi f = new FrmAdminCRUDZaposlenikNovi();
            f.ShowDialog();
            ProvjeriZaposlenika();
        }

        /// <summary>
        /// Otvara formu FrmAdminCRUDZaposlenikNovi za izmjenu podatke selektiranog zaposlenika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            Zaposlenik zaIzmjenu = dataGridView1.CurrentRow.DataBoundItem as Zaposlenik;

            FrmAdminCRUDZaposlenikNovi f = new FrmAdminCRUDZaposlenikNovi(zaIzmjenu);
            f.ShowDialog();
            ProvjeriZaposlenika();
        }
    }
}
