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
    /// Forma za pregled tvrtki
    /// </summary>
    public partial class FrmTvrtkePregled : Form
    {
        /// <summary>
        /// Prenesena tvrtka
        /// </summary>
        private Trgovina trgovina;

        /// <summary>
        /// Konstruktor forme za unos nove tvrtke
        /// </summary>
        public FrmTvrtkePregled()
        {
            InitializeComponent();
            btnSpremi.Enabled = false;
        }

        /// <summary>
        /// Konstruktor forme za ažuriranje podataka o tvrtki
        /// </summary>
        /// <param name="prenesenaTrgovina"></param>
        public FrmTvrtkePregled(Trgovina prenesenaTrgovina)
        {
            InitializeComponent();
            trgovina = prenesenaTrgovina;

            txtNaziv.Text = trgovina.naziv;
            txtAdresa.Text = trgovina.adresa;
            txtOIB.Text = trgovina.oib;

            btnDodaj.Enabled = false;
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
        /// Dodavanje nove tvrtke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                Trgovina t = new Trgovina();

                t.naziv = txtNaziv.Text;
                t.adresa = txtAdresa.Text;
                t.oib = txtAdresa.Text;
                if (db.Trgovinas.Any(x => x.oib == t.oib))
                {
                    MessageBox.Show("Tvrtka s tim OIB-om već postoji");
                }
                else
                {
                   
                    db.Trgovinas.Attach(t);
                    db.Trgovinas.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste dodali tvrtku");
                    Close();
                }

            }
        }

        /// <summary>
        /// Ažuriranje tvrtke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (trgovina != null)
            {
                try
                {
                    using (var db = new ProgramskoInzenjerstvoDBEntities())
                    {
                        Trgovina selektiranaTrgovina = (from x in db.Trgovinas where x.oib == trgovina.oib select x).SingleOrDefault();
                        selektiranaTrgovina.oib = txtOIB.Text.Trim();
                        selektiranaTrgovina.adresa = txtAdresa.Text;
                        selektiranaTrgovina.naziv = txtNaziv.Text;
                        
                        db.SaveChanges();
                        MessageBox.Show("Uspješno izmjenjeni podaci trgovine.");
                    }
                }
                catch 
                {
                    MessageBox.Show("Desila se greško kod ažuriranja podataka.");
                    
                }
                
            }
        }

        /// <summary>
        /// Pozivanje help dokumenta pritiskom na F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="hlpevent"></param>
        private void FrmTvrtkePregled_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Prodaja.htm");
        }
    }
}
