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
    /// Klasa forme za dodavanje stavaka na maloprodajni račun
    /// </summary>
    public partial class FrmDodajStavkeNaRacun : Form
    {
        /// <summary>
        /// <typeparamref name="selektirani"/> Služi za obradu selektiranog dijela nad više metoda
        /// </summary>
        private Djelovi selektirani;

        /// <summary>
        /// Konstruktor forme FrmDodajStavkeNaRacun
        /// </summary>
        public FrmDodajStavkeNaRacun()
        {
            InitializeComponent();
            ispisSvihProizvoda();
        }

        /// <summary>
        /// Funkcija za ispis stavaka s baze na datagridview. Dodaje stavke samo s lokacije gdje je program instaliran.
        /// </summary>
        private void ispisSvihProizvoda()
        {

            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                List<Djelovi> listDjelovi = new List<Djelovi>();
                dgvPopisStavki.DataSource = null;

                int trenutnaLokacijaID = int.Parse(ConfigurationManager.AppSettings["LokacijaID"].ToString());
                listDjelovi = (from x in db.Djelovis join y in db.Lokacija_has_djelovi on x.id equals y.id_djelovi where y.id_lokacija == trenutnaLokacijaID select x).ToList();
                

                dgvPopisStavki.DataSource = null;
                dgvPopisStavki.DataSource = new BindingSource(listDjelovi, null);

                dgvPopisStavki.Columns["Kategorija1"].Visible = false;
                dgvPopisStavki.Columns["Model_vozila"].Visible = false;
                dgvPopisStavki.Columns["Proizvodac"].Visible = false;
                dgvPopisStavki.Columns["Narudzba_has_Djelovi"].Visible = false;
                dgvPopisStavki.Columns["Racun_Has_Djelovi"].Visible = false;
                dgvPopisStavki.Columns["Rezervacija_has_Djelovi"].Visible = false;
                dgvPopisStavki.Columns["Lokacija_has_djelovi"].Visible = false;
                
            }

        }

        /// <summary>
        /// Funkcija za selektirani ispis sa baze na datagridview.
        /// </summary>
        /// <param name="pretraga">string, služi kao parametar za pretragu</param>
        private void ispisSvihProizvoda(string textPretraga)
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                int trenutnaLokacijaID = int.Parse(ConfigurationManager.AppSettings["LokacijaID"].ToString());
                List<Djelovi> listDjelovi = new List<Djelovi>();
                listDjelovi = (from x in db.Djelovis join y in db.Lokacija_has_djelovi on x.id equals y.id_djelovi
                               where y.id_lokacija == trenutnaLokacijaID && x.naziv.Contains(textPretraga) select x).ToList();
               
                dgvPopisStavki.DataSource = null;
                dgvPopisStavki.DataSource = new BindingSource(listDjelovi, null);

                dgvPopisStavki.Columns["Kategorija1"].Visible = false;
                dgvPopisStavki.Columns["Model_vozila"].Visible = false;
                dgvPopisStavki.Columns["Proizvodac"].Visible = false;
                dgvPopisStavki.Columns["Narudzba_has_Djelovi"].Visible = false;
                dgvPopisStavki.Columns["Racun_Has_Djelovi"].Visible = false;
                dgvPopisStavki.Columns["Rezervacija_has_Djelovi"].Visible = false;
                dgvPopisStavki.Columns["Lokacija_has_djelovi"].Visible = false;
            }
        }

        /// <summary>
        /// Izlaz iz forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Pozivanje funkcije za pretragu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            ispisSvihProizvoda(txtPretraga.Text);
        }

        /// <summary>
        /// Dodavanje stavaka na račun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (selektirani != null)
            {
                if (numericUpDown1.Value  > 0)
                {
                    if (FrmRacunNoviMaloprodaja.bl.Any(x => x.id == selektirani.id && x.naziv == selektirani.naziv))
                    {
                        MessageBox.Show("Proizvod je već dodan na račun");
                    }
                    else
                    {
                        selektirani.kolicina = Convert.ToInt32(numericUpDown1.Value);
                        FrmRacunNoviMaloprodaja.bl.Add(selektirani);
                    }
                }

                else
                {
                    MessageBox.Show("Tog proizvoda nema na skladištu");
                }

            }
        }

        /// <summary>
        /// Event handler za izmjenu posataka na datagridview za detalje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPopisStavki_SelectionChanged(object sender, EventArgs e)
        {
            int trenutnaLokacijaID = int.Parse(ConfigurationManager.AppSettings["LokacijaID"].ToString());
            try
            {
                selektirani = dgvPopisStavki.CurrentRow.DataBoundItem as Djelovi;
                
                if (selektirani != null)
                {
                    using (var db = new ProgramskoInzenjerstvoDBEntities())
                    {
                        var kolicinaNaLokaciji = db.Lokacija_has_djelovi.Where(x => x.id_djelovi == selektirani.id && x.id_lokacija == trenutnaLokacijaID).SingleOrDefault();
                        txtSelektiraniNaziv.Text = selektirani.naziv;
                        numericUpDown1.Maximum = kolicinaNaLokaciji.kolicina;
                        numericUpDown1.Value = kolicinaNaLokaciji.kolicina;
                        
                    }
                    
                }
                else
                {
                   
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }

        /// <summary>
        /// Eventhandler za izlaz iz fome klikom na Esc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDodajStavkeNaRacun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Pozivanje help dokumenta pritiskom na F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="hlpevent"></param>
        private void FrmDodajStavkeNaRacun_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Prodaja.htm");
        }
    }
}
