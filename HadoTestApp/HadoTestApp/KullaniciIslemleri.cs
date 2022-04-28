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
    public partial class KullaniciIslemleri : Form
    {
        public KullaniciIslemleri()
        {
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
        }

        private void KullaniciIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SifreDegisikligi sifreDegisikligi = new SifreDegisikligi();
            sifreDegisikligi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountDeletion accountDeletion = new AccountDeletion();
            accountDeletion.Show();
            this.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HadoPanelUser hadoPanelUser = new HadoPanelUser();
            hadoPanelUser.Show();
            this.Hide();
        }
    }
}
