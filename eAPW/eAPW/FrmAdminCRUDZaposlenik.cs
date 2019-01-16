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
    public partial class FrmAdminCRUDZaposlenik : Form
    {
        public FrmAdminCRUDZaposlenik()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void btnNovi_Click(object sender, EventArgs e)
        {
            FrmAdminCRUDZaposlenikNovi f = new FrmAdminCRUDZaposlenikNovi();
            f.ShowDialog();
            ProvjeriZaposlenika();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            Zaposlenik zaIzmjenu = dataGridView1.CurrentRow.DataBoundItem as Zaposlenik;

            FrmAdminCRUDZaposlenikNovi f = new FrmAdminCRUDZaposlenikNovi(zaIzmjenu);
            f.ShowDialog();
            ProvjeriZaposlenika();
        }
    }
}
