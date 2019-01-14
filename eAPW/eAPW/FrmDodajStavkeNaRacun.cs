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
    public partial class FrmDodajStavkeNaRacun : Form
    {
        public FrmDodajStavkeNaRacun()
        {
            InitializeComponent();
        }

        private void ispisSvihProizvoda()
        {

            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                List<Djelovi> listDjelovi = new List<Djelovi>();
                dgvPopisStavki.DataSource = null;

                foreach (Djelovi z in db.Djelovis.Where(x => x.Lokacija_has_djelovi == db.Lokacija_has_djelovi.Where(y => y.id_lokacija == 1)))
                {
                    //z.kate = z.Kategorija1.naziv;
                    listDjelovi.Add(z);
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
        private void ispisSvihProizvoda(string textPretraga)
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                List<Djelovi> listDjelovi = new List<Djelovi>();

                foreach (Djelovi z in db.Djelovis)
                {

                    if (z.naziv.ToLower().Contains(textPretraga) && z != null)
                    {
                        //z.kate = z.Kategorija1.naziv;
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
        Djelovi selektirani;

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (selektirani != null)
            {
                if (selektirani.kolicina > 0)
                {
                    if (FrmRacunNoviMaloprodaja.bl.Any(x => x.id == selektirani.id && x.naziv == selektirani.naziv))
                    {
                        MessageBox.Show("Proizvod je već dodan na račun");
                    }
                    else
                    {
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
            try
            {
                selektirani = dgvPopisStavki.CurrentRow.DataBoundItem as Djelovi;
                if (selektirani != null)
                {
                    txtSelektiraniNaziv.Text = selektirani.naziv;
                    numericUpDown1.Maximum = selektirani.kolicina;
                    numericUpDown1.Value = selektirani.kolicina;
                }
            }
            catch
            {

            }
        }
    }
}
