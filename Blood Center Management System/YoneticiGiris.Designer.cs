namespace KanBankasıYönetimUygulaması
{
    partial class frmYoneticiGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYoneticiGiris));
            this.lblBaslık = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txb_YoneticiSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.linkLblKapat = new System.Windows.Forms.LinkLabel();
            this.Btn_YoneticiGiris = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblSifre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslık
            // 
            this.lblBaslık.AutoSize = true;
            this.lblBaslık.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslık.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslık.ForeColor = System.Drawing.Color.White;
            this.lblBaslık.Location = new System.Drawing.Point(160, 12);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(368, 84);
            this.lblBaslık.TabIndex = 8;
            this.lblBaslık.Text = "KAN BANKASI YÖNETİM SİSTEMİ\r\n         YÖNETİCİ GİRİŞ EKRANI\r\n\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.lblBaslık);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 96);
            this.panel1.TabIndex = 9;
            // 
            // Txb_YoneticiSifre
            // 
            this.Txb_YoneticiSifre.AutoRoundedCorners = true;
            this.Txb_YoneticiSifre.BorderRadius = 16;
            this.Txb_YoneticiSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_YoneticiSifre.DefaultText = "";
            this.Txb_YoneticiSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_YoneticiSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_YoneticiSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_YoneticiSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_YoneticiSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_YoneticiSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_YoneticiSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_YoneticiSifre.Location = new System.Drawing.Point(427, 205);
            this.Txb_YoneticiSifre.Name = "Txb_YoneticiSifre";
            this.Txb_YoneticiSifre.PasswordChar = '*';
            this.Txb_YoneticiSifre.PlaceholderText = "";
            this.Txb_YoneticiSifre.SelectedText = "";
            this.Txb_YoneticiSifre.Size = new System.Drawing.Size(167, 35);
            this.Txb_YoneticiSifre.TabIndex = 38;
            // 
            // linkLblKapat
            // 
            this.linkLblKapat.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.linkLblKapat.AutoSize = true;
            this.linkLblKapat.BackColor = System.Drawing.Color.Transparent;
            this.linkLblKapat.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLblKapat.LinkColor = System.Drawing.Color.DimGray;
            this.linkLblKapat.Location = new System.Drawing.Point(528, 293);
            this.linkLblKapat.Name = "linkLblKapat";
            this.linkLblKapat.Size = new System.Drawing.Size(93, 17);
            this.linkLblKapat.TabIndex = 35;
            this.linkLblKapat.TabStop = true;
            this.linkLblKapat.Text = "Sayfayı kapat";
            this.linkLblKapat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblKapat_LinkClicked);
            // 
            // Btn_YoneticiGiris
            // 
            this.Btn_YoneticiGiris.ActiveBorderThickness = 1;
            this.Btn_YoneticiGiris.ActiveCornerRadius = 20;
            this.Btn_YoneticiGiris.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_YoneticiGiris.ActiveForecolor = System.Drawing.Color.Firebrick;
            this.Btn_YoneticiGiris.ActiveLineColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_YoneticiGiris.BackColor = System.Drawing.Color.White;
            this.Btn_YoneticiGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_YoneticiGiris.BackgroundImage")));
            this.Btn_YoneticiGiris.ButtonText = "Giriş";
            this.Btn_YoneticiGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_YoneticiGiris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_YoneticiGiris.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_YoneticiGiris.IdleBorderThickness = 1;
            this.Btn_YoneticiGiris.IdleCornerRadius = 20;
            this.Btn_YoneticiGiris.IdleFillColor = System.Drawing.Color.Firebrick;
            this.Btn_YoneticiGiris.IdleForecolor = System.Drawing.Color.White;
            this.Btn_YoneticiGiris.IdleLineColor = System.Drawing.Color.Firebrick;
            this.Btn_YoneticiGiris.Location = new System.Drawing.Point(377, 249);
            this.Btn_YoneticiGiris.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_YoneticiGiris.Name = "Btn_YoneticiGiris";
            this.Btn_YoneticiGiris.Size = new System.Drawing.Size(244, 38);
            this.Btn_YoneticiGiris.TabIndex = 36;
            this.Btn_YoneticiGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_YoneticiGiris.Click += new System.EventHandler(this.Btn_YoneticiGiris_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.Black;
            this.lblSifre.Location = new System.Drawing.Point(374, 214);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(47, 17);
            this.lblSifre.TabIndex = 34;
            this.lblSifre.Text = "Şifre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // frmYoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txb_YoneticiSifre);
            this.Controls.Add(this.linkLblKapat);
            this.Controls.Add(this.Btn_YoneticiGiris);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYoneticiGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YoneticiGiris";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslık;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox Txb_YoneticiSifre;
        private System.Windows.Forms.LinkLabel linkLblKapat;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_YoneticiGiris;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}