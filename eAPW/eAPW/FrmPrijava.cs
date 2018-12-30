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
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                var lokacije = (from z in db.Lokacijas select z).ToList();
                cBoxLokacija.DataSource = lokacije;
            }

        }
        private void ProvjeriZaposlenika()
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                var korIme = (from z in db.Zaposleniks where z.korisnickoIme == txtKorisnicko.Text select z).SingleOrDefault();


                if (korIme == null)
                {
                    MessageBox.Show("Krivo korisničko ime");
                }
                else
                {
                    Lokacija l = cBoxLokacija.SelectedItem as Lokacija;
                    if(korIme.radnoMjesto == l.id)
                    {
                        if (korIme.lozinka.Trim() == txtLozinka.Text)
                        {
                            MessageBox.Show("Uspješna prijava");
                            FrmGlavna MDI = new FrmGlavna(korIme);
                            MDI.Show();
                            this.Hide();
                        }
                        else MessageBox.Show("Pokušaj ponovo");
                    }
                    else
                    {
                        MessageBox.Show("Niste prijavljeni na odabrano radno mjesto");
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
    }
}
