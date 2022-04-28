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
    public partial class YoneticiHesapSilme : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";
        public YoneticiHesapSilme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Veritabani.LoginDataKontrolYonetici(Veritabani.usersession, textBox1.Text) == true)
            {
                con = new SqlConnection(SqlCon);
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "delete from t_admin where rousername='" + Veritabani.usersession + "' and ropass='" + Veritabani.MD5Sifrele(textBox1.Text) + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                Form1 form1 = new Form1();
                MessageBox.Show("Hesabınız silindi. Ana sayfaya yönlendirileceksiniz.");
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Girdiğiniz şifre hatalı. Lütfen kontrol ediniz.");
                textBox1.Clear();
                textBox1.Focus();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YoneticiSifreIslemleri yoneticiSifreIslemleri = new YoneticiSifreIslemleri();
            yoneticiSifreIslemleri.Show();
            this.Hide();
        }
    }
}
