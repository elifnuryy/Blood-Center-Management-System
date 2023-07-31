using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBankasıYönetimUygulaması
{
    public partial class frmYoneticiGiris : Form
    {
        public frmYoneticiGiris()
        {
            InitializeComponent();
        }

        private void linkLblKapat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmGiris gr = new frmGiris();
            gr.Show();
            this.Hide();
        }

        private void Btn_YoneticiGiris_Click(object sender, EventArgs e)
        {
            if(Txb_YoneticiSifre.Text=="")
            {
                MessageBox.Show("Yönetici Şifrenizi Giriniz!");
            }else if(Txb_YoneticiSifre.Text=="3879")
            {
                frmCalisan c = new frmCalisan();
                c.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Yanlış Şifre Girişi.");
                Txb_YoneticiSifre.Text = "";
            }
        }
    }
}
