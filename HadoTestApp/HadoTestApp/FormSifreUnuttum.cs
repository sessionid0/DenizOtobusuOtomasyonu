using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HadoTestApp
{
    public partial class FormSifreUnuttum : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";

        public FormSifreUnuttum()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FormSifreUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text) != "" && (textBox2.Text) != "" && (textBox3.Text) != "")
            {
                if ((textBox2.Text) == (textBox3.Text))
                {
                    string sorgu = " update t_user set password = @pass where (username=@user and name=@name and surname=@surname)";
                    con = new SqlConnection(SqlCon);
                    cmd = new SqlCommand(sorgu, con);
                    cmd.Parameters.AddWithValue("@user", textBox1.Text);
                    cmd.Parameters.AddWithValue("@pass", Veritabani.MD5Sifrele(textBox2.Text));
                    cmd.Parameters.AddWithValue("@name", textBox4.Text);
                    cmd.Parameters.AddWithValue("@surname", textBox5.Text);

                    con.Open();
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();

                    string sorgulogin = "select username, name, surname, dateh from t_user where username =@user and name= @name and surname=@surname";
                    con = new SqlConnection(SqlCon);
                    cmd = new SqlCommand(sorgulogin, con);
                    cmd.Parameters.AddWithValue("@user", textBox1.Text);
                    cmd.Parameters.AddWithValue("@name", textBox4.Text);
                    cmd.Parameters.AddWithValue("@surname", textBox5.Text);


                    con.Open();
                    dr = cmd.ExecuteReader();

                    if (dr.Read() == true)
                    {
                        MessageBox.Show("Şifreniz başarıyla güncellenmiştir.");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox1.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı ve isim eşleşmelerimizde size rastlayamadık. Lütfen yeniden deneyin.");

                    }

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz yeni şifre değerleri eşleşmiyor. Lütfen tekrar deneyin.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurup yeniden deneyin.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
