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
            if (IsValid(txtKupacEmail.Text) && txtKupacIme.Text != "" && txtKupacPrezime.Text != "" && listaKupacRezervacija.Count != 0)
                using (var db = new ProgramskoInzenjerstvoDBEntities())
                {
                    Rezervacija rez = new Rezervacija();
                    rez.kupacIme = txtKupacIme.Text;
                    rez.kupacPrezime = txtKupacPrezime.Text;
                    rez.kupacEmail = txtKupacEmail.Text;
                    rez.izvrseno = false;
                    rez.napravioNarudzbu = FrmGlavna.prijavljeniKorisnik.ID;
                    rez.lokacija = Convert.ToInt32(ConfigurationManager.AppSettings["LokacijaID"]);


                    db.Rezervacijas.Add(rez);

                    db.SaveChanges();

                    rez = null;
                    rez = db.Rezervacijas.OrderByDescending(x => x.id).First();

                    foreach (Djelovi djelovi in listaKupacRezervacija)
                    {
                        Rezervacija_has_Djelovi rhd = new Rezervacija_has_Djelovi();
                        rhd.id_rezervacija = rez.id;
                        rhd.int_djelovi = djelovi.id;
                        rhd.kolicina = 0;
                        
                        db.Rezervacija_has_Djelovi.Add(rhd);

                    }
                    db.SaveChanges();
                    MessageBox.Show("Uspjesno se dodali novu rezervaciju");
                }
            else
            {
                MessageBox.Show("Molimo popuniti sve potrebne podatke");
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
    }
}
