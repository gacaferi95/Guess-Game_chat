using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class loja : Form
    {
        Point pika;
        public int width_forma;
        SherbimetSoapClient obj_sherbimet = new SherbimetSoapClient();
        Random randomNumber = new Random();
        int index;
        string useri = "";
        //lita me antaret qe kemi luajtur
        List<string> lista_played = new List<string>();
        List<string> lista_gjeneralja = new List<string>();

        int turn = 0;
        int[] rezultatet = new int[3];
        

        TcpChannel chan;
        ArrayList alOnlineUser = new ArrayList();


        internal SampleObject remoteObj;
        internal int key = 0;
        internal string yourName;


        public string username, password;

        public loja(string Username,string Password)
        {

            this.username = Username;
            this.password = Password;
            InitializeComponent();
            width_forma = Width;
            pika = btnLoja.Location;

        }

        private void loja_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            JoinToChatRoom();
        }

        private void JoinToChatRoom()
        {
            if (chan == null && username.Trim().Length != 0)
            {
                chan = new TcpChannel();
                ChannelServices.RegisterChannel(chan, false);



                remoteObj = (SampleObject)Activator.GetObject(typeof(RemoteBase.SampleObject), "tcp://localhost:8080/ProjektiPSH");

                if (!remoteObj.JoinToChatRoom(username))
                {
                    MessageBox.Show(username + " ekziston ne linje!");
                    ChannelServices.UnregisterChannel(chan);
                    chan = null;
                    this.Dispose();
                    return;
                }
                key = remoteObj.CurrentKeyNo();

                yourName = username;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remoteObj != null)
            {
                string tempStr = remoteObj.GetMsgFromSvr(key);
                if (tempStr.Trim().Length > 0)
                {
                    key++;
                    txtAllChat.Text = txtAllChat.Text + "\n" + tempStr;
                }
                {
                    ArrayList onlineUser = remoteObj.GetOnlineUser();
                    IstOnlineUser.DataSource = onlineUser;
                  

                    if (onlineUser.Count < 2)
                    {
                        txtChatHere.Text = "Ju lutem pritni derisa se paku dy perdorues te jen online!";
                        txtChatHere.Enabled = false;
                    }
                    else if (txtChatHere.Text == "Ju lutem pritni derisa se paku dy perdorues te jen online!" && txtChatHere.Enabled == false)
                    {
                        txtChatHere.Text = "";
                        txtChatHere.Enabled = true;
                    }
                }

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
        private void SendMessage()
        {

            if (remoteObj != null && txtChatHere.Text.Trim().Length > 0)
            {
                remoteObj.SendMsgToSvr(yourName + " says: " + txtChatHere.Text);
                txtChatHere.Text = "";
            }
        }

        private void loja_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (remoteObj != null)
            {
                remoteObj.LeaveChatRoom(yourName);
                txtChatHere.Text = "";
            }
            Application.Exit();
        }

        private void bntLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Closed += (s, args) => this.Close();
            lg.Show();
            remoteObj.LeaveChatRoom(yourName);
            txtChatHere.Text = "";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (useri == username)
            {
                MessageBox.Show("You can't play with yourself!", "Choose another member", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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
                    float sum = 0;
                    float mesatarja;
                    for (int i = 0; i <= 2; i++)
                    {
                        sum += rezultatet[i];
                    }
                    mesatarja = sum / 3;


                    try
                    {
                        if (obj_sherbimet.Rezultatet(username, useri, mesatarja, 0) == true)
                        {
                            MessageBox.Show("You collected " + mesatarja + " points", "Good luck next time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    //tnPlay.Enabled = false;
                    lista_gjeneralja.Add(useri);
                    label2.Text = mesatarja.ToString();
                }
                turn++;
            }
        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            Width = width_forma + 411;
            timer1.Enabled = false;
            label2.Text=(IstOnlineUser.SelectionMode.ToString());
            IstOnlineUser.SelectionMode = SelectionMode.One;
            btnLoja.Visible = false;
            btnClose.Visible = true;
            bntLogout.Location = new Point(759, 37);
        }
      
        private void IstOnlineUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                useri = IstOnlineUser.SelectedValue.ToString();

                if (lista_gjeneralja.Contains(useri))
                {
                    btnPlay.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Start game first and then select player to play!");
            }
        }

        private void btnKush_Click(object sender, EventArgs e)
        {
            Kush_ka_lujatur obj_forma = new Kush_ka_lujatur(username);
            obj_forma.Show();

        }

        private void whoHasPlayedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLoja_Click(sender, e);
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kush_ka_lujatur obj_forma = new Kush_ka_lujatur(username);
            obj_forma.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Width = width_forma;
            btnClose.Visible = false;
            btnLoja.Visible = true;
            bntLogout.Location = new Point(404, 37);
            timer1.Start();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezultatet obj_forma = new Rezultatet(username);
            obj_forma.Show();
        }

        private void txtChatHere_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChatHere_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendMessage();
            }
        }
        
        
    }
}
