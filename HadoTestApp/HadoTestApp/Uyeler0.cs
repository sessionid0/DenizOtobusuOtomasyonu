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
    public partial class Uyeler0 : Form
    {
        public static string DataUserID;
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";
        public Uyeler0()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "delete from t_user where username=@user and name=@name;";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@user", textBox4.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            Veritabani.KomutYollaParametreli(sql, cmd);

            MessageBox.Show("İlgili kayıt silindi.");
            Uyeler0_Load(sender, e);
        }

        private void Uyeler0_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dotobusbaseDataSet.t_user' table. You can move, or remove it, as needed.
            this.t_userTableAdapter.Fill(this.dotobusbaseDataSet.t_user);
            // TODO: This line of code loads data into the 'dotobusbaseDataSet.t_admin' table. You can move, or remove it, as needed.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "update t_user set name=@name, surname=@surname, dateh=@dateh, username=@user, kartbakiye=@kartbakiye, kartno=@kartno, heskod=@heskod where ID=@id ";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@surname", textBox3.Text);
            cmd.Parameters.AddWithValue("@dateh", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@user", textBox4.Text);
            cmd.Parameters.AddWithValue("@kartbakiye", textBox7.Text);
            cmd.Parameters.AddWithValue("@kartno", textBox6.Text);
            cmd.Parameters.AddWithValue("@heskod", textBox9.Text);

            Veritabani.KomutYollaParametreli(sql, cmd);

            MessageBox.Show("Başarıyla güncellenmiştir.");
            Uyeler0_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormYeniKayit formYeniKayit = new FormYeniKayit();
            formYeniKayit.Show();
        }
    }
}
