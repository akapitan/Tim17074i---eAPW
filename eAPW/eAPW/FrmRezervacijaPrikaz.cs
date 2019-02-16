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
    /// klasa forme prikaza rezervacije
    /// </summary>
    public partial class FrmRezervacijaPrikaz : Form
    {
        /// <summary>
        /// Spremljeni preneseni id rezervacije za prikazati
        /// </summary>
        private int rezervacijaID;

        /// <summary>
        /// Konstruktor forme
        /// </summary>
        /// <param name="rezId"></param>
        public FrmRezervacijaPrikaz(int rezId)
        {
            InitializeComponent();
            rezervacijaID = rezId;
        }

        /// <summary>
        /// Izlaz iz forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Popunjavanje podacima poslije inicijalizacije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRezervacijaPrikaz_Load(object sender, EventArgs e)
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                Rezervacija r = (from x in db.Rezervacijas where x.id == rezervacijaID select x).SingleOrDefault();
                txtEmail.Text = r.kupacEmail;
                txtIme.Text = r.kupacIme;
                txtPrezime.Text = r.kupacPrezime;

                var model = (from x in db.Djelovis
                             join y in db.Rezervacija_has_Djelovi on x.id equals y.int_djelovi
                             where y.id_rezervacija == rezervacijaID
                             select new
                             {
                                 Naziv = x.naziv,
                                 cijena = x.maloprodajnaCijena,
                                 kolicina = y.kolicina

                             }).ToList();
                dataGridView1.DataSource = new BindingSource(model, null);
            }
        }

        /// <summary>
        /// Otvaranje help dokumenta pritiskom na F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="hlpevent"></param>
        private void FrmRezervacijaPrikaz_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "RezervacijaDjelova.htm");
        }
    }
}
