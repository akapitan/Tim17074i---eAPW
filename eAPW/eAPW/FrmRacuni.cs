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
    public partial class FrmRacuni : Form
    {
        public FrmRacuni()
        {
            InitializeComponent();
            ispisDatagrid();
            upisiPodatkeUCombobox();
        }

        private void ispisDatagrid()
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                List<Racun> ls = new List<Racun>();
                foreach (Racun z in db.Racuns)
                {
                    ls.Add(z);
                }
                dataGridView1.DataSource = new BindingSource(ls, null);
                dataGridView1.Columns["Racun_has_djelovi"].Visible = false;
                dataGridView1.Columns["Zaposlenik1"].Visible = false;
                dataGridView1.Columns["trgovina"].Visible = false;
                dataGridView1.Columns["Trgovina1"].Visible = false;

            }
        }
        private void upisiPodatkeUCombobox()
        {
            cboxZaposlenik.Items.Clear();
            cboxZaposlenik.Items.Add("svi");
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                foreach (Zaposlenik z in db.Zaposleniks)
                {
                    cboxZaposlenik.Items.Add(z);
                }
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            Racun zaIzbrisati = dataGridView1.CurrentRow.DataBoundItem as Racun;
            if (zaIzbrisati != null)
                if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new ProgramskoInzenjerstvoDBEntities())
                    {
                        db.Racuns.Attach(zaIzbrisati);
                        db.Racuns.Remove(zaIzbrisati);
                        foreach (var izbrisatiProvjera in db.Racun_Has_Djelovi)
                        {
                            if (izbrisatiProvjera.id_racun == zaIzbrisati.id)
                            {
                                db.Racun_Has_Djelovi.Attach(izbrisatiProvjera);
                                db.Racun_Has_Djelovi.Remove(izbrisatiProvjera);
                            }
                        }

                        db.SaveChanges();
                    }
                }

            ispisDatagrid();
        }

        private void bntNovi_Click(object sender, EventArgs e)
        {
            FrmRacunNoviMaloprodaja f = new FrmRacunNoviMaloprodaja();
            f.ShowDialog();
            ispisDatagrid();
        }

        private void btnNoviVeleprodaja_Click(object sender, EventArgs e)
        {
            FrmRacunNoviVeleprodaja f = new FrmRacunNoviVeleprodaja();
            f.ShowDialog();
            ispisDatagrid();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            Racun selektiraniRacun = dataGridView1.CurrentRow.DataBoundItem as Racun;
            if (selektiraniRacun != null)
            {
                FrmRacunPrikazi frp = new FrmRacunPrikazi(selektiraniRacun.id);
                frp.Show();
            }
        }
    }
}
