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
    /// Klasa za evidenciju računa
    /// </summary>
    public partial class FrmRacuni : Form
    {
        /// <summary>
        /// Konstruktor forme za evidenciju računa
        /// </summary>
        public FrmRacuni()
        {
            InitializeComponent();
            ispisDatagrid();
            upisiPodatkeUCombobox();
        }

        /// <summary>
        /// Funkcija za ispisivanje računa.
        /// </summary>
        private void ispisDatagrid()
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                List<Racun> ls = new List<Racun>();
                int lokacijaId = int.Parse(ConfigurationManager.AppSettings["LokacijaID"]);
                foreach (Racun z in db.Racuns.Where(x=> x.lokacija == lokacijaId).OrderByDescending(x=> x.datum))
                {
                    ls.Add(z);
                }
                dataGridView1.DataSource = new BindingSource(ls, null);
                dataGridView1.Columns["Racun_has_djelovi"].Visible = false;
                dataGridView1.Columns["Zaposlenik1"].Visible = false;
                dataGridView1.Columns["trgovina"].Visible = false;
                dataGridView1.Columns["Trgovina1"].Visible = false;
                dataGridView1.Columns["lokacija"].Visible = false;
                dataGridView1.Columns["Lokacija1"].Visible = false;

            }
        }
        /// <summary>
        /// Ispis zaposlenika u comboBox.
        /// </summary>
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

        /// <summary>
        /// Izlaz iz forme FrmRacuni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// FUnkcija za brisanje selektiranog računa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Otvaranje forme za dodavanje novog maloprodajnog računa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntNovi_Click(object sender, EventArgs e)
        {
            FrmRacunNoviMaloprodaja f = new FrmRacunNoviMaloprodaja();
            f.ShowDialog();
            ispisDatagrid();
        }

        /// <summary>
        /// Otvaranje forme za dodavanje novog veleprodajnog računa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNoviVeleprodaja_Click(object sender, EventArgs e)
        {
            FrmRacunNoviVeleprodaja f = new FrmRacunNoviVeleprodaja();
            f.ShowDialog();
            ispisDatagrid();
        }

        /// <summary>
        /// Otvararanje forme za prikaz selektiranog računa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            Racun selektiraniRacun = dataGridView1.CurrentRow.DataBoundItem as Racun;
            if (selektiraniRacun != null)
            {
                FrmRacunPrikazi frp = new FrmRacunPrikazi(selektiraniRacun.id);
                frp.Show();
            }
        }

        /// <summary>
        /// Otvaranje help dokumenta pritiskom na F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="hlpevent"></param>
        private void FrmRacuni_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Prodaja.htm");
        }
    }
}
