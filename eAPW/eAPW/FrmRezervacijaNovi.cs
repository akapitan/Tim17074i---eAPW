using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;

namespace eAPW
{
    public partial class FrmRezervacijaNovi : Form
    {
        BindingList<Djelovi> listaDjelova = new BindingList<Djelovi>();
        BindingList<Djelovi> listaKupacRezervacija = new BindingList<Djelovi>();

        public FrmRezervacijaNovi()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRezervacijaNovi_Load(object sender, EventArgs e)
        {
            int lokacijaID = Convert.ToInt32(ConfigurationManager.AppSettings["LokacijaID"]);
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                foreach (Djelovi d in db.Djelovis.Where(x => x.Lokacija_has_djelovi.Any(y => y.id_lokacija == lokacijaID && y.kolicina == 0)))
                {
                    listaDjelova.Add(d);
                    

                }
                ispisDataGrid();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Djelovi d = dgvPopisProizvodaKojegNemaNaSkladistu.CurrentRow.DataBoundItem as Djelovi;
                if (d != null)
                {
                    if (!listaKupacRezervacija.Contains(d))
                    {
                        listaKupacRezervacija.Add(d);
                    }
                    else
                    {
                        MessageBox.Show("Proizvod je već dodan na rezervaciju");
                    }


                }
                ispisDataGrid();
            }
            catch
            {

            }
        }
        private void ispisDataGrid()
        {
            dgvPopisProizvodaKojegNemaNaSkladistu.DataSource = null;
            dgvKupacRezervacija.DataSource = null;

            dgvPopisProizvodaKojegNemaNaSkladistu.DataSource = listaDjelova;
            dgvKupacRezervacija.DataSource = listaKupacRezervacija;

            dgvPopisProizvodaKojegNemaNaSkladistu.Columns["kolicina"].Visible = false;
            dgvPopisProizvodaKojegNemaNaSkladistu.Columns["Kategorija1"].Visible = false;
            dgvPopisProizvodaKojegNemaNaSkladistu.Columns["Model_vozila"].Visible = false;
            dgvPopisProizvodaKojegNemaNaSkladistu.Columns["Proizvodac"].Visible = false;
            dgvPopisProizvodaKojegNemaNaSkladistu.Columns["Lokacija_has_djelovi"].Visible = false;
            dgvPopisProizvodaKojegNemaNaSkladistu.Columns["Narudzba_has_Djelovi"].Visible = false;
            dgvPopisProizvodaKojegNemaNaSkladistu.Columns["Racun_Has_Djelovi"].Visible = false;
            dgvPopisProizvodaKojegNemaNaSkladistu.Columns["Rezervacija_has_Djelovi"].Visible = false;

            dgvKupacRezervacija.Columns["id"].Visible = false;
            dgvKupacRezervacija.Columns["Kategorija1"].Visible = false;
            dgvKupacRezervacija.Columns["Model_vozila"].Visible = false;
            dgvKupacRezervacija.Columns["Proizvodac"].Visible = false;
            dgvKupacRezervacija.Columns["Lokacija_has_djelovi"].Visible = false;
            dgvKupacRezervacija.Columns["Narudzba_has_Djelovi"].Visible = false;
            dgvKupacRezervacija.Columns["Racun_Has_Djelovi"].Visible = false;
            dgvKupacRezervacija.Columns["Rezervacija_has_Djelovi"].Visible = false;
            dgvKupacRezervacija.Columns["proizodac"].Visible = false;
            dgvKupacRezervacija.Columns["modelVozila"].Visible = false;
            dgvKupacRezervacija.Columns["kategorija"].Visible = false;
            dgvKupacRezervacija.Columns["maloprodajnaCijena"].Visible = false;
            dgvKupacRezervacija.Columns["veleprodajnaCijena"].Visible = false;
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                Djelovi d = dgvKupacRezervacija.CurrentRow.DataBoundItem as Djelovi;
                if (d != null)
                {
                    listaKupacRezervacija.Remove(d);
                }
            }
            catch (Exception)
            {


            }
        }

        private void bntIzdaj_Click(object sender, EventArgs e)
        {
            bool jeLiSvimDjelovimaDodanaKolicina = listaKupacRezervacija.Any(x => x.kolicina == 0);
            if (jeLiSvimDjelovimaDodanaKolicina) MessageBox.Show("Molimo unesite količine proizvodima za rezervaciju");

            else if (IsValid(txtKupacEmail.Text) && txtKupacIme.Text != "" && txtKupacPrezime.Text != "" && listaKupacRezervacija.Count != 0)
                using (var db = new ProgramskoInzenjerstvoDBEntities())
                {
                    Rezervacija rez = new Rezervacija();
                    rez.kupacIme = txtKupacIme.Text;
                    rez.kupacPrezime = txtKupacPrezime.Text;
                    rez.kupacEmail = txtKupacEmail.Text;
                    rez.izvrseno = false;
                    rez.napravioNarudzbu = FrmGlavna.prijavljeniKorisnik.ID;
                    rez.lokacija = Convert.ToInt32(ConfigurationManager.AppSettings["LokacijaID"]);
                    rez.datumIzdavanja = DateTime.UtcNow;

                    db.Rezervacijas.Add(rez);

                    db.SaveChanges();

                    rez = null;
                    rez = db.Rezervacijas.OrderByDescending(x => x.id).First();

                    foreach (Djelovi dio in listaKupacRezervacija)
                    {
                        Rezervacija_has_Djelovi rhd = new Rezervacija_has_Djelovi();
                        rhd.id_rezervacija = rez.id;
                        rhd.int_djelovi = dio.id;
                        rhd.kolicina = dio.kolicina;
                        
                        db.Rezervacija_has_Djelovi.Add(rhd);

                    }
                    db.SaveChanges();
                    MessageBox.Show("Uspjesno se dodali novu rezervaciju");
                    this.Close();
                }
            else if (IsValid(txtKupacEmail.Text) == false)
            {
                MessageBox.Show("Molimo upišite pravilan mail");
            }
            else if(txtKupacIme.Text == "" || txtKupacPrezime.Text == "")
            {
                MessageBox.Show("Molimo upišite podatke");
            }
        }
        private bool IsValid(string emailaddress)
        {
            if (emailaddress != "")
                try
                {
                    MailAddress m = new MailAddress(emailaddress);

                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Djelovi selecktirani = dgvKupacRezervacija.CurrentRow.DataBoundItem as Djelovi;
                selecktirani.kolicina = Convert.ToInt16(txtKolicina.Text);
                ispisDataGrid();
                
            }
            catch 
            {

                
            }
            
        }

        private void dgvKupacRezervacija_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Djelovi selektirani = dgvKupacRezervacija.CurrentRow.DataBoundItem as Djelovi;
                txtSelektiraniDio.Text = selektirani.naziv;
                txtKolicina.Text = selektirani.kolicina.ToString();
            }
            catch 
            {
            }
        }

        private void FrmRezervacijaNovi_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "RezervacijaDjelova.htm");
        }
    }
}
