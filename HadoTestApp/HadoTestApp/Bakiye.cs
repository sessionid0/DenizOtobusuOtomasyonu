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
    public partial class Bakiye : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";
        public Bakiye()
        {
            InitializeComponent();
        }

        private void Bakiye_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.clickedWhere == 0) { 
            double bakiyetl = Convert.ToDouble(maskedTextBox1.Text);
            cmd = new SqlCommand();
            string sql = "update t_user set kartbakiye=@bakiye where username=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", Veritabani.usersession);
            cmd.Parameters.AddWithValue("@pass", Veritabani.userpass);
            cmd.Parameters.AddWithValue("@bakiye", Veritabani.kartbakiyesi+bakiyetl);

            Veritabani.KomutYollaParametreli(sql, cmd);
                MessageBox.Show("Bakiye karta yüklenmiştir. Lütfen güncel bakiyenizi görmek için yeniden oturum açın.");
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
            else 
            { 

            double bakiyetl = Convert.ToDouble(maskedTextBox1.Text);
            cmd = new SqlCommand();
            string sql = "update t_admin set robakiye=@bakiye where rousername=@user and ropass=@pass";
            cmd.Parameters.AddWithValue("@user", Veritabani.usersession);
            cmd.Parameters.AddWithValue("@pass", Veritabani.userpass);
            cmd.Parameters.AddWithValue("@bakiye", Veritabani.kartbakiyesi + bakiyetl);

            Veritabani.KomutYollaParametreli(sql, cmd);

            MessageBox.Show("Bakiye karta yüklenmiştir. Lütfen güncel bakiyenizi görmek için yeniden oturum açın.");
            this.Hide();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "10";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "20";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "40";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "50";
        }
    }
}
