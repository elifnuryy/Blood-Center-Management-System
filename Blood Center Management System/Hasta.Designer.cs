namespace KanBankasıYönetimUygulaması
{
    partial class frmHasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHasta));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKanBagısı = new System.Windows.Forms.Label();
            this.lblcıkısyap = new System.Windows.Forms.Label();
            this.lblgenelkontrol = new System.Windows.Forms.Label();
            this.lblKanTransferi = new System.Windows.Forms.Label();
            this.lblkanstogu = new System.Windows.Forms.Label();
            this.lblhastalistesi = new System.Windows.Forms.Label();
            this.lblhastaislemleri = new System.Windows.Forms.Label();
            this.lbldonorlistesi = new System.Windows.Forms.Label();
            this.lblDonorislemleri = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_HastaEkle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Cb_HKanGrup = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Cb_HCinsiyet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Txb_HAdres = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txb_HTelefon = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txb_HYas = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txb_HAdSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblbaslık = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.lblKanBagısı);
            this.panel2.Controls.Add(this.lblcıkısyap);
            this.panel2.Controls.Add(this.lblgenelkontrol);
            this.panel2.Controls.Add(this.lblKanTransferi);
            this.panel2.Controls.Add(this.lblkanstogu);
            this.panel2.Controls.Add(this.lblhastalistesi);
            this.panel2.Controls.Add(this.lblhastaislemleri);
            this.panel2.Controls.Add(this.lbldonorlistesi);
            this.panel2.Controls.Add(this.lblDonorislemleri);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 594);
            this.panel2.TabIndex = 2;
            // 
            // lblKanBagısı
            // 
            this.lblKanBagısı.AutoSize = true;
            this.lblKanBagısı.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKanBagısı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKanBagısı.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKanBagısı.ForeColor = System.Drawing.Color.Black;
            this.lblKanBagısı.Location = new System.Drawing.Point(65, 230);
            this.lblKanBagısı.Name = "lblKanBagısı";
            this.lblKanBagısı.Size = new System.Drawing.Size(139, 35);
            this.lblKanBagısı.TabIndex = 58;
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
            this.lblcıkısyap.Location = new System.Drawing.Point(65, 530);
            this.lblcıkısyap.Name = "lblcıkısyap";
            this.lblcıkısyap.Size = new System.Drawing.Size(121, 35);
            this.lblcıkısyap.TabIndex = 57;
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
            this.lblgenelkontrol.Location = new System.Drawing.Point(64, 478);
            this.lblgenelkontrol.Name = "lblgenelkontrol";
            this.lblgenelkontrol.Size = new System.Drawing.Size(180, 35);
            this.lblgenelkontrol.TabIndex = 56;
            this.lblgenelkontrol.Text = "Genel Kontrol";
            this.lblgenelkontrol.Click += new System.EventHandler(this.lblgenelkontrol_Click);
            // 
            // lblKanTransferi
            // 
            this.lblKanTransferi.AutoSize = true;
            this.lblKanTransferi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKanTransferi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKanTransferi.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKanTransferi.ForeColor = System.Drawing.Color.Black;
            this.lblKanTransferi.Location = new System.Drawing.Point(63, 428);
            this.lblKanTransferi.Name = "lblKanTransferi";
            this.lblKanTransferi.Size = new System.Drawing.Size(175, 35);
            this.lblKanTransferi.TabIndex = 55;
            this.lblKanTransferi.Text = "Kan Transferi";
            this.lblKanTransferi.Click += new System.EventHandler(this.lblKanTransferi_Click);
            // 
            // lblkanstogu
            // 
            this.lblkanstogu.AutoSize = true;
            this.lblkanstogu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblkanstogu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblkanstogu.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkanstogu.ForeColor = System.Drawing.Color.Black;
            this.lblkanstogu.Location = new System.Drawing.Point(64, 383);
            this.lblkanstogu.Name = "lblkanstogu";
            this.lblkanstogu.Size = new System.Drawing.Size(138, 35);
            this.lblkanstogu.TabIndex = 54;
            this.lblkanstogu.Text = "Kan Stoğu";
            this.lblkanstogu.Click += new System.EventHandler(this.lblkanstogu_Click);
            // 
            // lblhastalistesi
            // 
            this.lblhastalistesi.AutoSize = true;
            this.lblhastalistesi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblhastalistesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblhastalistesi.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhastalistesi.ForeColor = System.Drawing.Color.Black;
            this.lblhastalistesi.Location = new System.Drawing.Point(64, 335);
            this.lblhastalistesi.Name = "lblhastalistesi";
            this.lblhastalistesi.Size = new System.Drawing.Size(165, 35);
            this.lblhastalistesi.TabIndex = 53;
            this.lblhastalistesi.Text = "Hasta Listesi";
            this.lblhastalistesi.Click += new System.EventHandler(this.lblhastalistesi_Click_1);
            // 
            // lblhastaislemleri
            // 
            this.lblhastaislemleri.AutoSize = true;
            this.lblhastaislemleri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblhastaislemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblhastaislemleri.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhastaislemleri.ForeColor = System.Drawing.Color.Black;
            this.lblhastaislemleri.Location = new System.Drawing.Point(64, 281);
            this.lblhastaislemleri.Name = "lblhastaislemleri";
            this.lblhastaislemleri.Size = new System.Drawing.Size(192, 35);
            this.lblhastaislemleri.TabIndex = 52;
            this.lblhastaislemleri.Text = "Hasta İşlemleri";
            this.lblhastaislemleri.Click += new System.EventHandler(this.lblhastaislemleri_Click);
            // 
            // lbldonorlistesi
            // 
            this.lbldonorlistesi.AutoSize = true;
            this.lbldonorlistesi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbldonorlistesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbldonorlistesi.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldonorlistesi.ForeColor = System.Drawing.Color.Black;
            this.lbldonorlistesi.Location = new System.Drawing.Point(64, 181);
            this.lbldonorlistesi.Name = "lbldonorlistesi";
            this.lbldonorlistesi.Size = new System.Drawing.Size(173, 35);
            this.lbldonorlistesi.TabIndex = 51;
            this.lbldonorlistesi.Text = "Donör Listesi";
            this.lbldonorlistesi.Click += new System.EventHandler(this.lbldonorlistesi_Click);
            // 
            // lblDonorislemleri
            // 
            this.lblDonorislemleri.AutoSize = true;
            this.lblDonorislemleri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDonorislemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDonorislemleri.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorislemleri.ForeColor = System.Drawing.Color.Black;
            this.lblDonorislemleri.Location = new System.Drawing.Point(63, 127);
            this.lblDonorislemleri.Name = "lblDonorislemleri";
            this.lblDonorislemleri.Size = new System.Drawing.Size(200, 35);
            this.lblDonorislemleri.TabIndex = 50;
            this.lblDonorislemleri.Text = "Donör İşlemleri";
            this.lblDonorislemleri.Click += new System.EventHandler(this.lblDonorislemleri_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Location = new System.Drawing.Point(40, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 31);
            this.panel3.TabIndex = 24;
            // 
            // Btn_HastaEkle
            // 
            this.Btn_HastaEkle.ActiveBorderThickness = 1;
            this.Btn_HastaEkle.ActiveCornerRadius = 20;
            this.Btn_HastaEkle.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_HastaEkle.ActiveForecolor = System.Drawing.Color.Firebrick;
            this.Btn_HastaEkle.ActiveLineColor = System.Drawing.Color.Firebrick;
            this.Btn_HastaEkle.BackColor = System.Drawing.Color.White;
            this.Btn_HastaEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_HastaEkle.BackgroundImage")));
            this.Btn_HastaEkle.ButtonText = "Hasta Ekle";
            this.Btn_HastaEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_HastaEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_HastaEkle.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_HastaEkle.IdleBorderThickness = 1;
            this.Btn_HastaEkle.IdleCornerRadius = 20;
            this.Btn_HastaEkle.IdleFillColor = System.Drawing.Color.Firebrick;
            this.Btn_HastaEkle.IdleForecolor = System.Drawing.Color.White;
            this.Btn_HastaEkle.IdleLineColor = System.Drawing.Color.Firebrick;
            this.Btn_HastaEkle.Location = new System.Drawing.Point(453, 541);
            this.Btn_HastaEkle.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_HastaEkle.Name = "Btn_HastaEkle";
            this.Btn_HastaEkle.Size = new System.Drawing.Size(244, 38);
            this.Btn_HastaEkle.TabIndex = 54;
            this.Btn_HastaEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_HastaEkle.Click += new System.EventHandler(this.Btn_HastaEkle_Click);
            // 
            // Cb_HKanGrup
            // 
            this.Cb_HKanGrup.AutoRoundedCorners = true;
            this.Cb_HKanGrup.BackColor = System.Drawing.Color.Transparent;
            this.Cb_HKanGrup.BorderColor = System.Drawing.Color.Silver;
            this.Cb_HKanGrup.BorderRadius = 17;
            this.Cb_HKanGrup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cb_HKanGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_HKanGrup.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cb_HKanGrup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cb_HKanGrup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Cb_HKanGrup.ForeColor = System.Drawing.Color.Maroon;
            this.Cb_HKanGrup.ItemHeight = 30;
            this.Cb_HKanGrup.Items.AddRange(new object[] {
            "A+",
            "B+",
            "0+",
            "AB+",
            "A-",
            "B-",
            "0-",
            "AB-"});
            this.Cb_HKanGrup.Location = new System.Drawing.Point(475, 360);
            this.Cb_HKanGrup.Name = "Cb_HKanGrup";
            this.Cb_HKanGrup.Size = new System.Drawing.Size(200, 36);
            this.Cb_HKanGrup.TabIndex = 53;
            // 
            // Cb_HCinsiyet
            // 
            this.Cb_HCinsiyet.AutoRoundedCorners = true;
            this.Cb_HCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.Cb_HCinsiyet.BorderColor = System.Drawing.Color.Silver;
            this.Cb_HCinsiyet.BorderRadius = 17;
            this.Cb_HCinsiyet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cb_HCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_HCinsiyet.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cb_HCinsiyet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cb_HCinsiyet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Cb_HCinsiyet.ForeColor = System.Drawing.Color.Maroon;
            this.Cb_HCinsiyet.ItemHeight = 30;
            this.Cb_HCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.Cb_HCinsiyet.Location = new System.Drawing.Point(475, 298);
            this.Cb_HCinsiyet.Name = "Cb_HCinsiyet";
            this.Cb_HCinsiyet.Size = new System.Drawing.Size(200, 36);
            this.Cb_HCinsiyet.TabIndex = 52;
            // 
            // Txb_HAdres
            // 
            this.Txb_HAdres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_HAdres.DefaultText = "";
            this.Txb_HAdres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_HAdres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_HAdres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_HAdres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_HAdres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_HAdres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_HAdres.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_HAdres.Location = new System.Drawing.Point(475, 419);
            this.Txb_HAdres.Name = "Txb_HAdres";
            this.Txb_HAdres.PasswordChar = '\0';
            this.Txb_HAdres.PlaceholderText = "";
            this.Txb_HAdres.SelectedText = "";
            this.Txb_HAdres.Size = new System.Drawing.Size(200, 107);
            this.Txb_HAdres.TabIndex = 51;
            // 
            // Txb_HTelefon
            // 
            this.Txb_HTelefon.AutoRoundedCorners = true;
            this.Txb_HTelefon.BorderRadius = 17;
            this.Txb_HTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_HTelefon.DefaultText = "";
            this.Txb_HTelefon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_HTelefon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_HTelefon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_HTelefon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_HTelefon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_HTelefon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_HTelefon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_HTelefon.Location = new System.Drawing.Point(475, 236);
            this.Txb_HTelefon.Name = "Txb_HTelefon";
            this.Txb_HTelefon.PasswordChar = '\0';
            this.Txb_HTelefon.PlaceholderText = "";
            this.Txb_HTelefon.SelectedText = "";
            this.Txb_HTelefon.Size = new System.Drawing.Size(200, 36);
            this.Txb_HTelefon.TabIndex = 50;
            // 
            // Txb_HYas
            // 
            this.Txb_HYas.AutoRoundedCorners = true;
            this.Txb_HYas.BorderRadius = 17;
            this.Txb_HYas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_HYas.DefaultText = "";
            this.Txb_HYas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_HYas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_HYas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_HYas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_HYas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_HYas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_HYas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_HYas.Location = new System.Drawing.Point(475, 181);
            this.Txb_HYas.Name = "Txb_HYas";
            this.Txb_HYas.PasswordChar = '\0';
            this.Txb_HYas.PlaceholderText = "";
            this.Txb_HYas.SelectedText = "";
            this.Txb_HYas.Size = new System.Drawing.Size(200, 36);
            this.Txb_HYas.TabIndex = 49;
            this.Txb_HYas.TextChanged += new System.EventHandler(this.Txb_HYas_TextChanged);
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
            this.Txb_HAdSoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_HAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_HAdSoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_HAdSoyad.Location = new System.Drawing.Point(475, 122);
            this.Txb_HAdSoyad.Name = "Txb_HAdSoyad";
            this.Txb_HAdSoyad.PasswordChar = '\0';
            this.Txb_HAdSoyad.PlaceholderText = "";
            this.Txb_HAdSoyad.SelectedText = "";
            this.Txb_HAdSoyad.Size = new System.Drawing.Size(200, 36);
            this.Txb_HAdSoyad.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(383, 419);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 28);
            this.label14.TabIndex = 47;
            this.label14.Text = "Adres:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(324, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 28);
            this.label13.TabIndex = 46;
            this.label13.Text = "Kan Grubu:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(355, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 28);
            this.label12.TabIndex = 45;
            this.label12.Text = "Cinsiyet:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(366, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 28);
            this.label11.TabIndex = 44;
            this.label11.Text = "Telefon:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(405, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 28);
            this.label9.TabIndex = 43;
            this.label9.Text = "Yaş:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(339, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 28);
            this.label10.TabIndex = 42;
            this.label10.Text = "Ad Soyad:";
            // 
            // lblbaslık
            // 
            this.lblbaslık.AutoSize = true;
            this.lblbaslık.BackColor = System.Drawing.Color.Transparent;
            this.lblbaslık.Font = new System.Drawing.Font("Poor Richard", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaslık.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblbaslık.Location = new System.Drawing.Point(123, 20);
            this.lblbaslık.Name = "lblbaslık";
            this.lblbaslık.Size = new System.Drawing.Size(571, 45);
            this.lblbaslık.TabIndex = 15;
            this.lblbaslık.Text = "KAN BANKASI YÖNETİM SİSTEMİ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Controls.Add(this.lblbaslık);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(288, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(826, 82);
            this.panel4.TabIndex = 41;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(64, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(199, 105);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 61;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(722, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // frmHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 594);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_HastaEkle);
            this.Controls.Add(this.Cb_HKanGrup);
            this.Controls.Add(this.Cb_HCinsiyet);
            this.Controls.Add(this.Txb_HAdres);
            this.Controls.Add(this.Txb_HTelefon);
            this.Controls.Add(this.Txb_HYas);
            this.Controls.Add(this.Txb_HAdSoyad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta";
            this.Load += new System.EventHandler(this.Hasta_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_HastaEkle;
        private Guna.UI2.WinForms.Guna2ComboBox Cb_HKanGrup;
        private Guna.UI2.WinForms.Guna2ComboBox Cb_HCinsiyet;
        private Guna.UI2.WinForms.Guna2TextBox Txb_HAdres;
        private Guna.UI2.WinForms.Guna2TextBox Txb_HTelefon;
        private Guna.UI2.WinForms.Guna2TextBox Txb_HYas;
        private Guna.UI2.WinForms.Guna2TextBox Txb_HAdSoyad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblbaslık;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblKanBagısı;
        private System.Windows.Forms.Label lblcıkısyap;
        private System.Windows.Forms.Label lblgenelkontrol;
        private System.Windows.Forms.Label lblKanTransferi;
        private System.Windows.Forms.Label lblkanstogu;
        private System.Windows.Forms.Label lblhastalistesi;
        private System.Windows.Forms.Label lblhastaislemleri;
        private System.Windows.Forms.Label lbldonorlistesi;
        private System.Windows.Forms.Label lblDonorislemleri;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}