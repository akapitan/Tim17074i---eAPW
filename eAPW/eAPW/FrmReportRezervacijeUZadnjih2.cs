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
    /// <summary>
    /// Klasa forme s izvještajem o broju rezervacija
    /// </summary>
    public partial class FrmReportRezervacijeUZadnjih2 : Form
    {
        /// <summary>
        /// Konstruktor klase
        /// </summary>
        public FrmReportRezervacijeUZadnjih2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dodavanje početnih vrijednosti poslije inicijalizacije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReportRezervacijeUZadnjih2_Load(object sender, EventArgs e)
        {
            DateTime datumPrijeJednogMjeseca = DateTime.Now.AddMonths(-1);
            dateTimePicker1.Value = datumPrijeJednogMjeseca;
        }

        /// <summary>
        /// Izlaz iz forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Klikom na unsei popunjavaju se podaci o rezervaciji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value < dateTimePicker2.Value.AddDays(-1))
            {
                int lokacijaId = int.Parse(ConfigurationManager.AppSettings["LokacijaID"]);

                BindingList<BrojRezervacijaUZadnjihXNaLokaciji> ListaProdaniDjelovi = null;
                BindingList<BrojRezervacijaUZadnjihXNaLokaciji> drugaLista = new BindingList<BrojRezervacijaUZadnjihXNaLokaciji>();
                using (var db = new ProgramskoInzenjerstvoDBEntities())
                {
                    ListaProdaniDjelovi = new BindingList<BrojRezervacijaUZadnjihXNaLokaciji>
                        (db.BrojRezervacijaUZadnjihXNaLokacijis.Where(x => x.lokacija == lokacijaId
                        && x.datumIzdavanja < dateTimePicker2.Value && x.datumIzdavanja > dateTimePicker1.Value).ToList());
                }


                string id = "sf";
                foreach (BrojRezervacijaUZadnjihXNaLokaciji a in ListaProdaniDjelovi.OrderBy(x => x.naziv))
                {

                    if (id == a.naziv)
                    {
                        BrojRezervacijaUZadnjihXNaLokaciji stari = drugaLista.Where(x => x.naziv == id).Single();
                        stari.kolicina += a.kolicina;
                    }
                    else
                    {
                        BrojRezervacijaUZadnjihXNaLokaciji novi = new BrojRezervacijaUZadnjihXNaLokaciji();
                        novi.naziv = a.naziv;
                        novi.kolicina = a.kolicina;
                        drugaLista.Add(novi);

                        id = a.naziv;
                    }
                                       
                }

                BrojRezervacijaUZadnjihXNaLokacijiBindingSource.DataSource = null;
                BrojRezervacijaUZadnjihXNaLokacijiBindingSource.DataSource = drugaLista;


            }
            else
            {
                MessageBox.Show("Molimo upisite valjane podatke");
            }


            this.reportViewer1.RefreshReport();
        }
    }
}
