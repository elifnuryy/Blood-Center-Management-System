namespace KanBankasıYönetimUygulaması
{
    partial class frmHastaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaListesi));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKanBagısı = new System.Windows.Forms.Label();
            this.lblcıkısyap = new System.Windows.Forms.Label();
            this.lblgenelkontrol = new System.Windows.Forms.Label();
            this.lblkantransferi = new System.Windows.Forms.Label();
            this.lblkanstogu = new System.Windows.Forms.Label();
            this.lblhastalistesi = new System.Windows.Forms.Label();
            this.lblhastaislemleri = new System.Windows.Forms.Label();
            this.lbldonorlistesi = new System.Windows.Forms.Label();
            this.lbldonorislemleri = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblbaslık = new System.Windows.Forms.Label();
            this.HastaDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Txb_HYas = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txb_HAdSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Cb_HKanGrup = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Txb_HAdres = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txb_HTelefon = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_HSil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Cb_HCinsiyet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblKanBagısı);
            this.panel2.Controls.Add(this.lblcıkısyap);
            this.panel2.Controls.Add(this.lblgenelkontrol);
            this.panel2.Controls.Add(this.lblkantransferi);
            this.panel2.Controls.Add(this.lblkanstogu);
            this.panel2.Controls.Add(this.lblhastalistesi);
            this.panel2.Controls.Add(this.lblhastaislemleri);
            this.panel2.Controls.Add(this.lbldonorlistesi);
            this.panel2.Controls.Add(this.lbldonorislemleri);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 594);
            this.panel2.TabIndex = 4;
            // 
            // lblKanBagısı
            // 
            this.lblKanBagısı.AutoSize = true;
            this.lblKanBagısı.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKanBagısı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKanBagısı.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKanBagısı.ForeColor = System.Drawing.Color.Black;
            this.lblKanBagısı.Location = new System.Drawing.Point(78, 239);
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
            this.lblcıkısyap.Location = new System.Drawing.Point(78, 539);
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
            this.lblgenelkontrol.Location = new System.Drawing.Point(77, 487);
            this.lblgenelkontrol.Name = "lblgenelkontrol";
            this.lblgenelkontrol.Size = new System.Drawing.Size(180, 35);
            this.lblgenelkontrol.TabIndex = 56;
            this.lblgenelkontrol.Text = "Genel Kontrol";
            this.lblgenelkontrol.Click += new System.EventHandler(this.lblgenelkontrol_Click);
            // 
            // lblkantransferi
            // 
            this.lblkantransferi.AutoSize = true;
            this.lblkantransferi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblkantransferi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblkantransferi.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkantransferi.ForeColor = System.Drawing.Color.Black;
            this.lblkantransferi.Location = new System.Drawing.Point(76, 437);
            this.lblkantransferi.Name = "lblkantransferi";
            this.lblkantransferi.Size = new System.Drawing.Size(175, 35);
            this.lblkantransferi.TabIndex = 55;
            this.lblkantransferi.Text = "Kan Transferi";
            this.lblkantransferi.Click += new System.EventHandler(this.lblkantransferi_Click);
            // 
            // lblkanstogu
            // 
            this.lblkanstogu.AutoSize = true;
            this.lblkanstogu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblkanstogu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblkanstogu.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkanstogu.ForeColor = System.Drawing.Color.Black;
            this.lblkanstogu.Location = new System.Drawing.Point(77, 392);
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
            this.lblhastalistesi.Location = new System.Drawing.Point(77, 344);
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
            this.lblhastaislemleri.Location = new System.Drawing.Point(77, 290);
            this.lblhastaislemleri.Name = "lblhastaislemleri";
            this.lblhastaislemleri.Size = new System.Drawing.Size(192, 35);
            this.lblhastaislemleri.TabIndex = 52;
            this.lblhastaislemleri.Text = "Hasta İşlemleri";
            this.lblhastaislemleri.Click += new System.EventHandler(this.lblhastaislemleri_Click_1);
            // 
            // lbldonorlistesi
            // 
            this.lbldonorlistesi.AutoSize = true;
            this.lbldonorlistesi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbldonorlistesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbldonorlistesi.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldonorlistesi.ForeColor = System.Drawing.Color.Black;
            this.lbldonorlistesi.Location = new System.Drawing.Point(77, 190);
            this.lbldonorlistesi.Name = "lbldonorlistesi";
            this.lbldonorlistesi.Size = new System.Drawing.Size(173, 35);
            this.lbldonorlistesi.TabIndex = 51;
            this.lbldonorlistesi.Text = "Donör Listesi";
            this.lbldonorlistesi.Click += new System.EventHandler(this.lbldonorlistesi_Click);
            // 
            // lbldonorislemleri
            // 
            this.lbldonorislemleri.AutoSize = true;
            this.lbldonorislemleri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbldonorislemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbldonorislemleri.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldonorislemleri.ForeColor = System.Drawing.Color.Black;
            this.lbldonorislemleri.Location = new System.Drawing.Point(76, 136);
            this.lbldonorislemleri.Name = "lbldonorislemleri";
            this.lbldonorislemleri.Size = new System.Drawing.Size(200, 35);
            this.lbldonorislemleri.TabIndex = 50;
            this.lbldonorislemleri.Text = "Donör İşlemleri";
            this.lbldonorislemleri.Click += new System.EventHandler(this.lbldonorislemleri_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Location = new System.Drawing.Point(53, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 31);
            this.panel3.TabIndex = 24;
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
            this.lblbaslık.Location = new System.Drawing.Point(103, 21);
            this.lblbaslık.Name = "lblbaslık";
            this.lblbaslık.Size = new System.Drawing.Size(571, 45);
            this.lblbaslık.TabIndex = 15;
            this.lblbaslık.Text = "KAN BANKASI YÖNETİM SİSTEMİ";
            // 
            // HastaDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.HastaDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HastaDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.HastaDGV.ColumnHeadersHeight = 4;
            this.HastaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HastaDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.HastaDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HastaDGV.Location = new System.Drawing.Point(294, 328);
            this.HastaDGV.Name = "HastaDGV";
            this.HastaDGV.RowHeadersVisible = false;
            this.HastaDGV.RowTemplate.Height = 24;
            this.HastaDGV.Size = new System.Drawing.Size(808, 254);
            this.HastaDGV.TabIndex = 44;
            this.HastaDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.HastaDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.HastaDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.HastaDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.HastaDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.HastaDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.HastaDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HastaDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.HastaDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.HastaDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HastaDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.HastaDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.HastaDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.HastaDGV.ThemeStyle.ReadOnly = false;
            this.HastaDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.HastaDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.HastaDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HastaDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.HastaDGV.ThemeStyle.RowsStyle.Height = 24;
            this.HastaDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HastaDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.HastaDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HastaDGV_CellContentClick);
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
            this.Txb_HYas.Location = new System.Drawing.Point(443, 157);
            this.Txb_HYas.Name = "Txb_HYas";
            this.Txb_HYas.PasswordChar = '\0';
            this.Txb_HYas.PlaceholderText = "";
            this.Txb_HYas.SelectedText = "";
            this.Txb_HYas.Size = new System.Drawing.Size(198, 36);
            this.Txb_HYas.TabIndex = 53;
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
            this.Txb_HAdSoyad.Location = new System.Drawing.Point(443, 98);
            this.Txb_HAdSoyad.Name = "Txb_HAdSoyad";
            this.Txb_HAdSoyad.PasswordChar = '\0';
            this.Txb_HAdSoyad.PlaceholderText = "";
            this.Txb_HAdSoyad.SelectedText = "";
            this.Txb_HAdSoyad.Size = new System.Drawing.Size(198, 36);
            this.Txb_HAdSoyad.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(373, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 28);
            this.label9.TabIndex = 51;
            this.label9.Text = "Yaş:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(307, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 28);
            this.label10.TabIndex = 50;
            this.label10.Text = "Ad Soyad:";
            // 
            // Cb_HKanGrup
            // 
            this.Cb_HKanGrup.AutoRoundedCorners = true;
            this.Cb_HKanGrup.BackColor = System.Drawing.Color.Transparent;
            this.Cb_HKanGrup.BorderRadius = 17;
            this.Cb_HKanGrup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cb_HKanGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_HKanGrup.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cb_HKanGrup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cb_HKanGrup.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.Cb_HKanGrup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
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
            this.Cb_HKanGrup.Location = new System.Drawing.Point(803, 106);
            this.Cb_HKanGrup.Name = "Cb_HKanGrup";
            this.Cb_HKanGrup.Size = new System.Drawing.Size(200, 36);
            this.Cb_HKanGrup.TabIndex = 61;
            this.Cb_HKanGrup.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
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
            this.Txb_HAdres.Location = new System.Drawing.Point(803, 157);
            this.Txb_HAdres.Name = "Txb_HAdres";
            this.Txb_HAdres.PasswordChar = '\0';
            this.Txb_HAdres.PlaceholderText = "";
            this.Txb_HAdres.SelectedText = "";
            this.Txb_HAdres.Size = new System.Drawing.Size(200, 103);
            this.Txb_HAdres.TabIndex = 59;
            // 
            // Txb_HTelefon
            // 
            this.Txb_HTelefon.AutoRoundedCorners = true;
            this.Txb_HTelefon.BorderRadius = 15;
            this.Txb_HTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txb_HTelefon.DefaultText = "";
            this.Txb_HTelefon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txb_HTelefon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txb_HTelefon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_HTelefon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txb_HTelefon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_HTelefon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txb_HTelefon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txb_HTelefon.Location = new System.Drawing.Point(441, 216);
            this.Txb_HTelefon.Name = "Txb_HTelefon";
            this.Txb_HTelefon.PasswordChar = '\0';
            this.Txb_HTelefon.PlaceholderText = "";
            this.Txb_HTelefon.SelectedText = "";
            this.Txb_HTelefon.Size = new System.Drawing.Size(200, 32);
            this.Txb_HTelefon.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(671, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 28);
            this.label14.TabIndex = 57;
            this.label14.Text = "Adres:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(671, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 28);
            this.label13.TabIndex = 56;
            this.label13.Text = "Kan Grubu:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(321, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 28);
            this.label12.TabIndex = 55;
            this.label12.Text = "Cinsiyet:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(332, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 28);
            this.label11.TabIndex = 54;
            this.label11.Text = "Telefon:";
            // 
            // Btn_HSil
            // 
            this.Btn_HSil.ActiveBorderThickness = 1;
            this.Btn_HSil.ActiveCornerRadius = 20;
            this.Btn_HSil.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_HSil.ActiveForecolor = System.Drawing.Color.DarkRed;
            this.Btn_HSil.ActiveLineColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_HSil.BackColor = System.Drawing.Color.White;
            this.Btn_HSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_HSil.BackgroundImage")));
            this.Btn_HSil.ButtonText = "Sil";
            this.Btn_HSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_HSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_HSil.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_HSil.IdleBorderThickness = 1;
            this.Btn_HSil.IdleCornerRadius = 20;
            this.Btn_HSil.IdleFillColor = System.Drawing.Color.Firebrick;
            this.Btn_HSil.IdleForecolor = System.Drawing.Color.White;
            this.Btn_HSil.IdleLineColor = System.Drawing.Color.Firebrick;
            this.Btn_HSil.Location = new System.Drawing.Point(826, 271);
            this.Btn_HSil.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_HSil.Name = "Btn_HSil";
            this.Btn_HSil.Size = new System.Drawing.Size(158, 48);
            this.Btn_HSil.TabIndex = 63;
            this.Btn_HSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_HSil.Click += new System.EventHandler(this.Btn_HSil_Click);
            // 
            // Cb_HCinsiyet
            // 
            this.Cb_HCinsiyet.AutoRoundedCorners = true;
            this.Cb_HCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.Cb_HCinsiyet.BorderRadius = 17;
            this.Cb_HCinsiyet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cb_HCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_HCinsiyet.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cb_HCinsiyet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cb_HCinsiyet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cb_HCinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Cb_HCinsiyet.ItemHeight = 30;
            this.Cb_HCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.Cb_HCinsiyet.Location = new System.Drawing.Point(443, 265);
            this.Cb_HCinsiyet.Name = "Cb_HCinsiyet";
            this.Cb_HCinsiyet.Size = new System.Drawing.Size(198, 36);
            this.Cb_HCinsiyet.TabIndex = 64;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // frmHastaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 594);
            this.Controls.Add(this.Cb_HCinsiyet);
            this.Controls.Add(this.Btn_HSil);
            this.Controls.Add(this.Cb_HKanGrup);
            this.Controls.Add(this.Txb_HAdres);
            this.Controls.Add(this.Txb_HTelefon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Txb_HYas);
            this.Controls.Add(this.Txb_HAdSoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.HastaDGV);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHastaListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaListesi";
            this.Load += new System.EventHandler(this.frmHastaListesi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblbaslık;
        private Guna.UI2.WinForms.Guna2DataGridView HastaDGV;
        private Guna.UI2.WinForms.Guna2TextBox Txb_HYas;
        private Guna.UI2.WinForms.Guna2TextBox Txb_HAdSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox Cb_HKanGrup;
        private Guna.UI2.WinForms.Guna2TextBox Txb_HAdres;
        private Guna.UI2.WinForms.Guna2TextBox Txb_HTelefon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_HSil;
        private Guna.UI2.WinForms.Guna2ComboBox Cb_HCinsiyet;
        private System.Windows.Forms.Label lblKanBagısı;
        private System.Windows.Forms.Label lblcıkısyap;
        private System.Windows.Forms.Label lblgenelkontrol;
        private System.Windows.Forms.Label lblkantransferi;
        private System.Windows.Forms.Label lblkanstogu;
        private System.Windows.Forms.Label lblhastalistesi;
        private System.Windows.Forms.Label lblhastaislemleri;
        private System.Windows.Forms.Label lbldonorlistesi;
        private System.Windows.Forms.Label lbldonorislemleri;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}