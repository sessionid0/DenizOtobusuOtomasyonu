using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HadoTestApp
{
    public partial class HadoPanelUser : Form
    {
        public HadoPanelUser()
        {
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HadoPanelUser_Load(object sender, EventArgs e)
        {
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SanalKartIslemleri sanalKartIslemleri = new SanalKartIslemleri();
            sanalKartIslemleri.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
            kullaniciIslemleri.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeferBilgileri seferBilgileri = new SeferBilgileri();
            seferBilgileri.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FizikselKartGoruntule fizikselKartGoruntule = new FizikselKartGoruntule();
            fizikselKartGoruntule.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
