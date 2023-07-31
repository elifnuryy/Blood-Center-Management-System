namespace KanBankasıYönetimUygulaması
{
    partial class frmKanBagısı
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKanBagısı));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.KBagısıDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKanBagısı = new System.Windows.Forms.Label();
            this.lblcıkısyap = new System.Windows.Forms.Label();
            this.lblgenelkontrol = new System.Windows.Forms.Label();
            this.lblkantransferi = new System.Windows.Forms.Label();
            this.lblkanstoğu = new System.Windows.Forms.Label();
            this.lblhastalistesi = new System.Windows.Forms.Label();
            this.lblhhastaislemleri = new System.Windows.Forms.Label();
            this.lbldonörlistesi = new System.Windows.Forms.Label();
            this.lbldonorislemleri = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblbaslık = new System.Windows.Forms.Label();
            this.Txb_KbHAdSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblKanGrup = new System.Windows.Forms.Label();
            this.Btn_KanBagısı = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Txb_KbHKanGrup = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDonorListesi = new System.Windows.Forms.Label();
            this.lblKanStogu = new System.Windows.Forms.Label();
            this.KStoguDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.KBagısıDGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KStoguDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // KBagısıDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.KBagısıDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.KBagısıDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KBagısıDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.KBagısıDGV.ColumnHeadersHeight = 30;
            this.KBagısıDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KBagısıDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.KBagısıDGV.GridColor = System.Drawing.Color.White;
            this.KBagısıDGV.Location = new System.Drawing.Point(623, 160);
            this.KBagısıDGV.Name = "KBagısıDGV";
            this.KBagısıDGV.RowHeadersVisible = false;
            this.KBagısıDGV.RowTemplate.Height = 25;
            this.KBagısıDGV.Size = new System.Drawing.Size(479, 282);
            this.KBagısıDGV.TabIndex = 7;
            this.KBagısıDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.KBagısıDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.KBagısıDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.KBagısıDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.KBagısıDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.KBagısıDGV.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KBagısıDGV.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.KBagısıDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.KBagısıDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.KBagısıDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KBagısıDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.KBagısıDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.KBagısıDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.KBagısıDGV.ThemeStyle.ReadOnly = false;
            this.KBagısıDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.KBagısıDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.KBagısıDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KBagısıDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.KBagısıDGV.ThemeStyle.RowsStyle.Height = 25;
            this.KBagısıDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.KBagısıDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.KBagısıDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DonorDGV_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblKanBagısı);
            this.panel2.Controls.Add(this.lblcıkısyap);
            this.panel2.Controls.Add(this.lblgenelkontrol);
            this.panel2.Controls.Add(this.lblkantransferi);
            this.panel2.Controls.Add(this.lblkanstoğu);
            this.panel2.Controls.Add(this.lblhastalistesi);
            this.panel2.Controls.Add(this.lblhhastaislemleri);
            this.panel2.Controls.Add(this.lbldonörlistesi);
            this.panel2.Controls.Add(this.lbldonorislemleri);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 594);
            this.panel2.TabIndex = 8;
            // 
            // lblKanBagısı
            // 
            this.lblKanBagısı.AutoSize = true;
            this.lblKanBagısı.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKanBagısı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKanBagısı.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKanBagısı.ForeColor = System.Drawing.Color.Black;
            this.lblKanBagısı.Location = new System.Drawing.Point(57, 231);
            this.lblKanBagısı.Name = "lblKanBagısı";
            this.lblKanBagısı.Size = new System.Drawing.Size(139, 35);
            this.lblKanBagısı.TabIndex = 49;
            this.lblKanBagısı.Text = "Kan Bağışı";
            this.lblKanBagısı.Click += new System.EventHandler(this.lblKanBagısı_Click);
            // 
            // lblcıkısyap
            // 
            this.lblcıkısyap.AutoSize = true;
            this.lblcıkısyap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblcıkısyap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcıkısyap.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcıkısyap.ForeColor = System.Drawing.Color.Black;
            this.lblcıkısyap.Location = new System.Drawing.Point(57, 531);
            this.lblcıkısyap.Name = "lblcıkısyap";
            this.lblcıkısyap.Size = new System.Drawing.Size(121, 35);
            this.lblcıkısyap.TabIndex = 23;
            this.lblcıkısyap.Text = "Çıkış Yap";
            this.lblcıkısyap.Click += new System.EventHandler(this.lblcıkısyap_Click);
            // 
            // lblgenelkontrol
            // 
            this.lblgenelkontrol.AutoSize = true;
            this.lblgenelkontrol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblgenelkontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblgenelkontrol.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenelkontrol.ForeColor = System.Drawing.Color.Black;
            this.lblgenelkontrol.Location = new System.Drawing.Point(56, 479);
            this.lblgenelkontrol.Name = "lblgenelkontrol";
            this.lblgenelkontrol.Size = new System.Drawing.Size(180, 35);
            this.lblgenelkontrol.TabIndex = 22;
            this.lblgenelkontrol.Text = "Genel Kontrol";
            this.lblgenelkontrol.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblkantransferi
            // 
            this.lblkantransferi.AutoSize = true;
            this.lblkantransferi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblkantransferi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblkantransferi.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkantransferi.ForeColor = System.Drawing.Color.Black;
            this.lblkantransferi.Location = new System.Drawing.Point(55, 429);
            this.lblkantransferi.Name = "lblkantransferi";
            this.lblkantransferi.Size = new System.Drawing.Size(175, 35);
            this.lblkantransferi.TabIndex = 21;
            this.lblkantransferi.Text = "Kan Transferi";
            this.lblkantransferi.Click += new System.EventHandler(this.lblkantransferi_Click);
            // 
            // lblkanstoğu
            // 
            this.lblkanstoğu.AutoSize = true;
            this.lblkanstoğu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblkanstoğu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblkanstoğu.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkanstoğu.ForeColor = System.Drawing.Color.Black;
            this.lblkanstoğu.Location = new System.Drawing.Point(56, 384);
            this.lblkanstoğu.Name = "lblkanstoğu";
            this.lblkanstoğu.Size = new System.Drawing.Size(138, 35);
            this.lblkanstoğu.TabIndex = 20;
            this.lblkanstoğu.Text = "Kan Stoğu";
            this.lblkanstoğu.Click += new System.EventHandler(this.lblkanstoğu_Click);
            // 
            // lblhastalistesi
            // 
            this.lblhastalistesi.AutoSize = true;
            this.lblhastalistesi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblhastalistesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblhastalistesi.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhastalistesi.ForeColor = System.Drawing.Color.Black;
            this.lblhastalistesi.Location = new System.Drawing.Point(56, 336);
            this.lblhastalistesi.Name = "lblhastalistesi";
            this.lblhastalistesi.Size = new System.Drawing.Size(165, 35);
            this.lblhastalistesi.TabIndex = 19;
            this.lblhastalistesi.Text = "Hasta Listesi";
            this.lblhastalistesi.Click += new System.EventHandler(this.lblhastalistesi_Click);
            // 
            // lblhhastaislemleri
            // 
            this.lblhhastaislemleri.AutoSize = true;
            this.lblhhastaislemleri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblhhastaislemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblhhastaislemleri.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhhastaislemleri.ForeColor = System.Drawing.Color.Black;
            this.lblhhastaislemleri.Location = new System.Drawing.Point(56, 282);
            this.lblhhastaislemleri.Name = "lblhhastaislemleri";
            this.lblhhastaislemleri.Size = new System.Drawing.Size(192, 35);
            this.lblhhastaislemleri.TabIndex = 18;
            this.lblhhastaislemleri.Text = "Hasta İşlemleri";
            this.lblhhastaislemleri.Click += new System.EventHandler(this.lblhhastaislemleri_Click);
            // 
            // lbldonörlistesi
            // 
            this.lbldonörlistesi.AutoSize = true;
            this.lbldonörlistesi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbldonörlistesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbldonörlistesi.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldonörlistesi.ForeColor = System.Drawing.Color.Black;
            this.lbldonörlistesi.Location = new System.Drawing.Point(56, 182);
            this.lbldonörlistesi.Name = "lbldonörlistesi";
            this.lbldonörlistesi.Size = new System.Drawing.Size(173, 35);
            this.lbldonörlistesi.TabIndex = 17;
            this.lbldonörlistesi.Text = "Donör Listesi";
            this.lbldonörlistesi.Click += new System.EventHandler(this.lbldonörlistesi_Click);
            // 
            // lbldonorislemleri
            // 
            this.lbldonorislemleri.AutoSize = true;
            this.lbldonorislemleri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbldonorislemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbldonorislemleri.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldonorislemleri.ForeColor = System.Drawing.Color.Black;
            this.lbldonorislemleri.Location = new System.Drawing.Point(55, 128);
            this.lbldonorislemleri.Name = "lbldonorislemleri";
            this.lbldonorislemleri.Size = new System.Drawing.Size(200, 35);
            this.lbldonorislemleri.TabIndex = 16;
            this.lbldonorislemleri.Text = "Donör İşlemleri";
            this.lbldonorislemleri.Click += new System.EventHandler(this.lbldonorislemleri_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Controls.Add(this.lblbaslık);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(288, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(826, 82);
            this.panel4.TabIndex = 43;
            // 
            // lblbaslık
            // 
            this.lblbaslık.AutoSize = true;
            this.lblbaslık.BackColor = System.Drawing.Color.Transparent;
            this.lblbaslık.Font = new System.Drawing.Font("Poor Richard", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaslık.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblbaslık.Location = new System.Drawing.Point(119, 20);
            this.lblbaslık.Name = "lblbaslık";
            this.lblbaslık.Size = new System.Drawing.Size(571, 45);
            this.lblbaslık.TabIndex = 15;
            this.lblbaslık.Text = "KAN BANKASI YÖNETİM SİSTEMİ";
            // 
            // Txb_KbHAdSoyad
            // 
            this.Txb_KbHAdSoyad.AutoRoundedCorners = true;
            this.Txb_KbHAdSoyad.BorderRadius = 17;
            this.Txb_KbHAdSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_KbHAdSoyad.DefaultText = "";
            this.Txb_KbHAdSoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_KbHAdSoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_KbHAdSoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_KbHAdSoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_KbHAdSoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_KbHAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_KbHAdSoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_KbHAdSoyad.Location = new System.Drawing.Point(471, 495);
            this.Txb_KbHAdSoyad.Name = "Txb_KbHAdSoyad";
            this.Txb_KbHAdSoyad.PasswordChar = '\0';
            this.Txb_KbHAdSoyad.PlaceholderText = "";
            this.Txb_KbHAdSoyad.SelectedText = "";
            this.Txb_KbHAdSoyad.Size = new System.Drawing.Size(200, 36);
            this.Txb_KbHAdSoyad.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(351, 495);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 28);
            this.label10.TabIndex = 45;
            this.label10.Text = "Ad Soyad:";
            // 
            // lblKanGrup
            // 
            this.lblKanGrup.AutoSize = true;
            this.lblKanGrup.BackColor = System.Drawing.Color.Transparent;
            this.lblKanGrup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKanGrup.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKanGrup.ForeColor = System.Drawing.Color.Black;
            this.lblKanGrup.Location = new System.Drawing.Point(745, 495);
            this.lblKanGrup.Name = "lblKanGrup";
            this.lblKanGrup.Size = new System.Drawing.Size(113, 28);
            this.lblKanGrup.TabIndex = 47;
            this.lblKanGrup.Text = "Kan Grup:";
            // 
            // Btn_KanBagısı
            // 
            this.Btn_KanBagısı.ActiveBorderThickness = 1;
            this.Btn_KanBagısı.ActiveCornerRadius = 20;
            this.Btn_KanBagısı.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_KanBagısı.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.Btn_KanBagısı.ActiveLineColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_KanBagısı.BackColor = System.Drawing.Color.White;
            this.Btn_KanBagısı.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_KanBagısı.BackgroundImage")));
            this.Btn_KanBagısı.ButtonText = "Kan Bağışı";
            this.Btn_KanBagısı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_KanBagısı.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_KanBagısı.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_KanBagısı.IdleBorderThickness = 1;
            this.Btn_KanBagısı.IdleCornerRadius = 20;
            this.Btn_KanBagısı.IdleFillColor = System.Drawing.Color.Firebrick;
            this.Btn_KanBagısı.IdleForecolor = System.Drawing.Color.White;
            this.Btn_KanBagısı.IdleLineColor = System.Drawing.Color.Firebrick;
            this.Btn_KanBagısı.Location = new System.Drawing.Point(574, 541);
            this.Btn_KanBagısı.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_KanBagısı.Name = "Btn_KanBagısı";
            this.Btn_KanBagısı.Size = new System.Drawing.Size(244, 38);
            this.Btn_KanBagısı.TabIndex = 49;
            this.Btn_KanBagısı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_KanBagısı.Click += new System.EventHandler(this.Btn_KanBagısı_Click);
            // 
            // Txb_KbHKanGrup
            // 
            this.Txb_KbHKanGrup.AutoRoundedCorners = true;
            this.Txb_KbHKanGrup.BorderRadius = 17;
            this.Txb_KbHKanGrup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_KbHKanGrup.DefaultText = "";
            this.Txb_KbHKanGrup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_KbHKanGrup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_KbHKanGrup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_KbHKanGrup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_KbHKanGrup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_KbHKanGrup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_KbHKanGrup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_KbHKanGrup.Location = new System.Drawing.Point(864, 495);
            this.Txb_KbHKanGrup.Name = "Txb_KbHKanGrup";
            this.Txb_KbHKanGrup.PasswordChar = '\0';
            this.Txb_KbHKanGrup.PlaceholderText = "";
            this.Txb_KbHKanGrup.SelectedText = "";
            this.Txb_KbHKanGrup.Size = new System.Drawing.Size(200, 36);
            this.Txb_KbHKanGrup.TabIndex = 50;
            // 
            // lblDonorListesi
            // 
            this.lblDonorListesi.AutoSize = true;
            this.lblDonorListesi.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorListesi.Location = new System.Drawing.Point(784, 126);
            this.lblDonorListesi.Name = "lblDonorListesi";
            this.lblDonorListesi.Size = new System.Drawing.Size(161, 31);
            this.lblDonorListesi.TabIndex = 51;
            this.lblDonorListesi.Text = "Donör Listesi";
            // 
            // lblKanStogu
            // 
            this.lblKanStogu.AutoSize = true;
            this.lblKanStogu.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKanStogu.Location = new System.Drawing.Point(373, 126);
            this.lblKanStogu.Name = "lblKanStogu";
            this.lblKanStogu.Size = new System.Drawing.Size(132, 31);
            this.lblKanStogu.TabIndex = 53;
            this.lblKanStogu.Text = "Kan Stoğu";
            this.lblKanStogu.Click += new System.EventHandler(this.label9_Click);
            // 
            // KStoguDGV
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.KStoguDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.KStoguDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KStoguDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.KStoguDGV.ColumnHeadersHeight = 30;
            this.KStoguDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KStoguDGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.KStoguDGV.GridColor = System.Drawing.Color.White;
            this.KStoguDGV.Location = new System.Drawing.Point(304, 161);
            this.KStoguDGV.Name = "KStoguDGV";
            this.KStoguDGV.RowHeadersVisible = false;
            this.KStoguDGV.RowTemplate.Height = 25;
            this.KStoguDGV.Size = new System.Drawing.Size(278, 281);
            this.KStoguDGV.TabIndex = 52;
            this.KStoguDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.KStoguDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.KStoguDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.KStoguDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.KStoguDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.KStoguDGV.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KStoguDGV.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.KStoguDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.KStoguDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.KStoguDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KStoguDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.KStoguDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.KStoguDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.KStoguDGV.ThemeStyle.ReadOnly = false;
            this.KStoguDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.KStoguDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.KStoguDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KStoguDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.KStoguDGV.ThemeStyle.RowsStyle.Height = 25;
            this.KStoguDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.KStoguDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Location = new System.Drawing.Point(44, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 31);
            this.panel3.TabIndex = 50;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // frmKanBagısı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 594);
            this.Controls.Add(this.lblKanStogu);
            this.Controls.Add(this.KStoguDGV);
            this.Controls.Add(this.lblDonorListesi);
            this.Controls.Add(this.Txb_KbHKanGrup);
            this.Controls.Add(this.Btn_KanBagısı);
            this.Controls.Add(this.lblKanGrup);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txb_KbHAdSoyad);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.KBagısıDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKanBagısı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KanBagısı";
            this.Load += new System.EventHandler(this.frmKanBagısı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KBagısıDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KStoguDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView KBagısıDGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblcıkısyap;
        private System.Windows.Forms.Label lblgenelkontrol;
        private System.Windows.Forms.Label lblkantransferi;
        private System.Windows.Forms.Label lblkanstoğu;
        private System.Windows.Forms.Label lblhastalistesi;
        private System.Windows.Forms.Label lblhhastaislemleri;
        private System.Windows.Forms.Label lbldonörlistesi;
        private System.Windows.Forms.Label lbldonorislemleri;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblbaslık;
        private Guna.UI2.WinForms.Guna2TextBox Txb_KbHAdSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblKanBagısı;
        private System.Windows.Forms.Label lblKanGrup;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_KanBagısı;
        private Guna.UI2.WinForms.Guna2TextBox Txb_KbHKanGrup;
        private System.Windows.Forms.Label lblDonorListesi;
        private System.Windows.Forms.Label lblKanStogu;
        private Guna.UI2.WinForms.Guna2DataGridView KStoguDGV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}