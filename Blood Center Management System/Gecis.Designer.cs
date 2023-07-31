namespace KanBankasıYönetimUygulaması
{
    partial class frmGecis
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGecis));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GecisprosessBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblyükleme = new System.Windows.Forms.Label();
            this.lblbaslık = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GecisprosessBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GecisprosessBar
            // 
            this.GecisprosessBar.BackColor = System.Drawing.Color.White;
            this.GecisprosessBar.Controls.Add(this.pictureBox1);
            this.GecisprosessBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.GecisprosessBar.FillThickness = 16;
            this.GecisprosessBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GecisprosessBar.ForeColor = System.Drawing.Color.White;
            this.GecisprosessBar.Location = new System.Drawing.Point(103, 69);
            this.GecisprosessBar.Minimum = 0;
            this.GecisprosessBar.Name = "GecisprosessBar";
            this.GecisprosessBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GecisprosessBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GecisprosessBar.ProgressThickness = 16;
            this.GecisprosessBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.GecisprosessBar.Size = new System.Drawing.Size(271, 271);
            this.GecisprosessBar.TabIndex = 12;
            this.GecisprosessBar.Text = "guna2CircleProgressBar1";
            this.GecisprosessBar.ValueChanged += new System.EventHandler(this.guna2CircleProgressBar1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lblyükleme
            // 
            this.lblyükleme.AutoSize = true;
            this.lblyükleme.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyükleme.Location = new System.Drawing.Point(182, 362);
            this.lblyükleme.Name = "lblyükleme";
            this.lblyükleme.Size = new System.Drawing.Size(142, 29);
            this.lblyükleme.TabIndex = 13;
            this.lblyükleme.Text = "Yükleniyor...";
            this.lblyükleme.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblbaslık
            // 
            this.lblbaslık.AutoSize = true;
            this.lblbaslık.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaslık.ForeColor = System.Drawing.Color.Firebrick;
            this.lblbaslık.Location = new System.Drawing.Point(42, 24);
            this.lblbaslık.Name = "lblbaslık";
            this.lblbaslık.Size = new System.Drawing.Size(423, 31);
            this.lblbaslık.TabIndex = 14;
            this.lblbaslık.Text = "KAN BANKASI YÖNETİM SİSTEMİ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmGecis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 455);
            this.Controls.Add(this.lblbaslık);
            this.Controls.Add(this.lblyükleme);
            this.Controls.Add(this.GecisprosessBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGecis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gecis";
            this.Load += new System.EventHandler(this.frmGecis_Load);
            this.GecisprosessBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar GecisprosessBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblyükleme;
        private System.Windows.Forms.Label lblbaslık;
        private System.Windows.Forms.Timer timer1;
    }
}

