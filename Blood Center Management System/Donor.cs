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
    public partial class frmDonor : Form
    {
        public frmDonor()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "KanBankasıUygDB.mdf;Integrated Security=True");
        private void Reset()
        {
            Txb_AdSoyad.Text = "";
            Txb_Yas.Text = "";
            Cb_Cinsiyet.SelectedIndex = -1;
            Txb_Telefon.Text = "";
            Txb_Adres.Text = "";
            Cb_KanGrup.SelectedIndex = -1;

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void frmDonor_Load(object sender, EventArgs e)
        {

        }

        private void Btn_DonorEkle_Click(object sender, EventArgs e)
        {
            if (Txb_AdSoyad.Text == "" || Txb_Yas.Text == "" || Cb_Cinsiyet.SelectedIndex == -1 || Txb_Telefon.Text == "" || Cb_KanGrup.SelectedIndex == -1 || Txb_Adres.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girişi Yaptınız");
            }
            else
            {
                try
                {
                    string query = "insert into DonorTbl values('" +Txb_AdSoyad.Text + "'," +Txb_Yas.Text +",'"+Cb_Cinsiyet.SelectedItem.ToString()+"','"+ Txb_Telefon.Text +"','" +Txb_Adres.Text+"','" + Cb_KanGrup.SelectedItem.ToString()+"')";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query,baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yeni Donör Başarıyla Eklendi");
                    baglanti.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
            }

        private void lbldonor_Click(object sender, EventArgs e)
        {
            frmDonor dn = new frmDonor();
            dn.Show();
            this.Hide();
        }

        private void lbldonorlistesi_Click(object sender, EventArgs e)
        {
            frmDonorListesi dn = new frmDonorListesi();
            dn.Show();
            this.Hide();
        }

        private void lblKanBagısı_Click(object sender, EventArgs e)
        {
            frmKanBagısı dn = new frmKanBagısı();
            dn.Show();
            this.Hide();
        }

        private void lblhastaislemleri_Click(object sender, EventArgs e)
        {
            frmHasta dn = new frmHasta();
            dn.Show();
            this.Hide();
        }

        private void lblhastalistesi_Click(object sender, EventArgs e)
        {
            frmHastaListesi dn = new frmHastaListesi();
            dn.Show();
            this.Hide();
        }

        private void lblkanstogu_Click(object sender, EventArgs e)
        {
            frmKanStoğu dn = new frmKanStoğu();
            dn.Show();
            this.Hide();
        }

        private void lblkantransferi_Click(object sender, EventArgs e)
        {
            frmKanTransferi dn = new frmKanTransferi();
            dn.Show();
            this.Hide();
        }

        private void lblgenelkontrol_Click(object sender, EventArgs e)
        {
            frmGenelKontrol dn = new frmGenelKontrol();
            dn.Show();
            this.Hide();
        }

        private void lblcıkısyap_Click(object sender, EventArgs e)
        {
            frmGiris gr = new frmGiris();
            gr.Show();
            this.Hide();
        }
    }
    }

