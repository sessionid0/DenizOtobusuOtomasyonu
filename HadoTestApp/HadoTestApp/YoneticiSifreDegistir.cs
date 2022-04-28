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
    public partial class YoneticiSifreDegistir : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";
        public static int sonuc;
        public YoneticiSifreDegistir()
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
        private void label_captcha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Veritabani.LoginDataKontrolYonetici(Veritabani.usersession, textBox2.Text) == true)
            {
                if ((textBox3.Text) == (textBox4.Text))
                {
                    if (textBox_captcha.Text == YoneticiSifreDegistir.sonuc.ToString())
                    {

                        con = new SqlConnection(SqlCon);
                        string sorgu = "update t_admin set ropass = @newpass where (rousername=@user and ropass=@pass)";
                        cmd = new SqlCommand();
                        cmd.Parameters.AddWithValue("@user", Veritabani.usersession);
                        cmd.Parameters.AddWithValue("@pass", Veritabani.userpass);
                        cmd.Parameters.AddWithValue("@newpass", Veritabani.MD5Sifrele(textBox3.Text));

                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = sorgu;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Şifreniz başarıyla güncellenmiştir. Giriş ekranına yönlendiriliyorsunuz.");

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

        private void YoneticiSifreDegistir_Load(object sender, EventArgs e)
        {
            CaptchaOlustur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YoneticiSifreIslemleri yoneticiSifreIslemleri = new YoneticiSifreIslemleri();
            yoneticiSifreIslemleri.Show();
            this.Hide();
        }
    }
    
}
