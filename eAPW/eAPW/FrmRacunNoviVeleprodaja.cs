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
    /// Klasa za kreiranje veleprodajnog računa
    /// </summary>
    public partial class FrmRacunNoviVeleprodaja : Form
    {
        /// <summary>
        /// Dodane stavke na račun
        /// </summary>
        public static BindingList<Djelovi> bl = new BindingList<Djelovi>(); 

        /// <summary>
        /// Konstruktor forme za dodavanje veleprodajnog računa
        /// </summary>
        public FrmRacunNoviVeleprodaja()
        {
            InitializeComponent();
            bl.Clear();
            txtZaposlenik.Text = FrmGlavna.prijavljeniKorisnik.korisnickoIme;
            this.dtpDatum.Enabled = false;
            ispisComboBox();
        }

        /// <summary>
        /// Otvaranje forme za dodavanje/ažuriranje tvrtki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajNovuTvrtku_Click(object sender, EventArgs e)
        {
            new FrmTvrtkePregled().ShowDialog();
            ispisComboBox();
        }

        /// <summary>
        /// Funkcija za ispis tvrtki u combobox.
        /// </summary>
        private void ispisComboBox()
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                var tvrtke = db.Trgovinas.ToList();
                BindingSource bs = new BindingSource(tvrtke, null);
                cboxTvrtka.DataSource = bs;
            }
        }

        /// <summary>
        /// Ispis stavaka na datagridview s liste "bl"
        /// </summary>
        private void ispisDatagridview()
        {

            dataGridView1.DataSource = bl;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Visible = false;
                dataGridView1.Columns[i].ReadOnly = true;
            }
            dataGridView1.Columns["Id"].Visible = true;
            dataGridView1.Columns["Naziv"].Visible = true;
            dataGridView1.Columns["veleprodajnaCijena"].Visible = true;
            dataGridView1.Columns["kolicina"].Visible = true;

            //DataGridViewColumn col = new DataGridViewTextBoxColumn();
            //col.DataPropertyName = "Kolicina";
            //col.HeaderText = "Kolicina";
            //col.Name = "foo";
            //dataGridView1.Columns.Add(col);

            if (bl.Count == 0) txtIznos.Text = "0 kn";
            else
            {
                int iznos = 0;
                foreach (Djelovi dio in bl)
                {
                    iznos += (dio.kolicina * dio.veleprodajnaCijena);
                }
                txtIznos.Text = iznos.ToString() + " kn";
            }


        }

        /// <summary>
        /// Izlaz iz forme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Otvaranje forme za dodavnje stavaka na veleprodajni račun.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajStavkeNaRacunVeleprodaja fdsnrv = new FrmDodajStavkeNaRacunVeleprodaja();
            fdsnrv.ShowDialog();
            ispisDatagridview();
        }

        /// <summary>
        /// Funkcija za brisanje elementa s liste i osvježavanje prikaza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                Djelovi dioZaIzbrisati = dataGridView1.CurrentRow.DataBoundItem as Djelovi;
                if (dioZaIzbrisati != null)
                {
                    bl.Remove(dioZaIzbrisati);
                    ispisDatagridview();
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// Funkcija za izdavanje računa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntIzdaj_Click(object sender, EventArgs e)
        {
            if (bl.Count == 0) MessageBox.Show("Ne možete napraviti račun bez djelova");
            else
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                Racun noviRacun = new Racun();
                noviRacun.zaposlenik = FrmGlavna.prijavljeniKorisnik.ID;
                noviRacun.datum = DateTime.Now;
                noviRacun.iznos = txtIznos.Text;
                noviRacun.Maloprodaja_veleprodaja = "Veleprodaja";
                int lokacijaId = int.Parse(ConfigurationManager.AppSettings["LokacijaID"]);
                noviRacun.lokacija = lokacijaId;
                Trgovina trgovina = cboxTvrtka.SelectedItem as Trgovina;
                noviRacun.trgovina = trgovina.id;

                db.Racuns.Attach(noviRacun);
                db.Racuns.Add(noviRacun);
                db.SaveChanges();

                Racun dodaniRacun = db.Racuns.OrderByDescending(x => x.id).First();

                var listaZaIzbrisati = bl.Where(x => x.kolicina == 0).ToList();
                listaZaIzbrisati.ForEach(x => bl.Remove(x));

                foreach (Djelovi djelovi in bl)
                {
                    Racun_Has_Djelovi rhd = new Racun_Has_Djelovi();
                    rhd.id_racun = dodaniRacun.id;

                    rhd.id_djelovi = djelovi.id;
                    rhd.kolicina = djelovi.kolicina;
                    dodaniRacun.Racun_Has_Djelovi.Add(rhd);

                    //Djelovi dioOduzmiKolicinu = db.Djelovis.First(x => x.id == djelovi.id);
                    //dioOduzmiKolicinu.kolicina -= djelovi.kolicina;
                    Lokacija_has_djelovi lhd = db.Lokacija_has_djelovi.Where(x => x.id_lokacija == lokacijaId && x.id_djelovi == djelovi.id).SingleOrDefault();
                    if (lhd != null)
                    {
                        lhd.kolicina -= djelovi.kolicina;
                        djelovi.kolicina = 0;
                    }
                }

                db.SaveChanges();
                MessageBox.Show("Uspješno ste izdali novi račun");
            }
        }

        /// <summary>
        /// Otvaranje forme za ažuriranje selektirane tvrtke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPregledTvrtke_Click(object sender, EventArgs e)
        {
            Trgovina t = cboxTvrtka.SelectedItem as Trgovina;
            FrmTvrtkePregled ftp = new FrmTvrtkePregled(t);

            ftp.ShowDialog();
            ispisComboBox();
        }

        /// <summary>
        /// Otvaranje help dokumenta pritiskom na F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="hlpevent"></param>
        private void FrmRacunNoviVeleprodaja_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Prodaja.htm");
        }
    }
}
