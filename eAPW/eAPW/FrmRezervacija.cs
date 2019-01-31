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
    public partial class FrmRezervacija : Form
    {
        public FrmRezervacija()
        {
            InitializeComponent();
            ispisDatagrid();
        }

        private void ispisDatagrid()
        {
            int lokacijaID = Convert.ToInt32( ConfigurationManager.AppSettings["LokacijaID"]);
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                List<Rezervacija> listaRezervacija = new List<Rezervacija>();
                foreach (Rezervacija r in db.Rezervacijas.Where(x => x.Lokacija1.id == lokacijaID)) listaRezervacija.Add(r);
                BindingSource bs = new BindingSource(listaRezervacija, null);
                dataGridView1.DataSource = bs;

                dataGridView1.Columns["napravioNarudzbu"].Visible = false;
                dataGridView1.Columns["Lokacija1"].Visible = false;
                dataGridView1.Columns["lokacija"].Visible = false;
                dataGridView1.Columns["Rezervacija_has_Djelovi"].Visible = false;
                dataGridView1.Columns["Zaposlenik"].Visible = false;
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            Rezervacija r = dataGridView1.CurrentRow.DataBoundItem as Rezervacija;
            if (r != null)
            {
                FrmRezervacijaPrikaz frp = new FrmRezervacijaPrikaz(r.id);
                frp.ShowDialog();
            }
        }

        private void bntNovi_Click(object sender, EventArgs e)
        {
            FrmRezervacijaNovi frn = new FrmRezervacijaNovi();
            frn.ShowDialog();
            ispisDatagrid();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                Rezervacija rez = dataGridView1.CurrentRow.DataBoundItem as Rezervacija;
                if (rez != null)
                {
                    if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new ProgramskoInzenjerstvoDBEntities())
                        {
                            db.Rezervacijas.Attach(rez);
                            db.Rezervacijas.Remove(rez);
                            foreach (var izbrisatiProvjera in db.Rezervacija_has_Djelovi)
                            {
                                if (izbrisatiProvjera.id_rezervacija == rez.id)
                                {
                                    db.Rezervacija_has_Djelovi.Attach(izbrisatiProvjera);
                                    db.Rezervacija_has_Djelovi.Remove(izbrisatiProvjera);
                                }
                            }

                            db.SaveChanges();
                            ispisDatagrid();
                        }
                    }
                }
            }
            catch (Exception)
            {


            }
        }
    }
}
