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
    public partial class frmHasta : Form
    {
        public frmHasta()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "KanBankasıUygDB.mdf;Integrated Security=True");
        private void Reset()
        {
            Txb_HAdSoyad.Text = "";
            Txb_HYas.Text = "";
            Cb_HCinsiyet.SelectedIndex = -1;
            Txb_HTelefon.Text = "";
            Txb_HAdres.Text = "";
            Cb_HKanGrup.SelectedIndex = -1;

        }
        private void Hasta_Load(object sender, EventArgs e)
        {

        }

        private void Btn_HastaEkle_Click(object sender, EventArgs e)
        {
            if (Txb_HAdSoyad.Text == "" || Txb_HYas.Text == "" || Cb_HCinsiyet.SelectedIndex == -1 || Txb_HTelefon.Text == "" || Cb_HKanGrup.SelectedIndex == -1 || Txb_HAdres.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girişi Yaptınız");
            }
            else
            {
                try
                {
                    string query = "insert into HastaTbl values('" + Txb_HAdSoyad.Text + "'," +Txb_HYas.Text + ",'" + Txb_HTelefon.Text + "','" + Cb_HCinsiyet.SelectedItem.ToString() + "','" + Cb_HKanGrup.SelectedItem.ToString() + "','" + Txb_HAdres.Text + "')";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yeni Hasta Başarıyla Eklendi");
                    baglanti.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }

        }

        private void lblHastaListesi_Click(object sender, EventArgs e)
        {
            frmHastaListesi HL = new frmHastaListesi();
            HL.Show();
            this.Hide();
        }

        private void Txb_HYas_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKanTransferi_Click(object sender, EventArgs e)
        {
           frmKanTransferi dn = new frmKanTransferi();
            dn.Show();
            this.Hide();
        }

        private void lblDonorislemleri_Click(object sender, EventArgs e)
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
            frmHasta dn = new frmHasta(
                );
            dn.Show();
            this.Hide();
        }

        private void lblhastalistesi_Click_1(object sender, EventArgs e)
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
