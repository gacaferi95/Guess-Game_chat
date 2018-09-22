namespace Sisteme_te_shprendara_databaza
{
    partial class loja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.IstOnlineUser = new System.Windows.Forms.ListBox();
            this.txtAllChat = new System.Windows.Forms.RichTextBox();
            this.txtChatHere = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bntLogout = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoja = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.whoHasPlayWithMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoHasPlayedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Online user:";
            // 
            // IstOnlineUser
            // 
            this.IstOnlineUser.FormattingEnabled = true;
            this.IstOnlineUser.Location = new System.Drawing.Point(256, 102);
            this.IstOnlineUser.Name = "IstOnlineUser";
            this.IstOnlineUser.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.IstOnlineUser.Size = new System.Drawing.Size(108, 316);
            this.IstOnlineUser.TabIndex = 25;
            this.IstOnlineUser.SelectedIndexChanged += new System.EventHandler(this.IstOnlineUser_SelectedIndexChanged);
            // 
            // txtAllChat
            // 
            this.txtAllChat.AutoWordSelection = true;
            this.txtAllChat.BackColor = System.Drawing.SystemColors.Window;
            this.txtAllChat.Location = new System.Drawing.Point(38, 92);
            this.txtAllChat.Name = "txtAllChat";
            this.txtAllChat.ReadOnly = true;
            this.txtAllChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtAllChat.Size = new System.Drawing.Size(194, 342);
            this.txtAllChat.TabIndex = 24;
            this.txtAllChat.Text = "";
            // 
            // txtChatHere
            // 
            this.txtChatHere.Location = new System.Drawing.Point(38, 452);
            this.txtChatHere.Name = "txtChatHere";
            this.txtChatHere.Size = new System.Drawing.Size(120, 20);
            this.txtChatHere.TabIndex = 23;
            this.txtChatHere.TextChanged += new System.EventHandler(this.txtChatHere_TextChanged);
            this.txtChatHere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChatHere_KeyPress);
            // 
            // btnSend
            // 
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(125)))), ((int)(((byte)(195)))));
            this.btnSend.Location = new System.Drawing.Point(164, 451);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(68, 20);
            this.btnSend.TabIndex = 22;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bntLogout
            // 
            this.bntLogout.Location = new System.Drawing.Point(391, 58);
            this.bntLogout.Name = "bntLogout";
            this.bntLogout.Size = new System.Drawing.Size(75, 23);
            this.bntLogout.TabIndex = 27;
            this.bntLogout.Text = "Logout";
            this.bntLogout.UseVisualStyleBackColor = true;
            this.bntLogout.Click += new System.EventHandler(this.bntLogout_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(642, 435);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 29;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(782, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "label2";
            // 
            // btnLoja
            // 
            this.btnLoja.Location = new System.Drawing.Point(391, 233);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(75, 79);
            this.btnLoja.TabIndex = 31;
            this.btnLoja.Text = "Start Game";
            this.btnLoja.UseVisualStyleBackColor = true;
            this.btnLoja.Click += new System.EventHandler(this.btnLoja_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(852, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "label3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whoHasPlayWithMeToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // whoHasPlayWithMeToolStripMenuItem
            // 
            this.whoHasPlayWithMeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.whoHasPlayWithMeToolStripMenuItem.Name = "whoHasPlayWithMeToolStripMenuItem";
            this.whoHasPlayWithMeToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.whoHasPlayWithMeToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whoHasPlayedToolStripMenuItem,
            this.playToolStripMenuItem,
            this.resultsToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // whoHasPlayedToolStripMenuItem
            // 
            this.whoHasPlayedToolStripMenuItem.Name = "whoHasPlayedToolStripMenuItem";
            this.whoHasPlayedToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.whoHasPlayedToolStripMenuItem.Text = "Start Game";
            this.whoHasPlayedToolStripMenuItem.Click += new System.EventHandler(this.whoHasPlayedToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.playToolStripMenuItem.Text = "Who has Played";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(391, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 79);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close Game";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.resultsToolStripMenuItem.Text = "Results";
            this.resultsToolStripMenuItem.Click += new System.EventHandler(this.resultsToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sisteme_te_shprendara_databaza.Properties.Resources.dice1;
            this.pictureBox1.Location = new System.Drawing.Point(512, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 484);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLoja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bntLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IstOnlineUser);
            this.Controls.Add(this.txtAllChat);
            this.Controls.Add(this.txtChatHere);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "loja";
            this.Text = ".";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.loja_FormClosed);
            this.Load += new System.EventHandler(this.loja_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox IstOnlineUser;
        private System.Windows.Forms.RichTextBox txtAllChat;
        private System.Windows.Forms.TextBox txtChatHere;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bntLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem whoHasPlayWithMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoHasPlayedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
    }
}