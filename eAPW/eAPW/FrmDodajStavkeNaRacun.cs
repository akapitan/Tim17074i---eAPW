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
    public partial class FrmDodajStavkeNaRacun : Form
    {
        private Djelovi selektirani;
        public FrmDodajStavkeNaRacun()
        {
            InitializeComponent();
            ispisSvihProizvoda();
        }

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
            }

        }
        private void ispisSvihProizvoda(string textPretraga)
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                List<Djelovi> listDjelovi = new List<Djelovi>();

                foreach (Djelovi z in db.Djelovis)
                {

                    if (z.naziv.ToLower().Contains(textPretraga) && z != null)
                    {
                        
                        listDjelovi.Add(z);
                    }

                }
                dgvPopisStavki.DataSource = null;
                dgvPopisStavki.DataSource = new BindingSource(listDjelovi, null);

                dgvPopisStavki.Columns["Kategorija1"].Visible = false;
                dgvPopisStavki.Columns["Model_vozila"].Visible = false;
                dgvPopisStavki.Columns["Proizvodac"].Visible = false;
                dgvPopisStavki.Columns["Narudzba_has_Djelovi"].Visible = false;
                dgvPopisStavki.Columns["Racun_Has_Djelovi"].Visible = false;
                dgvPopisStavki.Columns["Rezervacija_has_Djelovi"].Visible = false;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            ispisSvihProizvoda(txtPretraga.Text);
        }
        

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

        private void FrmDodajStavkeNaRacun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
