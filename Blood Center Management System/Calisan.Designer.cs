namespace KanBankasıYönetimUygulaması
{
    partial class frmCalisan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalisan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblcıkıs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblbaslık = new System.Windows.Forms.Label();
            this.Txb_CSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_CEkle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblcsifre = new System.Windows.Forms.Label();
            this.lblcadsoyad = new System.Windows.Forms.Label();
            this.Txb_CAdSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.CalisanDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Btn_CGuncelle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_CSil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalisanDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblcıkıs);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 594);
            this.panel2.TabIndex = 5;
            // 
            // lblcıkıs
            // 
            this.lblcıkıs.AutoSize = true;
            this.lblcıkıs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblcıkıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcıkıs.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcıkıs.ForeColor = System.Drawing.Color.DarkRed;
            this.lblcıkıs.Location = new System.Drawing.Point(76, 187);
            this.lblcıkıs.Name = "lblcıkıs";
            this.lblcıkıs.Size = new System.Drawing.Size(131, 31);
            this.lblcıkıs.TabIndex = 57;
            this.lblcıkıs.Text = "Çıkış Yap";
            this.lblcıkıs.Click += new System.EventHandler(this.lblcıkıs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(72, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 50;
            this.label1.Text = "Çalışan İşlemleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Location = new System.Drawing.Point(52, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 31);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.lblbaslık);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(288, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(826, 82);
            this.panel4.TabIndex = 44;
            // 
            // lblbaslık
            // 
            this.lblbaslık.AutoSize = true;
            this.lblbaslık.BackColor = System.Drawing.Color.Transparent;
            this.lblbaslık.Font = new System.Drawing.Font("Poor Richard", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaslık.ForeColor = System.Drawing.Color.DarkRed;
            this.lblbaslık.Location = new System.Drawing.Point(16, 25);
            this.lblbaslık.Name = "lblbaslık";
            this.lblbaslık.Size = new System.Drawing.Size(571, 45);
            this.lblbaslık.TabIndex = 15;
            this.lblbaslık.Text = "KAN BANKASI YÖNETİM SİSTEMİ";
            // 
            // Txb_CSifre
            // 
            this.Txb_CSifre.AutoRoundedCorners = true;
            this.Txb_CSifre.BorderRadius = 17;
            this.Txb_CSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_CSifre.DefaultText = "";
            this.Txb_CSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_CSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_CSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_CSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_CSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_CSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_CSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_CSifre.Location = new System.Drawing.Point(854, 476);
            this.Txb_CSifre.Name = "Txb_CSifre";
            this.Txb_CSifre.PasswordChar = '\0';
            this.Txb_CSifre.PlaceholderText = "";
            this.Txb_CSifre.SelectedText = "";
            this.Txb_CSifre.Size = new System.Drawing.Size(200, 36);
            this.Txb_CSifre.TabIndex = 59;
            // 
            // Btn_CEkle
            // 
            this.Btn_CEkle.ActiveBorderThickness = 1;
            this.Btn_CEkle.ActiveCornerRadius = 20;
            this.Btn_CEkle.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_CEkle.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.Btn_CEkle.ActiveLineColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_CEkle.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_CEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_CEkle.BackgroundImage")));
            this.Btn_CEkle.ButtonText = "Ekle";
            this.Btn_CEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_CEkle.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_CEkle.IdleBorderThickness = 1;
            this.Btn_CEkle.IdleCornerRadius = 20;
            this.Btn_CEkle.IdleFillColor = System.Drawing.Color.DarkRed;
            this.Btn_CEkle.IdleForecolor = System.Drawing.Color.White;
            this.Btn_CEkle.IdleLineColor = System.Drawing.Color.DarkRed;
            this.Btn_CEkle.Location = new System.Drawing.Point(336, 532);
            this.Btn_CEkle.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_CEkle.Name = "Btn_CEkle";
            this.Btn_CEkle.Size = new System.Drawing.Size(198, 38);
            this.Btn_CEkle.TabIndex = 58;
            this.Btn_CEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_CEkle.Click += new System.EventHandler(this.Btn_CEkle_Click);
            // 
            // lblcsifre
            // 
            this.lblcsifre.AutoSize = true;
            this.lblcsifre.BackColor = System.Drawing.Color.Transparent;
            this.lblcsifre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcsifre.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcsifre.ForeColor = System.Drawing.Color.Black;
            this.lblcsifre.Location = new System.Drawing.Point(735, 476);
            this.lblcsifre.Name = "lblcsifre";
            this.lblcsifre.Size = new System.Drawing.Size(67, 28);
            this.lblcsifre.TabIndex = 57;
            this.lblcsifre.Text = "Şifre:";
            // 
            // lblcadsoyad
            // 
            this.lblcadsoyad.AutoSize = true;
            this.lblcadsoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblcadsoyad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcadsoyad.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadsoyad.ForeColor = System.Drawing.Color.Black;
            this.lblcadsoyad.Location = new System.Drawing.Point(341, 476);
            this.lblcadsoyad.Name = "lblcadsoyad";
            this.lblcadsoyad.Size = new System.Drawing.Size(114, 28);
            this.lblcadsoyad.TabIndex = 55;
            this.lblcadsoyad.Text = "Ad Soyad:";
            // 
            // Txb_CAdSoyad
            // 
            this.Txb_CAdSoyad.AutoRoundedCorners = true;
            this.Txb_CAdSoyad.BorderRadius = 17;
            this.Txb_CAdSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_CAdSoyad.DefaultText = "";
            this.Txb_CAdSoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_CAdSoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_CAdSoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_CAdSoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_CAdSoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_CAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_CAdSoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_CAdSoyad.Location = new System.Drawing.Point(461, 476);
            this.Txb_CAdSoyad.Name = "Txb_CAdSoyad";
            this.Txb_CAdSoyad.PasswordChar = '\0';
            this.Txb_CAdSoyad.PlaceholderText = "";
            this.Txb_CAdSoyad.SelectedText = "";
            this.Txb_CAdSoyad.Size = new System.Drawing.Size(200, 36);
            this.Txb_CAdSoyad.TabIndex = 56;
            // 
            // CalisanDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.CalisanDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.CalisanDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CalisanDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CalisanDGV.ColumnHeadersHeight = 30;
            this.CalisanDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CalisanDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.CalisanDGV.GridColor = System.Drawing.Color.White;
            this.CalisanDGV.Location = new System.Drawing.Point(327, 141);
            this.CalisanDGV.Name = "CalisanDGV";
            this.CalisanDGV.RowHeadersVisible = false;
            this.CalisanDGV.RowTemplate.Height = 25;
            this.CalisanDGV.Size = new System.Drawing.Size(765, 282);
            this.CalisanDGV.TabIndex = 54;
            this.CalisanDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CalisanDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CalisanDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CalisanDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CalisanDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CalisanDGV.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CalisanDGV.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.CalisanDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.CalisanDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CalisanDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalisanDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CalisanDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CalisanDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.CalisanDGV.ThemeStyle.ReadOnly = false;
            this.CalisanDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CalisanDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CalisanDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalisanDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CalisanDGV.ThemeStyle.RowsStyle.Height = 25;
            this.CalisanDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.CalisanDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CalisanDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CalisanDGV_CellContentClick);
            // 
            // Btn_CGuncelle
            // 
            this.Btn_CGuncelle.ActiveBorderThickness = 1;
            this.Btn_CGuncelle.ActiveCornerRadius = 20;
            this.Btn_CGuncelle.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_CGuncelle.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.Btn_CGuncelle.ActiveLineColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_CGuncelle.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_CGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_CGuncelle.BackgroundImage")));
            this.Btn_CGuncelle.ButtonText = "Güncelle";
            this.Btn_CGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_CGuncelle.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_CGuncelle.IdleBorderThickness = 1;
            this.Btn_CGuncelle.IdleCornerRadius = 20;
            this.Btn_CGuncelle.IdleFillColor = System.Drawing.Color.Green;
            this.Btn_CGuncelle.IdleForecolor = System.Drawing.Color.White;
            this.Btn_CGuncelle.IdleLineColor = System.Drawing.Color.Green;
            this.Btn_CGuncelle.Location = new System.Drawing.Point(595, 532);
            this.Btn_CGuncelle.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_CGuncelle.Name = "Btn_CGuncelle";
            this.Btn_CGuncelle.Size = new System.Drawing.Size(198, 38);
            this.Btn_CGuncelle.TabIndex = 60;
            this.Btn_CGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_CGuncelle.Click += new System.EventHandler(this.Btn_CGuncelle_Click);
            // 
            // Btn_CSil
            // 
            this.Btn_CSil.ActiveBorderThickness = 1;
            this.Btn_CSil.ActiveCornerRadius = 20;
            this.Btn_CSil.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_CSil.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.Btn_CSil.ActiveLineColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_CSil.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_CSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_CSil.BackgroundImage")));
            this.Btn_CSil.ButtonText = "Sil";
            this.Btn_CSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_CSil.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_CSil.IdleBorderThickness = 1;
            this.Btn_CSil.IdleCornerRadius = 20;
            this.Btn_CSil.IdleFillColor = System.Drawing.Color.DarkGray;
            this.Btn_CSil.IdleForecolor = System.Drawing.Color.White;
            this.Btn_CSil.IdleLineColor = System.Drawing.Color.DarkGray;
            this.Btn_CSil.Location = new System.Drawing.Point(854, 532);
            this.Btn_CSil.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_CSil.Name = "Btn_CSil";
            this.Btn_CSil.Size = new System.Drawing.Size(198, 38);
            this.Btn_CSil.TabIndex = 61;
            this.Btn_CSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_CSil.Click += new System.EventHandler(this.Btn_CSil_Click);
            // 
            // frmCalisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 594);
            this.Controls.Add(this.Btn_CSil);
            this.Controls.Add(this.Btn_CGuncelle);
            this.Controls.Add(this.Txb_CSifre);
            this.Controls.Add(this.Btn_CEkle);
            this.Controls.Add(this.lblcsifre);
            this.Controls.Add(this.lblcadsoyad);
            this.Controls.Add(this.Txb_CAdSoyad);
            this.Controls.Add(this.CalisanDGV);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalisan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calısan";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalisanDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblcıkıs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblbaslık;
        private Guna.UI2.WinForms.Guna2TextBox Txb_CSifre;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_CEkle;
        private System.Windows.Forms.Label lblcsifre;
        private System.Windows.Forms.Label lblcadsoyad;
        private Guna.UI2.WinForms.Guna2TextBox Txb_CAdSoyad;
        private Guna.UI2.WinForms.Guna2DataGridView CalisanDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_CGuncelle;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_CSil;
    }
}