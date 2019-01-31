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

        private void prodajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRacuni Fskladiste = new FrmRacuni();
            Fskladiste.MdiParent = this;
            Fskladiste.WindowState = FormWindowState.Maximized;
            Fskladiste.Show();
        }

        private void rezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRezervacija formRezervacija = new FrmRezervacija();
            formRezervacija.MdiParent = this;
            formRezervacija.WindowState = FormWindowState.Maximized;
            formRezervacija.Show();
        }

        private void zaposleniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminCRUDZaposlenik frmZaposleniciCRUD = new FrmAdminCRUDZaposlenik();
            frmZaposleniciCRUD.MdiParent = this;
            frmZaposleniciCRUD.WindowState = FormWindowState.Maximized;
            frmZaposleniciCRUD.Show();
        }

        private void trgovinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportStanjeNaSkladistu stanjeNaSkladistu = new FrmReportStanjeNaSkladistu();
            stanjeNaSkladistu.MdiParent = this;
            stanjeNaSkladistu.WindowState = FormWindowState.Maximized;
            stanjeNaSkladistu.Show();
        }

        private void djeloviProdaniUZadnjihXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportDjeloviProdaniUZadnjihX djeloviProdaniUZadnjihX = new FrmReportDjeloviProdaniUZadnjihX();
            djeloviProdaniUZadnjihX.MdiParent = this;
            djeloviProdaniUZadnjihX.WindowState = FormWindowState.Maximized;
            djeloviProdaniUZadnjihX.Show();
        }

        private void rezervacijeUZadnjihXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportRezervacijeUZadnjihX rezervacijeUZadnjihX = new FrmReportRezervacijeUZadnjihX();
            rezervacijeUZadnjihX.MdiParent = this;
            rezervacijeUZadnjihX.WindowState = FormWindowState.Maximized;
            rezervacijeUZadnjihX.Show();
        }
    }
}
