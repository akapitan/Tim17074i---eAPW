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
    public partial class FrmReportDjeloviProdaniUZadnjihX2 : Form
    {
        public FrmReportDjeloviProdaniUZadnjihX2()
        {
            InitializeComponent();
        }

        private void FrmReportDjeloviProdaniUZadnjihX2_Load(object sender, EventArgs e)
        {
            DateTime datumPrijeJednogMjeseca = DateTime.Now.AddMonths(-1);
            dateTimePicker1.Value = datumPrijeJednogMjeseca;
        }

        private void BtnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            int lokacijaId = int.Parse(ConfigurationManager.AppSettings["LokacijaID"]);

            BindingList<BrojDjelovaProdanihUZadnjihXNaLokaciji> ListaProdaniDjelovi = null;
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                ListaProdaniDjelovi = new BindingList<BrojDjelovaProdanihUZadnjihXNaLokaciji>
                    (db.BrojDjelovaProdanihUZadnjihXNaLokacijis.Where(x => x.lokacija == lokacijaId 
                    && x.datum < dateTimePicker2.Value && x.datum >dateTimePicker1.Value).ToList());
            }
            BindingList<BrojDjelovaProdanihUZadnjihXNaLokaciji> drugaLista = new BindingList<BrojDjelovaProdanihUZadnjihXNaLokaciji>();

            string id = "sf";
            foreach(BrojDjelovaProdanihUZadnjihXNaLokaciji a in ListaProdaniDjelovi.OrderBy(x=> x.naziv))
            {
                
                if(id == a.naziv)
                {
                    BrojDjelovaProdanihUZadnjihXNaLokaciji stari = drugaLista.Where(x => x.naziv == id).Single();
                    stari.kolicina += a.kolicina;
                }else
                {
                    BrojDjelovaProdanihUZadnjihXNaLokaciji novi = new BrojDjelovaProdanihUZadnjihXNaLokaciji();
                    novi.naziv = a.naziv;
                    novi.kolicina = a.kolicina;
                    drugaLista.Add(novi);

                    id = a.naziv;
                }
                BrojDjelovaProdanihUZadnjihXNaLokacijiBindingSource.DataSource = null;
                BrojDjelovaProdanihUZadnjihXNaLokacijiBindingSource.DataSource = drugaLista;

            }


            this.reportViewer1.RefreshReport();
        }
    }
}
