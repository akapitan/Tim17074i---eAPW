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
        private static Zaposlenik prijavljeniKorisnik;

        public FrmGlavna(Zaposlenik k)
        {
            InitializeComponent();
            prijavljeniKorisnik = k;
            lblKorisnickoIme.Text = prijavljeniKorisnik.korisnickoIme;
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
    }
}
