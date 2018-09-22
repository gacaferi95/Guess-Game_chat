using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sisteme_te_shprendara_databaza.ServiceReference1;

namespace Sisteme_te_shprendara_databaza
{
   
    public partial class Rezultatet : Form
    {
        SherbimetSoapClient obj_sherbimet = new SherbimetSoapClient();
        

        string username;
        public Rezultatet(string _username)
        {
            this.username=_username;
            InitializeComponent();
            
        }

        private void Rezultatet_Load(object sender, EventArgs e)
        {
            DataSet rezultatet = obj_sherbimet.selekto_Rezultatet(username);
            dataGridView1.DataSource = rezultatet.Tables[0];
        }
        

    }
}
