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
    /// <summary>
    /// Glavna forma. MDI parent svih ostalih formi. 
    /// </summary>
    public partial class FrmGlavna : Form
    {
        /// <summary>
        /// Spremljen prijavljeni korisnik. Koriste ga druge forme.
        /// </summary>
        public static Zaposlenik prijavljeniKorisnik;        

        /// <summary>
        /// Konstruktor glavne fome.
        /// </summary>
        /// <param name="k"></param>
        public FrmGlavna(Zaposlenik k)
        {
            InitializeComponent();
            prijavljeniKorisnik = k;
            lblKorisnickoIme.Text = prijavljeniKorisnik.korisnickoIme;
        }

        /// <summary>
        /// Otvaranje fome skladišta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skladišteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSkladiste Fskladiste = new FrmSkladiste();
            Fskladiste.MdiParent = this;
            Fskladiste.WindowState = FormWindowState.Maximized;
            Fskladiste.Show();

        }

        /// <summary>
        /// Izlaz iz aplikacije.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Pozivanje forme za evidenciju računa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prodajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRacuni frmRacuni = new FrmRacuni();
            frmRacuni.MdiParent = this;
            frmRacuni.WindowState = FormWindowState.Maximized;
            frmRacuni.Show();
        }

        /// <summary>
        /// Pozivanje forme za rezervacije.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRezervacija formRezervacija = new FrmRezervacija();
            formRezervacija.MdiParent = this;
            formRezervacija.WindowState = FormWindowState.Maximized;
            formRezervacija.Show();
        }


        /// <summary>
        /// Pozivanje forme za upravljenje zaposlenicima 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zaposleniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminCRUDZaposlenik frmZaposleniciCRUD = new FrmAdminCRUDZaposlenik();
            frmZaposleniciCRUD.MdiParent = this;
            frmZaposleniciCRUD.WindowState = FormWindowState.Maximized;
            frmZaposleniciCRUD.Show();
        }

        /// <summary>
        /// Pozivanje forme s izvještajem stanja na skladištu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trgovinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportStanjeNaSkladistu stanjeNaSkladistu = new FrmReportStanjeNaSkladistu();
            stanjeNaSkladistu.MdiParent = this;
            stanjeNaSkladistu.WindowState = FormWindowState.Maximized;
            stanjeNaSkladistu.Show();
        }

        /// <summary>
        /// Pozivanje forme s izvještajem o dijelova prodanih 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void djeloviProdaniUZadnjihXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportDjeloviProdaniUZadnjihX2 djeloviProdaniUZadnjihX = new FrmReportDjeloviProdaniUZadnjihX2();
            djeloviProdaniUZadnjihX.MdiParent = this;
            djeloviProdaniUZadnjihX.WindowState = FormWindowState.Maximized;
            djeloviProdaniUZadnjihX.Show();
        }

        /// <summary>
        /// Pozivanje forme s izvještajem o broju rezervacija
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rezervacijeUZadnjihXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportRezervacijeUZadnjih2 rezervacijeUZadnjihX = new FrmReportRezervacijeUZadnjih2();
            rezervacijeUZadnjihX.MdiParent = this;
            rezervacijeUZadnjihX.WindowState = FormWindowState.Maximized;
            rezervacijeUZadnjihX.Show();
        }

        /// <summary>
        /// Pozivanje help dokumenta pritiskom na F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="hlpevent"></param>
        private void FrmGlavna_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Pocetna.htm");
        }
    }
}
