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
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
            txtLozinka.PasswordChar = '#';
            txtLokacija.Text = ConfigurationManager.AppSettings["LokacijaNaziv"];
            
        }
        private void ProvjeriZaposlenika()
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                var korisnik = (from z in db.Zaposleniks where z.korisnickoIme == txtKorisnicko.Text select z).SingleOrDefault();


                if (korisnik == null)
                {
                    MessageBox.Show("Krivo korisničko ime");
                }
                else
                {

                    var jeAdmin = korisnik.Zaposlenik_has_Tip.Where(x => x.id_tip == 1).SingleOrDefault();
                    

                    if (korisnik.Lokacija.id == int.Parse(ConfigurationManager.AppSettings["LokacijaID"]) || jeAdmin != null)
                    {
                        if (korisnik.lozinka.Trim() == txtLozinka.Text)
                        {
                            MessageBox.Show("Uspješna prijava");
                            FrmGlavna MDI = new FrmGlavna(korisnik);
                            MDI.Show();
                            this.Hide();
                        }
                        else MessageBox.Show("Pokušaj ponovo");
                    }
                    else
                    {
                        MessageBox.Show("Niste prijavljeni na odabrano radno mjesto ili nemate administarsu ulogu");
                    }
                    
                }
            }
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            ProvjeriZaposlenika();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProvjeriZaposlenika();

            this.Close();
        }
        

        private void buttonPrijavaOdustani_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtKorisnicko_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProvjeriZaposlenika();
            }
        }

        private void txtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProvjeriZaposlenika();
            }
        }

        private void buttonPrijavaOdustani_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
