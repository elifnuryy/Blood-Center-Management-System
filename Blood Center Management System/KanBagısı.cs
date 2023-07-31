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
    public partial class frmKanBagısı : Form
    {
        public frmKanBagısı()
        {
            InitializeComponent();
            uyeler();
            KanStok();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "KanBankasıUygDB.mdf;Integrated Security=True");
        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from DonorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            KBagısıDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void KanStok()
        {
            baglanti.Open();
            string query = "select * from KanTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            KStoguDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void label7_Click(object sender, EventArgs e)
        {
            frmGenelKontrol dn = new frmGenelKontrol();
            dn.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        int eskistok;
        private void Stok(string KGrup)
        {
            baglanti.Open();
            string query = "select * from KanTbl where KGrup ='" + KGrup + "'";
            SqlCommand komut = new SqlCommand(query, baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                eskistok = Convert.ToInt32(dr["KStok"].ToString());

            }
            baglanti.Close();
        }
        private void DonorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_KbHAdSoyad.Text = KBagısıDGV.SelectedRows[0].Cells[1].Value.ToString();
            Txb_KbHKanGrup.Text = KBagısıDGV.SelectedRows[0].Cells[6].Value.ToString();
            Stok(Txb_KbHKanGrup.Text);
        }
        private void Reset()
        {
            Txb_KbHAdSoyad.Text = "";
            Txb_KbHKanGrup.Text = "";
        }
        private void Btn_KanBagısı_Click(object sender, EventArgs e)
        {
            if (Txb_KbHAdSoyad.Text == "")
            {
                MessageBox.Show("Bir Donör Seçiniz.");
            }
            else
            {
                try
                {
                    int stok = eskistok+1;
                    string query = "update KanTbl set KStok='" + stok + "'where KGrup='" + Txb_KbHKanGrup.Text + "';";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kan Bağışı Başarılı.");
                    baglanti.Close();
                    Reset();
                    KanStok();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmKanBagısı_Load(object sender, EventArgs e)
        {

        }

        private void lbldonorislemleri_Click(object sender, EventArgs e)
        {
            frmDonor dn = new frmDonor();
            dn.Show();
            this.Hide();
        }

        private void lbldonörlistesi_Click(object sender, EventArgs e)
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

        private void lblhhastaislemleri_Click(object sender, EventArgs e)
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

        private void lblkanstoğu_Click(object sender, EventArgs e)
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

        private void lblcıkısyap_Click(object sender, EventArgs e)
        {
            frmGiris gr = new frmGiris();
            gr.Show();
            this.Hide();
        }
    }
}
