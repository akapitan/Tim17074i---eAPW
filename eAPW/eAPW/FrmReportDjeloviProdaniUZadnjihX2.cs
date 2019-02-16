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
    /// Forma sa izvještajem o prodaji 
    /// </summary>
    public partial class FrmReportDjeloviProdaniUZadnjihX2 : Form
    {
        /// <summary>
        /// Konstruktor forme FrmReportDjeloviProdaniUZadnjihX2
        /// </summary>
        public FrmReportDjeloviProdaniUZadnjihX2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Postavljanje početnih vrijednosti poslije inicijalizacije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReportDjeloviProdaniUZadnjihX2_Load(object sender, EventArgs e)
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
        /// Klikom na gumb popunjavaju se podaci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value < dateTimePicker2.Value.AddDays(-1))
            {
                int lokacijaId = int.Parse(ConfigurationManager.AppSettings["LokacijaID"]);
                string adresaLokacije;

                BindingList<BrojDjelovaProdanihUZadnjihXNaLokaciji> ListaProdaniDjelovi = null;
                using (var db = new ProgramskoInzenjerstvoDBEntities())
                {
                    // Dohvačanje dijelova
                    ListaProdaniDjelovi = new BindingList<BrojDjelovaProdanihUZadnjihXNaLokaciji>
                        (db.BrojDjelovaProdanihUZadnjihXNaLokacijis.Where(x => x.lokacija == lokacijaId
                        && x.datum < dateTimePicker2.Value && x.datum > dateTimePicker1.Value).ToList());

                    // Dohvačanje adrese lokacije
                    adresaLokacije = db.Lokacijas.Where(x => x.id == lokacijaId).Select(x => x.Adresa).First();
                    
                }
                BindingList<BrojDjelovaProdanihUZadnjihXNaLokaciji> drugaLista = new BindingList<BrojDjelovaProdanihUZadnjihXNaLokaciji>();

                string id = "sf";
                foreach (BrojDjelovaProdanihUZadnjihXNaLokaciji a in ListaProdaniDjelovi.OrderBy(x => x.naziv))
                {

                    if (id == a.naziv)
                    {
                        BrojDjelovaProdanihUZadnjihXNaLokaciji stari = drugaLista.Where(x => x.naziv == id).Single();
                        stari.kolicina += a.kolicina;
                    }
                    else
                    {
                        BrojDjelovaProdanihUZadnjihXNaLokaciji novi = new BrojDjelovaProdanihUZadnjihXNaLokaciji();
                        novi.naziv = a.naziv;
                        novi.kolicina = a.kolicina;
                        drugaLista.Add(novi);

                        id = a.naziv;
                    }
                    
                }
                BrojDjelovaProdanihUZadnjihXNaLokacijiBindingSource.DataSource = null;
                BrojDjelovaProdanihUZadnjihXNaLokacijiBindingSource.DataSource = drugaLista;

                

            }
            else
            {
                MessageBox.Show("Molimo upisite valjane podatke");
            }


            this.reportViewer1.RefreshReport();
        }
    }
}
