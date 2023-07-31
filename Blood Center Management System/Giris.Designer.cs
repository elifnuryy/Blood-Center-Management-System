namespace KanBankasıYönetimUygulaması
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.lblKullanıcı = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.linkLblYntcGrs = new System.Windows.Forms.LinkLabel();
            this.lblBaslık = new System.Windows.Forms.Label();
            this.Btn_Giris = new Bunifu.Framework.UI.BunifuThinButton2();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCks = new System.Windows.Forms.Label();
            this.Txb_Sifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txb_Kullanıcı = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKullanıcı
            // 
            this.lblKullanıcı.AutoSize = true;
            this.lblKullanıcı.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcı.ForeColor = System.Drawing.Color.Black;
            this.lblKullanıcı.Location = new System.Drawing.Point(54, 200);
            this.lblKullanıcı.Name = "lblKullanıcı";
            this.lblKullanıcı.Size = new System.Drawing.Size(87, 20);
            this.lblKullanıcı.TabIndex = 1;
            this.lblKullanıcı.Text = "Kullanıcı:";
            this.lblKullanıcı.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.Black;
            this.lblSifre.Location = new System.Drawing.Point(80, 248);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(55, 20);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre:";
            // 
            // linkLblYntcGrs
            // 
            this.linkLblYntcGrs.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.linkLblYntcGrs.AutoSize = true;
            this.linkLblYntcGrs.BackColor = System.Drawing.Color.Transparent;
            this.linkLblYntcGrs.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLblYntcGrs.LinkColor = System.Drawing.Color.DimGray;
            this.linkLblYntcGrs.Location = new System.Drawing.Point(184, 346);
            this.linkLblYntcGrs.Name = "linkLblYntcGrs";
            this.linkLblYntcGrs.Size = new System.Drawing.Size(169, 17);
            this.linkLblYntcGrs.TabIndex = 6;
            this.linkLblYntcGrs.TabStop = true;
            this.linkLblYntcGrs.Text = "Yönetici Olarak Devam Et";
            this.linkLblYntcGrs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblYntcGrs_LinkClicked);
            // 
            // lblBaslık
            // 
            this.lblBaslık.AutoSize = true;
            this.lblBaslık.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslık.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslık.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBaslık.Location = new System.Drawing.Point(29, 70);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(368, 84);
            this.lblBaslık.TabIndex = 7;
            this.lblBaslık.Text = "KAN BANKASI YÖNETİM SİSTEMİ\r\n                   GİRİŞ EKRANI\r\n\r\n";
            this.lblBaslık.Click += new System.EventHandler(this.lblGiris_Click);
            // 
            // Btn_Giris
            // 
            this.Btn_Giris.ActiveBorderThickness = 1;
            this.Btn_Giris.ActiveCornerRadius = 20;
            this.Btn_Giris.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_Giris.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.Btn_Giris.ActiveLineColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_Giris.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Giris.BackgroundImage")));
            this.Btn_Giris.ButtonText = "Giriş";
            this.Btn_Giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Giris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Giris.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_Giris.IdleBorderThickness = 1;
            this.Btn_Giris.IdleCornerRadius = 20;
            this.Btn_Giris.IdleFillColor = System.Drawing.Color.Firebrick;
            this.Btn_Giris.IdleForecolor = System.Drawing.Color.White;
            this.Btn_Giris.IdleLineColor = System.Drawing.Color.Firebrick;
            this.Btn_Giris.Location = new System.Drawing.Point(70, 291);
            this.Btn_Giris.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Giris.Name = "Btn_Giris";
            this.Btn_Giris.Size = new System.Drawing.Size(283, 49);
            this.Btn_Giris.TabIndex = 8;
            this.Btn_Giris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Giris.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Controls.Add(this.lblCks);
            this.guna2Panel1.Controls.Add(this.Txb_Sifre);
            this.guna2Panel1.Controls.Add(this.Txb_Kullanıcı);
            this.guna2Panel1.Controls.Add(this.lblBaslık);
            this.guna2Panel1.Controls.Add(this.linkLblYntcGrs);
            this.guna2Panel1.Controls.Add(this.Btn_Giris);
            this.guna2Panel1.Controls.Add(this.lblKullanıcı);
            this.guna2Panel1.Controls.Add(this.lblSifre);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(358, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(426, 501);
            this.guna2Panel1.TabIndex = 9;
            // 
            // lblCks
            // 
            this.lblCks.AutoSize = true;
            this.lblCks.BackColor = System.Drawing.Color.Transparent;
            this.lblCks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCks.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCks.Location = new System.Drawing.Point(399, 0);
            this.lblCks.Name = "lblCks";
            this.lblCks.Size = new System.Drawing.Size(27, 25);
            this.lblCks.TabIndex = 33;
            this.lblCks.Text = "X";
            this.lblCks.Click += new System.EventHandler(this.lblCks_Click);
            // 
            // Txb_Sifre
            // 
            this.Txb_Sifre.AutoRoundedCorners = true;
            this.Txb_Sifre.BorderRadius = 18;
            this.Txb_Sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_Sifre.DefaultText = "";
            this.Txb_Sifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_Sifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_Sifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_Sifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_Sifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_Sifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_Sifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_Sifre.Location = new System.Drawing.Point(167, 238);
            this.Txb_Sifre.Name = "Txb_Sifre";
            this.Txb_Sifre.PasswordChar = '*';
            this.Txb_Sifre.PlaceholderText = "";
            this.Txb_Sifre.SelectedText = "";
            this.Txb_Sifre.Size = new System.Drawing.Size(186, 38);
            this.Txb_Sifre.TabIndex = 32;
            // 
            // Txb_Kullanıcı
            // 
            this.Txb_Kullanıcı.AutoRoundedCorners = true;
            this.Txb_Kullanıcı.BorderRadius = 17;
            this.Txb_Kullanıcı.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_Kullanıcı.DefaultText = "";
            this.Txb_Kullanıcı.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_Kullanıcı.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_Kullanıcı.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_Kullanıcı.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_Kullanıcı.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_Kullanıcı.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_Kullanıcı.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_Kullanıcı.Location = new System.Drawing.Point(167, 183);
            this.Txb_Kullanıcı.Name = "Txb_Kullanıcı";
            this.Txb_Kullanıcı.PasswordChar = '\0';
            this.Txb_Kullanıcı.PlaceholderText = "";
            this.Txb_Kullanıcı.SelectedText = "";
            this.Txb_Kullanıcı.Size = new System.Drawing.Size(186, 37);
            this.Txb_Kullanıcı.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(60, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hayat Kurtarmak Senin Kanında Var";
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKullanıcı;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.LinkLabel linkLblYntcGrs;
        private System.Windows.Forms.Label lblBaslık;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Giris;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Txb_Sifre;
        private Guna.UI2.WinForms.Guna2TextBox Txb_Kullanıcı;
        private System.Windows.Forms.Label lblCks;
    }
}