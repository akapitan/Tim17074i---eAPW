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
using VanjskaKlasa;
using System.Configuration;

namespace eAPW
{
    /// <summary>
    /// Forma za prikaz skladišta
    /// </summary>
    public partial class FrmSkladiste : Form
    {
        /// <summary>
        /// Gledanje da li je korisnik admin
        /// </summary>
        bool jeAdmin;

        /// <summary>
        /// Konstruktor forme
        /// </summary>
        public FrmSkladiste()
        {
            InitializeComponent();
            jeAdmin = FrmGlavna.prijavljeniKorisnik.Zaposlenik_has_Tip.Any(x => x.id_tip == 1);
            ispisDatagrid();
        }

        /// <summary>
        /// Ispis podataka o skladištu
        /// </summary>
        private void ispisDatagrid()
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                var data = (from x in db.Djelovis
                            select new
                            {
                                ID = x.id,
                                Naziv = x.naziv,
                                Kategorija = x.Kategorija1.naziv,
                                ModelVozila = x.Model_vozila.naziv
                            
                            }).ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
                
            }
        }

        /// <summary>
        /// Ispis podataka prema pretraživanju
        /// </summary>
        /// <param name="pretraga"></param>
        private void ispisDatagrid2(string pretraga)
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                var data = (from x in db.Djelovis where x.naziv.Contains(pretraga)
                            select new
                            {
                                ID = x.id,
                                Naziv = x.naziv,
                                Kategorija = x.Kategorija1.naziv,
                                ModelVozila = x.Model_vozila.naziv

                            }).ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }
        }

        /// <summary>
        /// Ispis podataka o stanju na skladištima
        /// </summary>
        /// <param name="provjera"></param>
        private void ispisDatagridNaSkladistu(bool provjera)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int idValue = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());           
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                if (provjera == false)
                {
                    int lokacijaID = Convert.ToInt32(ConfigurationManager.AppSettings["LokacijaID"]);
                    var data = (from x in db.Lokacija_has_djelovi
                                where x.id_djelovi == idValue && x.id_lokacija == lokacijaID
                                select new
                                {
                                    Lokacija = x.Lokacija.naziv,
                                    Kolicina = x.kolicina
                                }).ToList();
                    dgvDjeloviNaSkladistima.DataSource = data;
                }
                else
                {
                    int lokacijaID = Convert.ToInt32(ConfigurationManager.AppSettings["LokacijaID"]);
                    var data = (from x in db.Lokacija_has_djelovi
                                where x.id_djelovi == idValue 
                                select new
                                {
                                    Lokacija = x.Lokacija.naziv,
                                    Kolicina = x.kolicina
                                }).ToList();
                    dgvDjeloviNaSkladistima.DataSource = data;
                }

            }
        }

        /// <summary>
        /// Pokretanje funcije za popunjavanje promjenom selektirane lokacije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ispisDatagridNaSkladistu(jeAdmin);
        }

        /// <summary>
        /// Izlaz iz forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Popunjavanje polja s informacijama o djelovima na skladištu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDjeloviNaSkladistima_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dgvDjeloviNaSkladistima.CurrentCell.RowIndex;
                int idValue = int.Parse(dgvDjeloviNaSkladistima.Rows[rowIndex].Cells[1].Value.ToString());

                txtPromjeniNaSkladistu.Text = idValue.ToString();
            }
            catch (Exception)
            {

                
            }
            
        }


        /// <summary>
        /// Mjenjanje broj dijelova na skladištu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPromjeniNaSkladistu_Click(object sender, EventArgs e)
        {
            
            int idValueDjelovi = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            string idValueLokacija = (dgvDjeloviNaSkladistima.Rows[dgvDjeloviNaSkladistima.CurrentCell.RowIndex].Cells[0].Value.ToString());
            
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                var promjena = (from x in db.Lokacija_has_djelovi where idValueDjelovi == x.id_djelovi && idValueLokacija == x.Lokacija.naziv select x).SingleOrDefault();
                promjena.kolicina = int.Parse(txtPromjeniNaSkladistu.Text);
                db.SaveChanges();
            }
            ispisDatagridNaSkladistu(jeAdmin);
            provjeriRezervacije();
        }

        //public bool posaljiMail(string primateljEmail, string mailBody)
        //{
        //    MailMessage mail = new MailMessage("akapitan@foi.hr", primateljEmail);
        //    SmtpClient client = new SmtpClient();
        //    client.Port = 25;
        //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    client.UseDefaultCredentials = false;
        //    client.Host = "mail.foi.hr";
        //    client.Credentials = new System.Net.NetworkCredential("akapitan", "foi-OranGisi13");
        //    mail.Subject = "Stigli su Vaši naručeni proizvodi";

        //    mail.Body = mailBody;
        //    try
        //    {
        //        client.Send(mail);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;

        //    }

        //}

        /// <summary>
        /// Priprema mail elementa za slanje
        /// </summary>
        /// <param name="primateljEmail"></param>
        /// <param name="lokacijaAdresa"></param>
        /// <param name="listaDjelova"></param>
        public void pripremiMail(string primateljEmail,string lokacijaAdresa, List<Djelovi> listaDjelova)
        {

            string mailBody = "Poštovani \nObavještavamo Vas da su sljedeći proizvodi su ponovo u našoj ponudi : \n\n";
            foreach (Djelovi dio in listaDjelova)
            {
                mailBody += "  - " + dio.naziv + "\n";
            }
            mailBody += " \n\nVaš eAPW - Auto Parts Werehouse\n" +FrmGlavna.prijavljeniKorisnik.ime.Trim() +" " +FrmGlavna.prijavljeniKorisnik.prezime.Trim()+ "\n"+ lokacijaAdresa;

            //if (posaljiMail(primateljEmail, mailBody) == true) MessageBox.Show("Uspješno se poslali mail na adresu " + primateljEmail);
            //else MessageBox.Show("Došlo je do pogreške kod slanja emaila");

            SlanjeMaila klasaSlanjeMaila = new SlanjeMaila();
            if (klasaSlanjeMaila.posaljiMail(primateljEmail, mailBody))
            {
                MessageBox.Show("Uspješno se poslali mail na adresu " + primateljEmail);
            }else
            {
                MessageBox.Show("Došlo je do pogreške kod slanja emaila");
            }
                

                       
        }

        /// <summary>
        /// Provjera retervacije za slanje maila
        /// </summary>
        public void provjeriRezervacije()
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                int lokacijaID = Convert.ToInt32(ConfigurationManager.AppSettings["LokacijaID"]);
                foreach (Rezervacija rez in db.Rezervacijas.Where(x => x.izvrseno == false && x.lokacija == lokacijaID))
                {
                    List<Djelovi> listaDjelovaRezervacija = new List<Djelovi>();

                    foreach (Rezervacija_has_Djelovi rhd in rez.Rezervacija_has_Djelovi)
                    {
                        Djelovi dio = db.Djelovis.Where(x => x.id == rhd.int_djelovi).Single();
                        Lokacija_has_djelovi lhd = db.Lokacija_has_djelovi.Where(y => y.id_djelovi == dio.id && y.id_lokacija == lokacijaID).SingleOrDefault();
                        
                        if (rhd.kolicina <= lhd.kolicina)
                        {
                            listaDjelovaRezervacija.Add(dio);
                        }
                    }
                    if (listaDjelovaRezervacija.Count > 0 && listaDjelovaRezervacija.Count == rez.Rezervacija_has_Djelovi.Count)
                    {
                        string lokacijaAdresa = db.Lokacijas.Where(x => x.id == lokacijaID).Select(x => x.Adresa).SingleOrDefault();
                        
                        pripremiMail(rez.kupacEmail,lokacijaAdresa, listaDjelovaRezervacija);
                        Rezervacija rezervacija = db.Rezervacijas.Single(x => x.id == rez.id);
                        rezervacija.izvrseno = true;
                        
                    }
                }
                db.SaveChanges();
            }
        }
    }


}
