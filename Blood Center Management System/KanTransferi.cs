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
    public partial class frmKanTransferi : Form
    {
        public frmKanTransferi()
        {
            InitializeComponent();
            fillHastaCb();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "KanBankasıUygDB.mdf;Integrated Security=True");
        private void fillHastaCb()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select HNum from HastaTbl", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("HNum", typeof(int));
            dt.Load(rdr);
            Cb_HId.ValueMember = "HNum";
            Cb_HId.DataSource = dt;
            baglanti.Close();
        }
        private void VeriAl()
        {
            baglanti.Open();
            string query = "select * from HastaTbl where HNum =" + Cb_HId.SelectedValue.ToString() + "";
            SqlCommand komut = new SqlCommand(query, baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Txb_HAdSoyad.Text = dr["HAdSoyad"].ToString();
                Txb_HKGrup .Text = dr["HKanGrup"].ToString();
                
            }
            baglanti.Close();
        }
        int stokk=0;
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
                stokk = Convert.ToInt32(dr["KStok"].ToString());

            }
            baglanti.Close();
        }
        private void frmKanTransferi_Load(object sender, EventArgs e)
        {

        }

        private void Cb_HId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            VeriAl();
            Stok(Txb_HKGrup.Text);
            if(stokk>0)
            {
                Btn_TransferYap.Visible = true; 
                lbluygun.Text="Stok uygun.";
                lbluygun.Visible = true;
            }else
            {
                lbluygun.Text = "Stok uygun değil.";
                lbluygun.Visible = true;
            }
        }

        private void lblHIslemleri_Click(object sender, EventArgs e)
        {
            frmHasta dn = new frmHasta();
            dn.Show();
            this.Hide();
        }
        private void Reset()
        {
            Txb_HAdSoyad.Text = "";
            Txb_HKGrup.Text ="";
            lbluygun.Visible =false;
            Btn_TransferYap.Visible = false;

        }
        private void kanGuncelle()
        {
            int yenistok = stokk - 1;
            try
            {
                string query = "update KanTbl set KStok =" + yenistok + " where KGrup='" + Txb_HKGrup.Text + "';";
                baglanti.Open();
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.ExecuteNonQuery();
                // MessageBox.Show("Hasta Başarı ile güncellendi.");
                baglanti.Close();
            
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ex.Message");
            }
        }
    
        

        private void Btn_TransferYap_Click(object sender, EventArgs e)
        {
            if (Txb_HAdSoyad.Text == "") 
            {
                MessageBox.Show("Eksik Bilgi Girişi Yaptınız");
            }
            else
            {
                try
                {
                    string query = "insert into TransferTbl values('" + Txb_HAdSoyad.Text + "','" + Txb_HKGrup.Text + "')"; 
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Transfer Başarılı");
                    baglanti.Close();
                    Stok(Txb_HKGrup.Text);
                    kanGuncelle();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
        }

        private void lblKStogu_Click(object sender, EventArgs e)
        {
            frmKanStoğu dn = new frmKanStoğu();
            dn.Show();
            this.Hide();
        }

        private void lblDIslemleri_Click(object sender, EventArgs e)
        {
            frmDonor dn = new frmDonor();
            dn.Show();
            this.Hide();
        }

        private void lblDListesi_Click(object sender, EventArgs e)
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

        private void lblHastaIslemleri_Click(object sender, EventArgs e)
        {
            frmHastaListesi dn = new frmHastaListesi();
            dn.Show();
            this.Hide();
        }

        private void lblKTransferi_Click(object sender, EventArgs e)
        {
            frmKanTransferi dn = new frmKanTransferi();
            dn.Show();
            this.Hide();
        }

        private void lblKontrol_Click(object sender, EventArgs e)
        {
            frmGenelKontrol dn = new frmGenelKontrol();
            dn.Show();
            this.Hide();
        }

        private void lblCıkıs_Click(object sender, EventArgs e)
        {
            frmGiris gr = new frmGiris();
            gr.Show();
            this.Hide();
        }
    }
}
    

