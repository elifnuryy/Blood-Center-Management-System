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
    public partial class frmHastaListesi : Form
    {
        public frmHastaListesi()
        {
            InitializeComponent();
            uyeler();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "KanBankasıUygDB.mdf;Integrated Security=True");
        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from HastaTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            HastaDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void HastaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_HAdSoyad.Text = HastaDGV.SelectedRows[0].Cells[1].Value.ToString();
            Txb_HYas.Text = HastaDGV.SelectedRows[0].Cells[2].Value.ToString();
            Txb_HTelefon.Text = HastaDGV.SelectedRows[0].Cells[3].Value.ToString();
            Cb_HCinsiyet.Text = HastaDGV.SelectedRows[0].Cells[4].Value.ToString();
            Cb_HKanGrup.Text = HastaDGV.SelectedRows[0].Cells[5].Value.ToString();
            Txb_HAdres.Text = HastaDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (Txb_HAdSoyad.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(HastaDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Reset()
        {
            Txb_HAdSoyad.Text = "";
            Txb_HYas.Text = "";
            Cb_HCinsiyet.SelectedIndex = -1;
            Txb_HTelefon.Text = "";
            Txb_HAdres.Text = "";
            Cb_HKanGrup.SelectedIndex =-1;
            key = 0;

        }

        private void Btn_HSil_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek Hastayı Lütfen Seçiniz.");
            }
            else
            {
                try
                {
                    string query = "delete from HastaTbl Where HNum=" + key + ";";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yeni Hasta Başarıyla Silindi.");
                    baglanti.Close();
                    Reset();
                    uyeler();
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

        private void lblHastaIslemleri_Click(object sender, EventArgs e)
        {
            frmHasta ha = new frmHasta();
            ha.Show();
            this.Hide();
        }

        private void frmHastaListesi_Load(object sender, EventArgs e)
        {

        }

        private void lbldonorislemleri_Click(object sender, EventArgs e)
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

        private void lblhastaislemleri_Click_1(object sender, EventArgs e)
        {
            frmHasta dn = new frmHasta();
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
    


