using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAPW
{
    public partial class UserConPrikazRacuna : UserControl
    {
        public UserConPrikazRacuna(string naziv, string adresa, string oib)
        {
            InitializeComponent();
            txtTvrtkaNaziv.Text = naziv;
            txtTvrtkaAdresa.Text = adresa;
            txtTvrtkaOIB.Text = oib;
        }
    }
}
