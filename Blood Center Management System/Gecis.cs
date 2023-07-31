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
    public partial class frmGecis : Form
    {
        public frmGecis()
        {
            InitializeComponent();
        }
        int starpos = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmGecis_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            starpos += 1;
            GecisprosessBar.Value = starpos;
            if(GecisprosessBar.Value==100)
            {
                GecisprosessBar.Value = 0;
                timer1.Stop();
                frmGiris gr = new frmGiris();
                gr.Show();
                this.Hide();
            }

        }
    }
}
