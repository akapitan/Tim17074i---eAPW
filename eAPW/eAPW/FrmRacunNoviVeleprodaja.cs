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
    public partial class FrmRacunNoviVeleprodaja : Form
    {
        public static BindingList<Djelovi> bl = new BindingList<Djelovi>(); 

        public FrmRacunNoviVeleprodaja()
        {
            InitializeComponent();
            bl.Clear();
            txtZaposlenik.Text = FrmGlavna.prijavljeniKorisnik.korisnickoIme;
            this.dtpDatum.Enabled = false;
            ispisComboBox();
        }

        private void btnDodajNovuTvrtku_Click(object sender, EventArgs e)
        {
            new FrmTvrtkePregled().ShowDialog();
            ispisComboBox();
        }

        private void ispisComboBox()
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                var tvrtke = db.Trgovinas.ToList();
                BindingSource bs = new BindingSource(tvrtke, null);
                cboxTvrtka.DataSource = bs;
            }
        }
        private void ispisDatagridview()
        {

            dataGridView1.DataSource = bl;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Visible = false;
                dataGridView1.Columns[i].ReadOnly = true;
            }
            dataGridView1.Columns["Id"].Visible = true;
            dataGridView1.Columns["Naziv"].Visible = true;
            dataGridView1.Columns["veleprodajnaCijena"].Visible = true;
            dataGridView1.Columns["kolicina"].Visible = true;

            //DataGridViewColumn col = new DataGridViewTextBoxColumn();
            //col.DataPropertyName = "Kolicina";
            //col.HeaderText = "Kolicina";
            //col.Name = "foo";
            //dataGridView1.Columns.Add(col);

            if (bl.Count == 0) txtIznos.Text = "0 kn";
            else
            {
                int iznos = 0;
                foreach (Djelovi dio in bl)
                {
                    iznos += (dio.kolicina * dio.veleprodajnaCijena);
                }
                txtIznos.Text = iznos.ToString() + " kn";
            }


        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajStavkeNaRacunVeleprodaja fdsnrv = new FrmDodajStavkeNaRacunVeleprodaja();
            fdsnrv.ShowDialog();
            ispisDatagridview();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "foo")
            {

                using (var db = new ProgramskoInzenjerstvoDBEntities())
                {
                    int cijenaUkupno = 0;
                    if (bl.Count == 0) txtIznos.Text = "0 kn";
                    for (int i = 0; i < bl.Count; i++)
                    {
                        Djelovi selektirani = dataGridView1.CurrentRow.DataBoundItem as Djelovi;
                        int maxKolicina = (from x in db.Djelovis where x.id == selektirani.id select x.kolicina).SingleOrDefault();
                        int korisnickiUnosKolicine = Convert.ToInt32(dataGridView1["foo", e.RowIndex].Value);
                        //MessageBox.Show(korisnickiUnosKolicine.ToString() + " = " + maxKolicina.ToString());
                        if (korisnickiUnosKolicine > maxKolicina || korisnickiUnosKolicine < 0)
                        {
                            dataGridView1["foo", e.RowIndex].Value = 0;
                            txtIznos.Text = "N/A";
                            MessageBox.Show("Na skladištu ima " + maxKolicina.ToString() + ". Molimo uskladite to s vašim unosom.");
                            break;
                        }
                        else
                        {
                            int cijena = bl[i].veleprodajnaCijena;
                            cijenaUkupno += (bl[i].kolicina * cijena);
                            txtIznos.Text = cijenaUkupno.ToString() + " kn";
                        }

                    }

                }
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                Djelovi dioZaIzbrisati = dataGridView1.CurrentRow.DataBoundItem as Djelovi;
                if (dioZaIzbrisati != null)
                {
                    bl.Remove(dioZaIzbrisati);
                    ispisDatagridview();
                }
            }
            catch
            {

            }
        }

        private void bntIzdaj_Click(object sender, EventArgs e)
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                Racun noviRacun = new Racun();
                noviRacun.zaposlenik = FrmGlavna.prijavljeniKorisnik.ID;
                noviRacun.datum = DateTime.Now;
                noviRacun.iznos = txtIznos.Text;
                noviRacun.Maloprodaja_veleprodaja = "Veleprodaja";
                int lokacijaId = int.Parse(ConfigurationManager.AppSettings["LokacijaID"]);
                noviRacun.lokacija = lokacijaId;
                Trgovina trgovina = cboxTvrtka.SelectedItem as Trgovina;
                noviRacun.trgovina = trgovina.id;

                db.Racuns.Attach(noviRacun);
                db.Racuns.Add(noviRacun);
                db.SaveChanges();

                Racun dodaniRacun = db.Racuns.OrderByDescending(x => x.id).First();

                var listaZaIzbrisati = bl.Where(x => x.kolicina == 0).ToList();
                listaZaIzbrisati.ForEach(x => bl.Remove(x));

                foreach (Djelovi djelovi in bl)
                {
                    Racun_Has_Djelovi rhd = new Racun_Has_Djelovi();
                    rhd.id_racun = dodaniRacun.id;

                    rhd.id_djelovi = djelovi.id;
                    rhd.kolicina = djelovi.kolicina;
                    dodaniRacun.Racun_Has_Djelovi.Add(rhd);

                    //Djelovi dioOduzmiKolicinu = db.Djelovis.First(x => x.id == djelovi.id);
                    //dioOduzmiKolicinu.kolicina -= djelovi.kolicina;
                    Lokacija_has_djelovi lhd = db.Lokacija_has_djelovi.Where(x => x.id_lokacija == lokacijaId && x.id_djelovi == djelovi.id).SingleOrDefault();
                    if (lhd != null)
                    {
                        lhd.kolicina -= djelovi.kolicina;
                        djelovi.kolicina = 0;
                    }
                }

                db.SaveChanges();
                MessageBox.Show("Uspješno ste izdali novi račun");
            }
        }

        private void btnPregledTvrtke_Click(object sender, EventArgs e)
        {
            Trgovina t = cboxTvrtka.SelectedItem as Trgovina;
            FrmTvrtkePregled ftp = new FrmTvrtkePregled(t);

            ftp.ShowDialog();
            ispisComboBox();
        }
    }
}
