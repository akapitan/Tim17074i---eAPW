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
    public partial class FrmTvrtkePregled : Form
    {
        Trgovina trgovina;

        public FrmTvrtkePregled()
        {
            InitializeComponent();
        }

        public FrmTvrtkePregled(Trgovina prenesenaTrgovina)
        {
            InitializeComponent();
            trgovina = prenesenaTrgovina;

            txtNaziv.Text = trgovina.naziv;
            txtAdresa.Text = trgovina.adresa;
            txtOIB.Text = trgovina.oib;
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (trgovina != null)
            {
                using (var db = new ProgramskoInzenjerstvoDBEntities())
                {
                    Trgovina selektiranaTrgovina = (from x in db.Trgovinas where x.oib == trgovina.oib select x).SingleOrDefault();
                    selektiranaTrgovina.oib = txtOIB.Text;
                    selektiranaTrgovina.adresa = txtAdresa.Text;
                    selektiranaTrgovina.naziv = txtNaziv.Text;

                    db.SaveChanges();
                }
            }
        }
    }
}
