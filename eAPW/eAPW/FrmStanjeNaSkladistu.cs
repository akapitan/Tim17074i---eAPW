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
    public partial class FrmStanjeNaSkladistu : Form
    {
        public FrmStanjeNaSkladistu()
        {
            InitializeComponent();
        }

        private void FrmStanjeNaSkladistu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ProgramskoInzenjerstvoDBDataSet.StanjeNaSkladistu' table. You can move, or remove it, as needed.
            //this.StanjeNaSkladistuTableAdapter.Fill(this.ProgramskoInzenjerstvoDBDataSet.StanjeNaSkladistu, 2);
            using (var db = new ProgramskoInzenjerstvoDBEntities())
            {
                BindingList<StanjeNaSkladistu> listaNaSkladistu = null;
                listaNaSkladistu = new BindingList<StanjeNaSkladistu>(db.StanjeNaSkladistus.Where(x => x.id == 2).ToList());
                StanjeNaSkladistuBindingSource.DataSource = listaNaSkladistu;
                
            }

            this.reportViewer1.RefreshReport();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
