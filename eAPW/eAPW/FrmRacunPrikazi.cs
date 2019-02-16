using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace eAPW
{
    /// <summary>
    /// Klasa forme za prikazivanje računa
    /// </summary>
    public partial class FrmRacunPrikazi : Form
    {
        /// <summary>
        /// Preneseni id računa. Koriste ga više metoda.
        /// </summary>
        int idRacun;

        /// <summary>
        /// Konstruktor forme FrmRacuniPrikazi
        /// </summary>
        /// <param name="selektiraniRacunId"></param>
        public FrmRacunPrikazi(int selektiraniRacunId)
        {
            InitializeComponent();
            idRacun = selektiraniRacunId;
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
        /// Funkcija za dohvačanje podataka računa i ispis na datagrid
        /// </summary>
        private void dohvatiPodatke()
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                Racun racun = (from x in db.Racuns where x.id == idRacun select x).SingleOrDefault();
                if (racun.Maloprodaja_veleprodaja == "Maloprodaja")
                {
                    this.Text = "Račun - maloprodaja";
                }
                else
                {
                    UserConPrikazRacuna pr = new UserConPrikazRacuna(racun.Trgovina1.naziv, racun.Trgovina1.adresa, racun.Trgovina1.oib);
                    pr.Location = new Point(320, 10);
                    this.Controls.Add(pr);
                    this.Text = "Račun - veleprodaja";
                }

                var model = (from x in db.Djelovis
                             join y in db.Racun_Has_Djelovi on x.id equals y.id_djelovi
                             join z in db.Kategorijas on x.kategorija equals z.Id
                             where y.id_racun == idRacun
                             select new
                             {
                                 Naziv = x.naziv,
                                 kategorija = z.naziv,
                                 cijena = x.maloprodajnaCijena,
                                 kolicina = y.kolicina,
                                 iznos = (x.maloprodajnaCijena * y.kolicina).ToString() + " kn"

                             }).ToList();
                dataGridView1.DataSource = model;

                var zaposlenik = (from x in db.Zaposleniks
                                  join y in db.Racuns on x.ID equals y.zaposlenik
                                  where y.id == idRacun
                                  select new
                                  {
                                      ime = x.ime,
                                      prezime = x.prezime,
                                      iznos = y.iznos,
                                      datum = y.datum

                                  }).SingleOrDefault();
                txtIzdao.Text = zaposlenik.ime.Trim() + " " + zaposlenik.prezime.Trim();
                txtIznos.Text = zaposlenik.iznos;
                txtDatum.Text = zaposlenik.datum.ToString();
            }
        
    }

        /// <summary>
        /// Pozivanje funkcije za  popunjavanje podataka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRacunPrikazi_Load(object sender, EventArgs e)
        {
            dohvatiPodatke();
        }

        /// <summary>
        /// Otvaranje help dokumenta pritiskom na F1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="hlpevent"></param>
        private void FrmRacunPrikazi_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Prodaja.htm");
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    using (var db = new ProgramskoInzenjerstvoDBEntities())
        //    {
        //        Racun racun = (from x in db.Racuns where x.id == idRacun select x).SingleOrDefault();
        //        if (racun.Maloprodaja_veleprodaja == "Maloprodaja")
        //        {
        //            this.Text = "Račun - maloprodaja";
        //        }
        //        else
        //        {
        //            UserConPrikazRacuna pr = new UserConPrikazRacuna(racun.Trgovina1.naziv, racun.Trgovina1.adresa, racun.Trgovina1.oib);
        //            pr.Location = new Point(320, 10);
        //            this.Controls.Add(pr);
        //            this.Text = "Račun - veleprodaja";
        //        }

        //        var model = (from x in db.Djelovis
        //                     join y in db.Racun_Has_Djelovi on x.id equals y.id_djelovi
        //                     join z in db.Kategorijas on x.kategorija equals z.Id
        //                     where y.id_racun == idRacun
        //                     select new
        //                     {
        //                         Naziv = x.naziv,
        //                         kategorija = z.naziv,
        //                         cijena = x.maloprodajnaCijena,
        //                         kolicina = y.kolicina,
        //                         iznos = (x.maloprodajnaCijena * y.kolicina).ToString() + " kn"

        //                     }).ToList();


        //        var zaposlenik = (from x in db.Zaposleniks
        //                          join y in db.Racuns on x.ID equals y.zaposlenik
        //                          where y.id == idRacun
        //                          select new
        //                          {
        //                              ime = x.ime,
        //                              prezime = x.prezime,
        //                              iznos = y.iznos,
        //                              datum = y.datum

        //                          }).SingleOrDefault();

        //        //////////////////////

        //    }
        //}

    }
}
