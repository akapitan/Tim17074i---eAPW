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
    public partial class FrmAdminCRUDZaposlenikNovi : Form
    {
        Zaposlenik zaposlenik;
        public FrmAdminCRUDZaposlenikNovi()
        {
            InitializeComponent();
        }
        
        public FrmAdminCRUDZaposlenikNovi(Zaposlenik z)
        {
            InitializeComponent();
            zaposlenik = z;
            txtIme.Text = zaposlenik.ime;
            txtPrezime.Text = zaposlenik.prezime;
            txtAdresa.Text = zaposlenik.adresa;
            txtOIB.Text = zaposlenik.oib;
            txtEmail.Text = zaposlenik.email;
            txtKorisnicko.Text = zaposlenik.korisnickoIme;
            txtLozinka.Text = zaposlenik.lozinka;


        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdminCRUDZaposlenikNovi_Load(object sender, EventArgs e)
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                foreach (var zap in db.Tips)
                {
                    checkedListBox1.Items.Add(zap);

                }
                cBoxRadnoMjesto.DataSource = db.Lokacijas.ToList();
                //Čekiranje checkboxova kod izmjene uloge korisnika
                if (zaposlenik != null)
                {
                    var korIme = (from z in db.Zaposleniks
                                  where z.korisnickoIme == zaposlenik.korisnickoIme && zaposlenik.lozinka == z.lozinka
                                  select z).Single();
                    zaposlenik = korIme;
                    
                    foreach (var a in zaposlenik.Zaposlenik_has_Tip)
                    {
                        for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        {
                            if (checkedListBox1.Items[i].ToString() == a.Tip.naziv)
                            {

                                checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                            }
                        }
                    }

                    //selektiranje radnog mjesta na combobox-u
                    cBoxRadnoMjesto.SelectedItem = zaposlenik.Lokacija;

                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            List<Tip> listaSelektiranihUloga = new List<Tip>();

            foreach (var sel in checkedListBox1.CheckedItems)
            {
                if (sel is Tip)
                {

                    listaSelektiranihUloga.Add(sel as Tip);
                }
            }

            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                if (zaposlenik == null)
                {

                    //Zaposlenik zaposlenik2 = new Zaposlenik(txtIme.Text, txtPrezime.Text, txtAdresa.Text, txtOIB.Text, txtEmail.Text, txtKorisnicko.Text, txtLozinka.Text);
                    Zaposlenik zaposlenik2 = new Zaposlenik();

                    zaposlenik2.ime = txtIme.Text;
                    zaposlenik2.prezime = txtPrezime.Text;
                    zaposlenik2.adresa = txtAdresa.Text;
                    zaposlenik2.oib = txtOIB.Text;
                    zaposlenik2.email = txtEmail.Text;
                    zaposlenik2.korisnickoIme = txtKorisnicko.Text;
                    zaposlenik2.lozinka = txtLozinka.Text;
                    //bool a = provjeriKorisnickoIme(zaposlenik2);

                    try
                    {
                        double oib = double.Parse(zaposlenik2.oib);
                        if (oib > 0 && oib < 9999999999999)
                        {
                            db.Zaposleniks.Add(zaposlenik2);

                            foreach (Tip t in listaSelektiranihUloga)
                            {
                                Zaposlenik_has_Tip zht = new Zaposlenik_has_Tip();

                                zht.id_tip = t.id;
                                zht.id_zaposlenik = zaposlenik2.ID;

                                zaposlenik2.Zaposlenik_has_Tip.Add(zht);

                            }

                            db.SaveChanges();

                            MessageBox.Show("Uspješno se dodali zaposlenika");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("A štaš??");
                        }

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }

                }
                //Izmjena korisnika

                else
                {
                    try
                    {
                        db.Zaposleniks.Attach(zaposlenik);
                        zaposlenik.ime = txtIme.Text;
                        zaposlenik.prezime = txtPrezime.Text;
                        zaposlenik.email = txtEmail.Text;
                        zaposlenik.adresa = txtAdresa.Text;
                        zaposlenik.oib = txtOIB.Text;
                        zaposlenik.korisnickoIme = txtKorisnicko.Text;
                        zaposlenik.lozinka = txtLozinka.Text;
                        zaposlenik.Zaposlenik_has_Tip.Clear();

                        foreach (Tip t in listaSelektiranihUloga)
                        {
                            Zaposlenik_has_Tip zht = new Zaposlenik_has_Tip();

                            zht.id_tip = t.id;
                            zht.id_zaposlenik = zaposlenik.ID;

                            zaposlenik.Zaposlenik_has_Tip.Add(zht);

                        }


                        db.SaveChanges();
                        MessageBox.Show("Uspješno se izmjenili korisnika " + zaposlenik.korisnickoIme);
                        Close();
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
            }
        }

        private bool provjeriKorisnickoIme(Zaposlenik provjeraKorisnika)
        {
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                var korIme = (from z in db.Zaposleniks
                              where z.korisnickoIme == provjeraKorisnika.korisnickoIme
                              select z).SingleOrDefault();
                bool b = korIme.korisnickoIme == provjeraKorisnika.korisnickoIme;
                MessageBox.Show(b.ToString());
                return korIme.korisnickoIme == provjeraKorisnika.korisnickoIme;

            }


        }
    }
}
