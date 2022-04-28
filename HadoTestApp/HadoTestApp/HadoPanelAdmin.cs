using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HadoTestApp
{
    public partial class HadoPanelAdmin : Form
    {
        public HadoPanelAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uyeler0 uyeler = new Uyeler0();
            uyeler.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SanalKartIslemYonetici sanalKartIslemYonetici = new SanalKartIslemYonetici();
            sanalKartIslemYonetici.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FizikselKartEkleAdmin fizikselKartEkleAdmin = new FizikselKartEkleAdmin();
            fizikselKartEkleAdmin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeferEkleSilAdmin seferEkleSilAdmin = new SeferEkleSilAdmin();
            seferEkleSilAdmin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YoneticiSifreIslemleri yoneticiSifreIslemleri = new YoneticiSifreIslemleri();
            yoneticiSifreIslemleri.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
