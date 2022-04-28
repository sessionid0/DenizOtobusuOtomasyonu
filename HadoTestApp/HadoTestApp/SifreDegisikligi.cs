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
    public partial class SifreDegisikligi : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";
        public static int sonuc;
        public SifreDegisikligi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( (textBox2.Text) != null && (textBox3.Text) != null && (textBox4.Text) != null)
            {
                if (Veritabani.LoginKontrol(Veritabani.usersession, textBox2.Text)==true)
                {
                    if ((textBox3.Text) == (textBox4.Text))
                    {
                        if (textBox_captcha.Text == SifreDegisikligi.sonuc.ToString()) 
                        {

                            con = new SqlConnection(SqlCon);
                            string sorgu = "update t_user set password = @newpass where (username=@user and password=@pass)";
                            cmd = new SqlCommand();
                            cmd.Parameters.AddWithValue("@user", Veritabani.usersession);
                            cmd.Parameters.AddWithValue("@pass", Veritabani.userpass);
                            cmd.Parameters.AddWithValue("@newpass", Veritabani.MD5Sifrele(textBox3.Text));

                            con.Open();
                            cmd.Connection = con;
                            cmd.CommandText = sorgu;
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Şifreniz başarıyla güncellenmiştir.");

                            CaptchaOlustur();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox_captcha.Clear();
                            this.Hide();
                            Form1 form1 = new Form1();
                            form1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Captcha yanlış girildi. Lütfen tekrar deneyin.");
                            CaptchaOlustur();
                            textBox_captcha.Clear();
                        }


                    }
                   
                    else
                    {
                        MessageBox.Show("Girdiğiniz yeni şifre değerleri uyuşmuyor. Lütfen tekrar deneyin.");
                        CaptchaOlustur();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox_captcha.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Girdiğiniz mevcut şifre doğru değil. Lütfen tekrar deneyin.");
                    CaptchaOlustur();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox_captcha.Clear();
                }

                
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurup yeniden deneyin.");
                CaptchaOlustur();
                textBox_captcha.Clear();
            }
        }
        public void CaptchaOlustur()
        {
            Random random = new Random();
            int say1 = random.Next(0, 40);
            int say2 = random.Next(0, 40);
             sonuc = say1 + say2;
            label_captcha.Text = say1.ToString() + "+" + say2.ToString() + "= ?";
            
        }



        private void SifreDegisikligi_Load(object sender, EventArgs e)
        {
            CaptchaOlustur();
        }

        private void label_captcha_Click(object sender, EventArgs e)
        {

        }

        private void textBox_captcha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
            kullaniciIslemleri.Show();
            this.Hide();
        }
    }
   // public static bool EskiSifreKontrol()
   // {

    //}
}
