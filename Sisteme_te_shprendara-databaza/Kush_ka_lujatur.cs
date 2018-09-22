using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Collections;
using RemoteBase;
using System.Threading;
using Sisteme_te_shprendara_databaza.ServiceReference1;

namespace Sisteme_te_shprendara_databaza
{
    public partial class Kush_ka_lujatur : Form
    {

        SherbimetSoapClient obj_sherbimet = new SherbimetSoapClient();
        Random randomNumber = new Random();
        int index;
        string useri;
        int turn = 0;
        int[] rezultatet = new int[3];


        string perdoruesi = "";
        public Kush_ka_lujatur(string username)
        {
            this.perdoruesi = username;
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string url = "";
            index = randomNumber.Next(1, 7);
            for (int i = 1; i <= 6; i++)
            {
                pictureBox1.Image = new Bitmap(@"D:\Fiek\Semestri - VI\Sistemet e shprendara\Projekti\Chat_Grupi6\Chat_Grupi6\Resources\dice" + i + ".png");
                Thread.Sleep(100);
                pictureBox1.Refresh();
            }

            url = index + "";
            pictureBox1.Image = new Bitmap(@"D:\Fiek\Semestri - VI\Sistemet e shprendara\Projekti\Chat_Grupi6\Chat_Grupi6\Resources\dice" + index + ".png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            rezultatet[turn] = index;
            label2.Text = rezultatet[turn].ToString();



            if (turn == 2)
            {
                label3.Text = rezultatet[2].ToString();
                int sum = 0;
                float mesatarja;
                for (int i = 0; i <= 2; i++)
                {
                    sum += rezultatet[i];
                }
                mesatarja = sum / 3;


                try
                {
                    if (obj_sherbimet.update_rezultati(useri,mesatarja) == true)
                    {
                        MessageBox.Show("Rezultati u rujat me sukses");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                btnPlay.Enabled = false;
                label2.Text = mesatarja.ToString();
            }
            turn++;
        }

        private void Kush_ka_lujatur_Load(object sender, EventArgs e)
        {

            DataSet tedhenat = obj_sherbimet.Kush_ka_luajtur(perdoruesi);
            if (tedhenat.Tables[0].Rows.Count > 0)
            {
                IstOnlineUser.DataSource = tedhenat.Tables[0];
                IstOnlineUser.DisplayMember = "lojtari_1";
            }
            else
            {
                MessageBox.Show("Perdoruesi i tille nuk egziston!");
            }
        }
       

        private void IstOnlineUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = IstOnlineUser.GetItemText(IstOnlineUser.SelectedItem);
            useri = IstOnlineUser.GetItemText(IstOnlineUser.SelectedItem);
        }
    }
}
