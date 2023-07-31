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
    public partial class frmGenelKontrol : Form
    {
        public frmGenelKontrol()
        {
            InitializeComponent();
            VeriCek();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "KanBankasıUygDB.mdf;Integrated Security=True");
        private void VeriCek()
        {
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count (*)from DonorTbl",baglanti);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbldonor.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count (*)from TransferTbl", baglanti);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            lbltransfer.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select count (*)from CalisanTbl", baglanti);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            lblkullanıcı.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter sda3 = new SqlDataAdapter("select count (*)from KanTbl", baglanti);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            int Kstok = Convert.ToInt32(dt3.Rows[0][0].ToString());
            SqlDataAdapter sda4 = new SqlDataAdapter("select KSTok from KanTbl where KGrup='"+"A+"+"'", baglanti);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            lblpA.Text = dt4.Rows[0][0].ToString();
            double Apluspercentage = (Convert.ToDouble(dt4.Rows[0][0].ToString()) / Kstok) * 100;
            AplusBar.Value = Convert.ToInt32(Apluspercentage);
            SqlDataAdapter sda5 = new SqlDataAdapter("select KStok from KanTbl where KGrup='" + "B+" + "'", baglanti);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            lblpB.Text = dt5.Rows[0][0].ToString();
            double Bpluspercentage = (Convert.ToDouble(dt5.Rows[0][0].ToString()) / Kstok) * 100;
            BplusBar.Value = Convert.ToInt32(Bpluspercentage);
            SqlDataAdapter sda6 = new SqlDataAdapter("select KStok from KanTbl where KGrup='" + "0+" + "'", baglanti);
            DataTable dt6= new DataTable();
            sda6.Fill(dt6);
            lblp0.Text = dt6.Rows[0][0].ToString();
            double OPluspercentage = (Convert.ToDouble(dt6.Rows[0][0].ToString()) / Kstok) * 100;
            OplusBar.Value = Convert.ToInt32(OPluspercentage);
            SqlDataAdapter sda7 = new SqlDataAdapter("select KStok from KanTbl where KGrup='" + "AB+" + "'", baglanti);
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);
            lblpAB.Text = dt7.Rows[0][0].ToString();
            double ABPluspercentage = (Convert.ToDouble(dt7.Rows[0][0].ToString()) / Kstok) * 100;
            ABplusBar.Value = Convert.ToInt32(ABPluspercentage);
            SqlDataAdapter sda8 = new SqlDataAdapter("select KStok from KanTbl where KGrup='" + "A-" + "'", baglanti);
            DataTable dt8 = new DataTable();
            sda8.Fill(dt8);
            lblnA.Text = dt8.Rows[0][0].ToString();
            double Aminpercentage = (Convert.ToDouble(dt8.Rows[0][0].ToString()) / Kstok) * 100;
            AminBar.Value = Convert.ToInt32(Aminpercentage);
            SqlDataAdapter sda9 = new SqlDataAdapter("select KStok from KanTbl where KGrup='" + "B-" + "'", baglanti);
            DataTable dt9 = new DataTable();
            sda9.Fill(dt9);
            lblnB.Text = dt9.Rows[0][0].ToString();
            double Bminpercentage = (Convert.ToDouble(dt9.Rows[0][0].ToString()) / Kstok) * 100;
            BminBar.Value = Convert.ToInt32(Bminpercentage);
            SqlDataAdapter sda10 = new SqlDataAdapter("select KStok from KanTbl where KGrup='" + "0-" + "'", baglanti);
            DataTable dt10 = new DataTable();
            sda10.Fill(dt10);
            lbln0.Text = dt10.Rows[0][0].ToString();
            double Ominpercentage = (Convert.ToDouble(dt10.Rows[0][0].ToString()) / Kstok) * 100;
            OminBar.Value = Convert.ToInt32(Ominpercentage);
            SqlDataAdapter sda11 = new SqlDataAdapter("select KStok from KanTbl where KGrup='" + "AB-" + "'", baglanti);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            lblnAB.Text = dt11.Rows[0][0].ToString();
            double ABminpercentage = (Convert.ToDouble(dt11.Rows[0][0].ToString()) / Kstok) * 100;
            ABminBar.Value = Convert.ToInt32(ABminpercentage);
            baglanti.Close();

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void GenelKontrol_Load(object sender, EventArgs e)
        {

        }

        private void lblKanBagısı_Click(object sender, EventArgs e)
        {
            frmKanBagısı dn = new frmKanBagısı();
            dn.Show();
            this.Hide();
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

        private void lblKanTransferi_Click(object sender, EventArgs e)
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
