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
    public partial class FrmGlavna : Form
    {
        public static Zaposlenik prijavljeniKorisnik;
        public static Lokacija prijavljenaLokacija;

        public FrmGlavna(Zaposlenik k, Lokacija l)
        {
            InitializeComponent();
            prijavljeniKorisnik = k;
            lblKorisnickoIme.Text = prijavljeniKorisnik.korisnickoIme;
            prijavljenaLokacija = l;
        }

        private void skladišteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSkladiste Fskladiste = new FrmSkladiste();
            Fskladiste.MdiParent = this;
            Fskladiste.WindowState = FormWindowState.Maximized;
            Fskladiste.Show();

        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void prodajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRacuni Fskladiste = new FrmRacuni();
            Fskladiste.MdiParent = this;
            Fskladiste.WindowState = FormWindowState.Maximized;
            Fskladiste.Show();
        }
    }
}
