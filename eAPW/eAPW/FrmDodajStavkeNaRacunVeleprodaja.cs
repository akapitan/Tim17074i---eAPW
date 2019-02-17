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
    /// Forma za dodavanje stavaka na veleprodajni račun
    /// </summary>
    public partial class FrmDodajStavkeNaRacunVeleprodaja : Form
    {
        /// <summary>
        /// Selektirani dio od korisnika. Koriste ga više metoda.
        /// </summary>
        private Djelovi selektirani;

        /// <summary>
        /// Lista djelova na računu. Koriste ga više metoda.
        /// </summary>
        private List<Djelovi> listDjelovi = new List<Djelovi>();

        /// <summary>
        /// Konstruktor forme FrmDodajStavkeNaRacunVeleprodaja
        /// </summary>
        public FrmDodajStavkeNaRacunVeleprodaja()
        {
            InitializeComponent();
            ispisSvihProizvoda();
        }
        
        /// <summary>
        /// Funkcija za ispis proizvoda na lokaciji
        /// </summary>
        private void ispisSvihProizvoda()
        {
            listDjelovi = new List<Djelovi>();
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                
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
        /// Izlaz iz forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Selektirana pretraga i ispis proizvoda.
        /// </summary>
        /// <param name="textPretraga"></param>
        private void ispisSvihProizvoda(string textPretraga)
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                int trenutnaLokacijaID = int.Parse(ConfigurationManager.AppSettings["LokacijaID"].ToString());
                List<Djelovi> listDjelovi = new List<Djelovi>();
                listDjelovi = (from x in db.Djelovis
                               join y in db.Lokacija_has_djelovi on x.id equals y.id_djelovi
                               where y.id_lokacija == trenutnaLokacijaID && x.naziv.Contains(textPretraga)
                               select x).ToList();

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
        /// Pozivanje funkcje za ispis dijelova po pretragi okidanjem na promjenu u txtPretraga.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            ispisSvihProizvoda(txtPretraga.Text);
        }

        
        /// <summary>
        /// Okidanje promjenom selekcije. Mijenja informaciju u detaljnom pregledu. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPopisStavki_SelectionChanged(object sender, EventArgs e)
        {
            int trenutnaLokacijaID = int.Parse(ConfigurationManager.AppSettings["LokacijaID"].ToString());
            
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                try
                {
                    selektirani = dgvPopisStavki.CurrentRow.DataBoundItem as Djelovi;
                    if (selektirani != null)
                    {
                        var kolicinaNaLokaciji = db.Lokacija_has_djelovi.Where(x => x.id_djelovi == selektirani.id && x.id_lokacija == trenutnaLokacijaID).SingleOrDefault();

                        txtSelektiraniNaziv.Text = selektirani.naziv;
                        numericUpDown1.Maximum = kolicinaNaLokaciji.kolicina;
                        numericUpDown1.Value = kolicinaNaLokaciji.kolicina;
                    }
                }
                catch
                {

                }
            }
            
        }

        /// <summary>
        /// Dodavanje stavaka na veleprodajni racun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (selektirani != null)
            {
                if (numericUpDown1.Value > 0)
                {
                    if (FrmRacunNoviVeleprodaja.bl.Any(x => x.id == selektirani.id && x.naziv == selektirani.naziv))
                    {
                        MessageBox.Show("Proizvod je već dodan na račun");
                    }
                    else
                    {
                        selektirani.kolicina = Convert.ToInt32(numericUpDown1.Value);
                        FrmRacunNoviVeleprodaja.bl.Add(selektirani);
                    }
                }

                else
                {
                    MessageBox.Show("Tog proizvoda nema na skladištu");
                }

            }
        }

        /// <summary>
        /// Pozivanje help dokumenta pritiskom na F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="hlpevent"></param>
        private void FrmDodajStavkeNaRacunVeleprodaja_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Prodaja.htm");
        }
    }
}
