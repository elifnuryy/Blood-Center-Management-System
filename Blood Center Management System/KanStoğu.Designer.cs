namespace KanBankasıYönetimUygulaması
{
    partial class frmKanStoğu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKanStoğu));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblbaslık = new System.Windows.Forms.Label();
            this.KStoguDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKanBagısı = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblcıkısyap = new System.Windows.Forms.Label();
            this.lblgenelkontrol = new System.Windows.Forms.Label();
            this.lblKTransferi = new System.Windows.Forms.Label();
            this.lblkanstogu = new System.Windows.Forms.Label();
            this.lblhastalistesi = new System.Windows.Forms.Label();
            this.lblhastaislemleri = new System.Windows.Forms.Label();
            this.lbldonorlistesi = new System.Windows.Forms.Label();
            this.lbldonorislemleri = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KStoguDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Controls.Add(this.lblbaslık);
            this.panel4.Location = new System.Drawing.Point(288, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(826, 82);
            this.panel4.TabIndex = 42;
            // 
            // lblbaslık
            // 
            this.lblbaslık.AutoSize = true;
            this.lblbaslık.BackColor = System.Drawing.Color.Transparent;
            this.lblbaslık.Font = new System.Drawing.Font("Poor Richard", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaslık.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblbaslık.Location = new System.Drawing.Point(116, 24);
            this.lblbaslık.Name = "lblbaslık";
            this.lblbaslık.Size = new System.Drawing.Size(571, 45);
            this.lblbaslık.TabIndex = 15;
            this.lblbaslık.Text = "KAN BANKASI YÖNETİM SİSTEMİ";
            // 
            // KStoguDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.KStoguDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.KStoguDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KStoguDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.KStoguDGV.ColumnHeadersHeight = 28;
            this.KStoguDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KStoguDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.KStoguDGV.GridColor = System.Drawing.Color.White;
            this.KStoguDGV.Location = new System.Drawing.Point(338, 252);
            this.KStoguDGV.Name = "KStoguDGV";
            this.KStoguDGV.RowHeadersVisible = false;
            this.KStoguDGV.RowTemplate.Height = 25;
            this.KStoguDGV.Size = new System.Drawing.Size(713, 281);
            this.KStoguDGV.TabIndex = 53;
            this.KStoguDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.KStoguDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.KStoguDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.KStoguDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.KStoguDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.KStoguDGV.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.KStoguDGV.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.KStoguDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.KStoguDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.KStoguDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KStoguDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.KStoguDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.KStoguDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.KStoguDGV.ThemeStyle.ReadOnly = false;
            this.KStoguDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.DimGray;
            this.KStoguDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.KStoguDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KStoguDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.KStoguDGV.ThemeStyle.RowsStyle.Height = 25;
            this.KStoguDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.KStoguDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Gray;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblKanBagısı);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblcıkısyap);
            this.panel2.Controls.Add(this.lblgenelkontrol);
            this.panel2.Controls.Add(this.lblKTransferi);
            this.panel2.Controls.Add(this.lblkanstogu);
            this.panel2.Controls.Add(this.lblhastalistesi);
            this.panel2.Controls.Add(this.lblhastaislemleri);
            this.panel2.Controls.Add(this.lbldonorlistesi);
            this.panel2.Controls.Add(this.lbldonorislemleri);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 594);
            this.panel2.TabIndex = 56;
            // 
            // lblKanBagısı
            // 
            this.lblKanBagısı.AutoSize = true;
            this.lblKanBagısı.BackColor = System.Drawing.Color.White;
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
            this.panel3.Location = new System.Drawing.Point(47, 387);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 31);
            this.panel3.TabIndex = 24;
            // 
            // lblcıkısyap
            // 
            this.lblcıkısyap.AutoSize = true;
            this.lblcıkısyap.BackColor = System.Drawing.Color.White;
            this.lblcıkısyap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcıkısyap.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcıkısyap.ForeColor = System.Drawing.Color.Black;
            this.lblcıkısyap.Location = new System.Drawing.Point(72, 530);
            this.lblcıkısyap.Name = "lblcıkısyap";
            this.lblcıkısyap.Size = new System.Drawing.Size(121, 35);
            this.lblcıkısyap.TabIndex = 23;
            this.lblcıkısyap.Text = "Çıkış Yap";
            this.lblcıkısyap.Click += new System.EventHandler(this.lblcıkısyap_Click);
            // 
            // lblgenelkontrol
            // 
            this.lblgenelkontrol.AutoSize = true;
            this.lblgenelkontrol.BackColor = System.Drawing.Color.White;
            this.lblgenelkontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblgenelkontrol.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenelkontrol.ForeColor = System.Drawing.Color.Black;
            this.lblgenelkontrol.Location = new System.Drawing.Point(71, 478);
            this.lblgenelkontrol.Name = "lblgenelkontrol";
            this.lblgenelkontrol.Size = new System.Drawing.Size(180, 35);
            this.lblgenelkontrol.TabIndex = 22;
            this.lblgenelkontrol.Text = "Genel Kontrol";
            this.lblgenelkontrol.Click += new System.EventHandler(this.lblgenelkontrol_Click);
            // 
            // lblKTransferi
            // 
            this.lblKTransferi.AutoSize = true;
            this.lblKTransferi.BackColor = System.Drawing.Color.White;
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
            // lblkanstogu
            // 
            this.lblkanstogu.AutoSize = true;
            this.lblkanstogu.BackColor = System.Drawing.Color.White;
            this.lblkanstogu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblkanstogu.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkanstogu.ForeColor = System.Drawing.Color.Black;
            this.lblkanstogu.Location = new System.Drawing.Point(71, 383);
            this.lblkanstogu.Name = "lblkanstogu";
            this.lblkanstogu.Size = new System.Drawing.Size(138, 35);
            this.lblkanstogu.TabIndex = 20;
            this.lblkanstogu.Text = "Kan Stoğu";
            this.lblkanstogu.Click += new System.EventHandler(this.lblkanstogu_Click);
            // 
            // lblhastalistesi
            // 
            this.lblhastalistesi.AutoSize = true;
            this.lblhastalistesi.BackColor = System.Drawing.Color.White;
            this.lblhastalistesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblhastalistesi.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhastalistesi.ForeColor = System.Drawing.Color.Black;
            this.lblhastalistesi.Location = new System.Drawing.Point(71, 335);
            this.lblhastalistesi.Name = "lblhastalistesi";
            this.lblhastalistesi.Size = new System.Drawing.Size(165, 35);
            this.lblhastalistesi.TabIndex = 19;
            this.lblhastalistesi.Text = "Hasta Listesi";
            this.lblhastalistesi.Click += new System.EventHandler(this.lblhastalistesi_Click);
            // 
            // lblhastaislemleri
            // 
            this.lblhastaislemleri.AutoSize = true;
            this.lblhastaislemleri.BackColor = System.Drawing.Color.White;
            this.lblhastaislemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblhastaislemleri.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhastaislemleri.ForeColor = System.Drawing.Color.Black;
            this.lblhastaislemleri.Location = new System.Drawing.Point(71, 281);
            this.lblhastaislemleri.Name = "lblhastaislemleri";
            this.lblhastaislemleri.Size = new System.Drawing.Size(192, 35);
            this.lblhastaislemleri.TabIndex = 18;
            this.lblhastaislemleri.Text = "Hasta İşlemleri";
            this.lblhastaislemleri.Click += new System.EventHandler(this.lblhastaislemleri_Click);
            // 
            // lbldonorlistesi
            // 
            this.lbldonorlistesi.AutoSize = true;
            this.lbldonorlistesi.BackColor = System.Drawing.Color.White;
            this.lbldonorlistesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbldonorlistesi.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldonorlistesi.ForeColor = System.Drawing.Color.Black;
            this.lbldonorlistesi.Location = new System.Drawing.Point(71, 181);
            this.lbldonorlistesi.Name = "lbldonorlistesi";
            this.lbldonorlistesi.Size = new System.Drawing.Size(173, 35);
            this.lbldonorlistesi.TabIndex = 17;
            this.lbldonorlistesi.Text = "Donör Listesi";
            this.lbldonorlistesi.Click += new System.EventHandler(this.lbldonorlistesi_Click);
            // 
            // lbldonorislemleri
            // 
            this.lbldonorislemleri.AutoSize = true;
            this.lbldonorislemleri.BackColor = System.Drawing.Color.White;
            this.lbldonorislemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbldonorislemleri.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldonorislemleri.ForeColor = System.Drawing.Color.Black;
            this.lbldonorislemleri.Location = new System.Drawing.Point(70, 127);
            this.lbldonorislemleri.Name = "lbldonorislemleri";
            this.lbldonorislemleri.Size = new System.Drawing.Size(200, 35);
            this.lbldonorislemleri.TabIndex = 16;
            this.lbldonorislemleri.Text = "Donör İşlemleri";
            this.lbldonorislemleri.Click += new System.EventHandler(this.lbldonorislemleri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(561, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 44);
            this.label1.TabIndex = 57;
            this.label1.Text = "KAN STOĞU ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(64, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // frmKanStoğu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.KStoguDGV);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKanStoğu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KanStoğu";
            this.Load += new System.EventHandler(this.frmKanStoğu_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KStoguDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblbaslık;
        private Guna.UI2.WinForms.Guna2DataGridView KStoguDGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblKanBagısı;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblcıkısyap;
        private System.Windows.Forms.Label lblgenelkontrol;
        private System.Windows.Forms.Label lblKTransferi;
        private System.Windows.Forms.Label lblkanstogu;
        private System.Windows.Forms.Label lblhastalistesi;
        private System.Windows.Forms.Label lblhastaislemleri;
        private System.Windows.Forms.Label lbldonorlistesi;
        private System.Windows.Forms.Label lbldonorislemleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}