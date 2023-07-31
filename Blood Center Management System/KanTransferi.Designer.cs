namespace KanBankasıYönetimUygulaması
{
    partial class frmKanTransferi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKanTransferi));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblbaslık = new System.Windows.Forms.Label();
            this.TransferDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cb_HId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.Txb_HAdSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txb_HKGrup = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbluygun = new System.Windows.Forms.Label();
            this.Btn_TransferYap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblKanBagısı = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCıkıs = new System.Windows.Forms.Label();
            this.lblKontrol = new System.Windows.Forms.Label();
            this.lblKTransferi = new System.Windows.Forms.Label();
            this.lblKStogu = new System.Windows.Forms.Label();
            this.lblHastaIslemleri = new System.Windows.Forms.Label();
            this.lblHIslemleri = new System.Windows.Forms.Label();
            this.lblDListesi = new System.Windows.Forms.Label();
            this.lblDIslemleri = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransferDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Controls.Add(this.lblbaslık);
            this.panel4.Location = new System.Drawing.Point(287, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(828, 85);
            this.panel4.TabIndex = 43;
            // 
            // lblbaslık
            // 
            this.lblbaslık.AutoSize = true;
            this.lblbaslık.BackColor = System.Drawing.Color.Transparent;
            this.lblbaslık.Font = new System.Drawing.Font("Poor Richard", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaslık.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblbaslık.Location = new System.Drawing.Point(134, 24);
            this.lblbaslık.Name = "lblbaslık";
            this.lblbaslık.Size = new System.Drawing.Size(571, 45);
            this.lblbaslık.TabIndex = 15;
            this.lblbaslık.Text = "KAN BANKASI YÖNETİM SİSTEMİ";
            // 
            // TransferDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TransferDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransferDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TransferDGV.ColumnHeadersHeight = 30;
            this.TransferDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransferDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.TransferDGV.GridColor = System.Drawing.Color.White;
            this.TransferDGV.Location = new System.Drawing.Point(320, 383);
            this.TransferDGV.Name = "TransferDGV";
            this.TransferDGV.RowHeadersVisible = false;
            this.TransferDGV.RowTemplate.Height = 25;
            this.TransferDGV.Size = new System.Drawing.Size(760, 163);
            this.TransferDGV.TabIndex = 54;
            this.TransferDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TransferDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TransferDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TransferDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TransferDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TransferDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TransferDGV.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.TransferDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.TransferDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TransferDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TransferDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TransferDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TransferDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.TransferDGV.ThemeStyle.ReadOnly = false;
            this.TransferDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TransferDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TransferDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TransferDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TransferDGV.ThemeStyle.RowsStyle.Height = 25;
            this.TransferDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.TransferDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Cb_HId
            // 
            this.Cb_HId.AutoRoundedCorners = true;
            this.Cb_HId.BackColor = System.Drawing.Color.Transparent;
            this.Cb_HId.BorderColor = System.Drawing.Color.Silver;
            this.Cb_HId.BorderRadius = 17;
            this.Cb_HId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cb_HId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_HId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cb_HId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cb_HId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Cb_HId.ForeColor = System.Drawing.Color.Maroon;
            this.Cb_HId.ItemHeight = 30;
            this.Cb_HId.Location = new System.Drawing.Point(395, 213);
            this.Cb_HId.Name = "Cb_HId";
            this.Cb_HId.Size = new System.Drawing.Size(133, 36);
            this.Cb_HId.TabIndex = 56;
            this.Cb_HId.SelectionChangeCommitted += new System.EventHandler(this.Cb_HId_SelectionChangeCommitted);
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.lblCinsiyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCinsiyet.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinsiyet.ForeColor = System.Drawing.Color.Black;
            this.lblCinsiyet.Location = new System.Drawing.Point(301, 213);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(98, 28);
            this.lblCinsiyet.TabIndex = 55;
            this.lblCinsiyet.Text = "Hasta Id:";
            // 
            // Txb_HAdSoyad
            // 
            this.Txb_HAdSoyad.AutoRoundedCorners = true;
            this.Txb_HAdSoyad.BorderRadius = 17;
            this.Txb_HAdSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_HAdSoyad.DefaultText = "";
            this.Txb_HAdSoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_HAdSoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_HAdSoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_HAdSoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_HAdSoyad.Enabled = false;
            this.Txb_HAdSoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_HAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_HAdSoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_HAdSoyad.Location = new System.Drawing.Point(654, 213);
            this.Txb_HAdSoyad.Name = "Txb_HAdSoyad";
            this.Txb_HAdSoyad.PasswordChar = '\0';
            this.Txb_HAdSoyad.PlaceholderText = "";
            this.Txb_HAdSoyad.SelectedText = "";
            this.Txb_HAdSoyad.Size = new System.Drawing.Size(170, 36);
            this.Txb_HAdSoyad.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(534, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 28);
            this.label10.TabIndex = 57;
            this.label10.Text = "Ad Soyad:";
            // 
            // Txb_HKGrup
            // 
            this.Txb_HKGrup.AutoRoundedCorners = true;
            this.Txb_HKGrup.BorderRadius = 17;
            this.Txb_HKGrup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_HKGrup.DefaultText = "";
            this.Txb_HKGrup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_HKGrup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_HKGrup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_HKGrup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_HKGrup.Enabled = false;
            this.Txb_HKGrup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_HKGrup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_HKGrup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_HKGrup.Location = new System.Drawing.Point(949, 213);
            this.Txb_HKGrup.Name = "Txb_HKGrup";
            this.Txb_HKGrup.PasswordChar = '\0';
            this.Txb_HKGrup.PlaceholderText = "";
            this.Txb_HKGrup.SelectedText = "";
            this.Txb_HKGrup.Size = new System.Drawing.Size(153, 36);
            this.Txb_HKGrup.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(830, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 28);
            this.label9.TabIndex = 59;
            this.label9.Text = "Kan Grup:";
            // 
            // lbluygun
            // 
            this.lbluygun.AutoSize = true;
            this.lbluygun.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluygun.ForeColor = System.Drawing.Color.Red;
            this.lbluygun.Location = new System.Drawing.Point(574, 272);
            this.lbluygun.Name = "lbluygun";
            this.lbluygun.Size = new System.Drawing.Size(218, 24);
            this.lbluygun.TabIndex = 61;
            this.lbluygun.Text = "Uygun ya da Uygun Değil";
            this.lbluygun.Visible = false;
            // 
            // Btn_TransferYap
            // 
            this.Btn_TransferYap.ActiveBorderThickness = 1;
            this.Btn_TransferYap.ActiveCornerRadius = 20;
            this.Btn_TransferYap.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_TransferYap.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.Btn_TransferYap.ActiveLineColor = System.Drawing.Color.White;
            this.Btn_TransferYap.BackColor = System.Drawing.Color.White;
            this.Btn_TransferYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_TransferYap.BackgroundImage")));
            this.Btn_TransferYap.ButtonText = "Transfer Yap";
            this.Btn_TransferYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_TransferYap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_TransferYap.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_TransferYap.IdleBorderThickness = 1;
            this.Btn_TransferYap.IdleCornerRadius = 20;
            this.Btn_TransferYap.IdleFillColor = System.Drawing.Color.Firebrick;
            this.Btn_TransferYap.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.Btn_TransferYap.IdleLineColor = System.Drawing.Color.Firebrick;
            this.Btn_TransferYap.Location = new System.Drawing.Point(577, 331);
            this.Btn_TransferYap.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_TransferYap.Name = "Btn_TransferYap";
            this.Btn_TransferYap.Size = new System.Drawing.Size(215, 48);
            this.Btn_TransferYap.TabIndex = 64;
            this.Btn_TransferYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_TransferYap.Visible = false;
            this.Btn_TransferYap.Click += new System.EventHandler(this.Btn_TransferYap_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblKanBagısı);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblCıkıs);
            this.panel2.Controls.Add(this.lblKontrol);
            this.panel2.Controls.Add(this.lblKTransferi);
            this.panel2.Controls.Add(this.lblKStogu);
            this.panel2.Controls.Add(this.lblHastaIslemleri);
            this.panel2.Controls.Add(this.lblHIslemleri);
            this.panel2.Controls.Add(this.lblDListesi);
            this.panel2.Controls.Add(this.lblDIslemleri);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 594);
            this.panel2.TabIndex = 65;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(64, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // lblKanBagısı
            // 
            this.lblKanBagısı.AutoSize = true;
            this.lblKanBagısı.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKanBagısı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKanBagısı.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKanBagısı.ForeColor = System.Drawing.Color.Black;
            this.lblKanBagısı.Location = new System.Drawing.Point(72, 230);
            this.lblKanBagısı.Name = "lblKanBagısı";
            this.lblKanBagısı.Size = new System.Drawing.Size(139, 35);
            this.lblKanBagısı.TabIndex = 49;
            this.lblKanBagısı.Text = "Kan Bağışı";
            this.lblKanBagısı.Click += new System.EventHandler(this.lblKanBagısı_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Location = new System.Drawing.Point(46, 428);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 31);
            this.panel3.TabIndex = 24;
            // 
            // lblCıkıs
            // 
            this.lblCıkıs.AutoSize = true;
            this.lblCıkıs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCıkıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCıkıs.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCıkıs.ForeColor = System.Drawing.Color.Black;
            this.lblCıkıs.Location = new System.Drawing.Point(72, 530);
            this.lblCıkıs.Name = "lblCıkıs";
            this.lblCıkıs.Size = new System.Drawing.Size(121, 35);
            this.lblCıkıs.TabIndex = 23;
            this.lblCıkıs.Text = "Çıkış Yap";
            this.lblCıkıs.Click += new System.EventHandler(this.lblCıkıs_Click);
            // 
            // lblKontrol
            // 
            this.lblKontrol.AutoSize = true;
            this.lblKontrol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKontrol.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontrol.ForeColor = System.Drawing.Color.Black;
            this.lblKontrol.Location = new System.Drawing.Point(71, 478);
            this.lblKontrol.Name = "lblKontrol";
            this.lblKontrol.Size = new System.Drawing.Size(180, 35);
            this.lblKontrol.TabIndex = 22;
            this.lblKontrol.Text = "Genel Kontrol";
            this.lblKontrol.Click += new System.EventHandler(this.lblKontrol_Click);
            // 
            // lblKTransferi
            // 
            this.lblKTransferi.AutoSize = true;
            this.lblKTransferi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKTransferi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKTransferi.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKTransferi.ForeColor = System.Drawing.Color.Black;
            this.lblKTransferi.Location = new System.Drawing.Point(70, 428);
            this.lblKTransferi.Name = "lblKTransferi";
            this.lblKTransferi.Size = new System.Drawing.Size(175, 35);
            this.lblKTransferi.TabIndex = 21;
            this.lblKTransferi.Text = "Kan Transferi";
            this.lblKTransferi.Click += new System.EventHandler(this.lblKTransferi_Click);
            // 
            // lblKStogu
            // 
            this.lblKStogu.AutoSize = true;
            this.lblKStogu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKStogu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKStogu.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKStogu.ForeColor = System.Drawing.Color.Black;
            this.lblKStogu.Location = new System.Drawing.Point(71, 383);
            this.lblKStogu.Name = "lblKStogu";
            this.lblKStogu.Size = new System.Drawing.Size(138, 35);
            this.lblKStogu.TabIndex = 20;
            this.lblKStogu.Text = "Kan Stoğu";
            this.lblKStogu.Click += new System.EventHandler(this.lblKStogu_Click);
            // 
            // lblHastaIslemleri
            // 
            this.lblHastaIslemleri.AutoSize = true;
            this.lblHastaIslemleri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHastaIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHastaIslemleri.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaIslemleri.ForeColor = System.Drawing.Color.Black;
            this.lblHastaIslemleri.Location = new System.Drawing.Point(71, 335);
            this.lblHastaIslemleri.Name = "lblHastaIslemleri";
            this.lblHastaIslemleri.Size = new System.Drawing.Size(165, 35);
            this.lblHastaIslemleri.TabIndex = 19;
            this.lblHastaIslemleri.Text = "Hasta Listesi";
            this.lblHastaIslemleri.Click += new System.EventHandler(this.lblHastaIslemleri_Click);
            // 
            // lblHIslemleri
            // 
            this.lblHIslemleri.AutoSize = true;
            this.lblHIslemleri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHIslemleri.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHIslemleri.ForeColor = System.Drawing.Color.Black;
            this.lblHIslemleri.Location = new System.Drawing.Point(71, 281);
            this.lblHIslemleri.Name = "lblHIslemleri";
            this.lblHIslemleri.Size = new System.Drawing.Size(192, 35);
            this.lblHIslemleri.TabIndex = 18;
            this.lblHIslemleri.Text = "Hasta İşlemleri";
            this.lblHIslemleri.Click += new System.EventHandler(this.lblHIslemleri_Click);
            // 
            // lblDListesi
            // 
            this.lblDListesi.AutoSize = true;
            this.lblDListesi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDListesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDListesi.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDListesi.ForeColor = System.Drawing.Color.Black;
            this.lblDListesi.Location = new System.Drawing.Point(71, 181);
            this.lblDListesi.Name = "lblDListesi";
            this.lblDListesi.Size = new System.Drawing.Size(173, 35);
            this.lblDListesi.TabIndex = 17;
            this.lblDListesi.Text = "Donör Listesi";
            this.lblDListesi.Click += new System.EventHandler(this.lblDListesi_Click);
            // 
            // lblDIslemleri
            // 
            this.lblDIslemleri.AutoSize = true;
            this.lblDIslemleri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDIslemleri.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDIslemleri.ForeColor = System.Drawing.Color.Black;
            this.lblDIslemleri.Location = new System.Drawing.Point(70, 127);
            this.lblDIslemleri.Name = "lblDIslemleri";
            this.lblDIslemleri.Size = new System.Drawing.Size(200, 35);
            this.lblDIslemleri.TabIndex = 16;
            this.lblDIslemleri.Text = "Donör İşlemleri";
            this.lblDIslemleri.Click += new System.EventHandler(this.lblDIslemleri_Click);
            // 
            // frmKanTransferi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_TransferYap);
            this.Controls.Add(this.lbluygun);
            this.Controls.Add(this.Txb_HKGrup);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txb_HAdSoyad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Cb_HId);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.TransferDGV);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKanTransferi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KanTransferi";
            this.Load += new System.EventHandler(this.frmKanTransferi_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransferDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblbaslık;
        private Guna.UI2.WinForms.Guna2DataGridView TransferDGV;
        private Guna.UI2.WinForms.Guna2ComboBox Cb_HId;
        private System.Windows.Forms.Label lblCinsiyet;
        private Guna.UI2.WinForms.Guna2TextBox Txb_HAdSoyad;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox Txb_HKGrup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbluygun;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_TransferYap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblKanBagısı;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCıkıs;
        private System.Windows.Forms.Label lblKontrol;
        private System.Windows.Forms.Label lblKTransferi;
        private System.Windows.Forms.Label lblKStogu;
        private System.Windows.Forms.Label lblHastaIslemleri;
        private System.Windows.Forms.Label lblHIslemleri;
        private System.Windows.Forms.Label lblDListesi;
        private System.Windows.Forms.Label lblDIslemleri;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}