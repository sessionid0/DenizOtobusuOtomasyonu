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
    public partial class FormYeniKayit : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";

       
      

        public FormYeniKayit()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ekle başlangıç

            string passhash;
            passhash = Veritabani.MD5Sifrele((textBox6.Text));

            

            cmd = new SqlCommand();
            string sql = "insert into t_user(name,surname,dateh,username,password,kartbakiye) values (@name, @surname, @date, @user, @pass,@bakiye)";
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@surname", textBox3.Text);
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", passhash);
            cmd.Parameters.AddWithValue("@bakiye", 0);

            Veritabani.KomutYollaParametreli(sql,cmd);







            //con = new SqlConnection(SqlCon);
            //string sql = "insert into t_user(name,surname,dateh,username,password,kartbakiye) values (@name, @surname, @date, @user, @pass,@bakiye)";
            //cmd = new SqlCommand();
            //cmd.Parameters.AddWithValue("@name", textBox2.Text);
            //cmd.Parameters.AddWithValue("@surname", textBox3.Text);
            //cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
            //cmd.Parameters.AddWithValue("@user", textBox1.Text);
            //cmd.Parameters.AddWithValue("@pass", passhash);
            //cmd.Parameters.AddWithValue("@bakiye", 0);

            //con.Open();
            //cmd.Connection = con;
            //cmd.CommandText = sql;
            //cmd.ExecuteNonQuery();
            //con.Close();

            //ekle bitiş



            MessageBox.Show("Kullanıcı kayıt işleminiz gerçekleşmiştir.");
            this.Hide();
            

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into t_admin(roname, rosurname, rousername, ropass, robakiye) values ('" + textBox10.Text + "', '" + textBox12.Text + "', '" + textBox4.Text + "', '" + Veritabani.MD5Sifrele((textBox8.Text)) + "', '0' )";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Yeni yönetici eklenmiştir.");



            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();
            textBox6.Clear();
        }

        public void EklemeSorgu(string sorgu)
        {
            string passhash;
            passhash = Veritabani.MD5Sifrele((textBox6.Text));
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            con.Close();


            //dr = cmd.ExecuteReader();
           


            MessageBox.Show("Yeni kullanıcı eklenmiştir.");



            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();
            textBox6.Clear();
           


        }
    }

}
