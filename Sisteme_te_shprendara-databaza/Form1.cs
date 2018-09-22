using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sisteme_te_shprendara_databaza.ServiceReference1;

namespace Sisteme_te_shprendara_databaza
{
    public partial class Form1 : Form
    {
        SherbimetSoapClient obj_sherbimet = new SherbimetSoapClient();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShto_Click_1(object sender, EventArgs e)
        {
            string gjinia;
            if (rdbMashkull.Checked)
            {
                gjinia = rdbMashkull.Text;
            }
            else
            {
                gjinia = rdbFemer.Text;
            }
            if (txtFjalekalimi.Text == txtKonfirmo.Text)
            {
                if (obj_sherbimet.Regjistrohu(txtEmri.Text, txtMbiemri.Text, gjinia, txtDatelindja.Text,txtFjalekalimi.Text) == true)
                {
                    MessageBox.Show("Regjistrimi u krye me suksese");
                }
                else
                {
                    MessageBox.Show("Dicka shkoi gabim");
                }
            }
            else
            {
                MessageBox.Show("Fjalekalimet nuk perputhen!");
                txtFjalekalimi.Select();
            }

           

        }
    }
}
