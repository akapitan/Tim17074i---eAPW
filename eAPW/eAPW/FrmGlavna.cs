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
            FrmRacuni frmRacuni = new FrmRacuni();
            frmRacuni.MdiParent = this;
            frmRacuni.WindowState = FormWindowState.Maximized;
            frmRacuni.Show();
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
            FrmReportDjeloviProdaniUZadnjihX2 djeloviProdaniUZadnjihX = new FrmReportDjeloviProdaniUZadnjihX2();
            djeloviProdaniUZadnjihX.MdiParent = this;
            djeloviProdaniUZadnjihX.WindowState = FormWindowState.Maximized;
            djeloviProdaniUZadnjihX.Show();
        }

        private void rezervacijeUZadnjihXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportRezervacijeUZadnjih2 rezervacijeUZadnjihX = new FrmReportRezervacijeUZadnjih2();
            rezervacijeUZadnjihX.MdiParent = this;
            rezervacijeUZadnjihX.WindowState = FormWindowState.Maximized;
            rezervacijeUZadnjihX.Show();
        }

        private void FrmGlavna_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Pocetna.htm");
        }
    }
}
