using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HadoTestApp
{
    
    public partial class HesKod : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";
        public static int sonuc;
        public HesKod()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text) != "" && (textBox_captcha.Text)!="")
            {
                if (textBox_captcha.Text == HesKod.sonuc.ToString())
                {
                    if (Form1.clickedWhere == 0) {

                    con = new SqlConnection(SqlCon);
                    string sorgu = "update t_user set heskod = @heskod where (username=@user and password=@pass)";
                    cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@user", Veritabani.usersession);
                    cmd.Parameters.AddWithValue("@pass", Veritabani.userpass);
                    cmd.Parameters.AddWithValue("@heskod", textBox1.Text);
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = sorgu;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("HES kodunuz güncellenmiştir. Değişikliği görebilmek için lütfen yeniden giriş yapın.");

                    CaptchaOlustur();
                    textBox1.Clear();
                    textBox_captcha.Clear();
                    this.Hide();
                    }
                    else
                    {
                        con = new SqlConnection(SqlCon);
                        string sorgu = "update t_admin set roheskod = @heskod where (rousername=@user and ropass=@pass)";
                        cmd = new SqlCommand();
                        cmd.Parameters.AddWithValue("@user", Veritabani.usersession);
                        cmd.Parameters.AddWithValue("@pass", Veritabani.userpass);
                        cmd.Parameters.AddWithValue("@heskod", textBox1.Text);
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = sorgu;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("HES kodunuz güncellenmiştir. Değişikliği görebilmek için lütfen yeniden giriş yapın.");

                        CaptchaOlustur();
                        textBox1.Clear();
                        textBox_captcha.Clear();
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Close();
                    }
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
                MessageBox.Show("Lütfen ilgili alanların tümünü doldurun ve tekrar deneyin.");
                CaptchaOlustur();
                textBox_captcha.Clear();
            }

        }

        private void HesKod_Load(object sender, EventArgs e)
        {
            label_heskontrol.Text = Veritabani.hesCode;
            CaptchaOlustur();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
