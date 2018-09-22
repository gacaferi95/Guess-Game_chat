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
    public partial class Login : Form
    {
        SherbimetSoapClient obj_sherbimet = new SherbimetSoapClient();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtPerdoruesi.Text != "") && (txtFjalekalimi.Text != ""))
            {


                DataSet tedhenat = obj_sherbimet.Kyqu(txtPerdoruesi.Text, txtFjalekalimi.Text);
                if (tedhenat.Tables[0].Rows.Count > 0 )
                {
                    loja form_loja = new loja(txtPerdoruesi.Text, txtFjalekalimi.Text);
                    this.Hide();
                    form_loja.Show();
                }
                else
                {
                    MessageBox.Show("Perdoruesi i tille nuk egziston!");
                }
            }

            else
            {
                MessageBox.Show("Ju lutem plotesoni te dhenat per kyqje!");
               
            }
        }

       
        private void label1_Click(object sender, EventArgs e)
        {
            Form1 forma_regjistrimi = new Form1();
            forma_regjistrimi.Show();
        }
    }
}
