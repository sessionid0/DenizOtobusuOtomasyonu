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
namespace HadoTestApp
{
    
    public partial class FizikselKartGoruntule : Form
    {
        public static int sonuc = 0;
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";
        public static int fkartbakiye;
        public static string fkartnum="";
        public FizikselKartGoruntule()
        {
            InitializeComponent();
        }

        public void CaptchaOlustur()
        {
            Random random = new Random();
            int say1 = random.Next(0, 40);
            int say2 = random.Next(0, 40);
            sonuc = say1 + say2;
            label_captcha.Text = say1.ToString() + "+" + say2.ToString() + "= ?";

        }

        private void FizikselKartGoruntule_Load(object sender, EventArgs e)
        {
            CaptchaOlustur();
            label_kartno.Text = FizikselKartGoruntule.fkartnum;
            label_bakiye.Text = FizikselKartGoruntule.fkartbakiye.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_captcha.Text == FizikselKartGoruntule.sonuc.ToString())
            {

                string sorgu = "select * from t_fcards where fkartno =@kartno";
                con = new SqlConnection(SqlCon);
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@kartno", (textBox1.Text).Trim());
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    fkartbakiye = Convert.ToInt32(dr["fkartbakiye"]);
                    fkartnum = (dr["fkartno"].ToString());
                }
                FizikselKartGoruntule_Load(sender, e);
                CaptchaOlustur();
                textBox_captcha.Clear();
                
            }
            else
            {
                MessageBox.Show("Captcha yanlış girildi. Lütfen tekrar deneyin.");
                CaptchaOlustur();
                textBox_captcha.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FizikselKartBakiye fizikselKartBakiye = new FizikselKartBakiye();
            fizikselKartBakiye.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HadoPanelUser hadoPanelUser = new HadoPanelUser();
            hadoPanelUser.Show();
            this.Hide();
        }
    }
}
