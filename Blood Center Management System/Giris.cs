using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KanBankasıYönetimUygulaması
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "KanBankasıUygDB.mdf;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLblSfrUntm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void lblGiris_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from CalisanTbl where CId='"+Txb_Kullanıcı.Text+"' and CSifre='" +Txb_Sifre.Text +"'",baglanti);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                frmAnaSayfa ana = new frmAnaSayfa();
                ana.Show();
                this.Hide();
                baglanti.Close();
            }else
            {
                MessageBox.Show("Yanlış Kullanıcı veya Şifre Girişi.");
            }
            baglanti.Close();
        }

        private void linkLblYntcGrs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmYoneticiGiris ygr = new frmYoneticiGiris();
            ygr.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblCks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
