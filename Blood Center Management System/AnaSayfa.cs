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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbldonorislemleri_Click(object sender, EventArgs e)
        {
            frmDonor dn = new frmDonor();
            dn.Show();
            this.Hide();
        }

        private void lblKanBagısı_Click(object sender, EventArgs e)
        {
            frmKanBagısı dn = new frmKanBagısı();
            dn.Show();
            this.Hide();
        }

        private void lbldonorlistesi_Click(object sender, EventArgs e)
        {
            frmDonorListesi dn = new frmDonorListesi();
            dn.Show();
            this.Hide();
        }

        private void lblhasta_Click(object sender, EventArgs e)
        {
            frmHasta dn = new frmHasta();
            dn.Show();
            this.Hide();
        }

        private void lblhastaislemleri_Click(object sender, EventArgs e)
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
