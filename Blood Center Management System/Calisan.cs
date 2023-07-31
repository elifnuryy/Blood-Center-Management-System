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
    public partial class frmCalisan : Form
    {
        public frmCalisan()
        {
            InitializeComponent();
            uyeler();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "KanBankasıUygDB.mdf;Integrated Security=True");
        private void lblcıkıs_Click(object sender, EventArgs e)
        {
            frmGiris gr = new frmGiris();
            gr.Show();
            this.Hide();
        }
        private void Reset()
        {
            Txb_CAdSoyad.Text= "";
            Txb_CSifre.Text = "";
            key = 0;
        }
        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from CalisanTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CalisanDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void Btn_CEkle_Click(object sender, EventArgs e)
        {
            if (Txb_CAdSoyad.Text==""||Txb_CSifre.Text=="")
            {
                MessageBox.Show("Eksik Bilgi Girişi Yaptınız");
            }
            else
            {
                try
                {
                    string query = "insert into CalisanTbl values('" + Txb_CAdSoyad.Text + "','" + Txb_CSifre.Text + "')";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Çalışan Başarıyla Eklendi");
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
        int key = 0;
        private void CalisanDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txb_CAdSoyad.Text = CalisanDGV.SelectedRows[0].Cells[1].Value.ToString();
            Txb_CSifre.Text = CalisanDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (Txb_CAdSoyad.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CalisanDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Btn_CSil_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek Çalışanı Lütfen Seçiniz.");
            }
            else
            {
                try
                {
                    string query = "delete from CalisanTbl Where CNum=" + key + ";";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Çalışan Başarıyla Silindi.");
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

        private void Btn_CGuncelle_Click(object sender, EventArgs e)
        {
            if(Txb_CAdSoyad.Text==""||Txb_CSifre.Text=="")
            {
                MessageBox.Show("Eksik Bilgi Girişi Yaptınız!");
            }else
            {
                try
                {
                    string query = "update CalisanTbl set CId='" + Txb_CAdSoyad.Text + "',CSifre='" + Txb_CSifre.Text + "' where CNum=" + key + ";";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Çalışan Başarıyla Güncellendi.");
                    baglanti.Close();
                    Reset();
                    uyeler();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
        }
    }
    }


