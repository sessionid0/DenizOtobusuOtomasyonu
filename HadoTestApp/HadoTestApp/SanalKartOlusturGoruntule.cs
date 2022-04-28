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
    public partial class SanalKartOlusturGoruntule : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";
      
        
        public SanalKartOlusturGoruntule()
        {
            InitializeComponent();
        }

        private void SanalKartGoruntule_Load(object sender, EventArgs e)
        {
            label_adbilgi.Text = Veritabani.nameData;
            label_soyadbilgi.Text = Veritabani.surnameData;
            label_Kartno.Text = Veritabani.kartNumarasi;

            label_Bakiye.Text = Veritabani.kartbakiyesi.ToString();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.clickedWhere == 0) 
            { 

            string kart = Veritabani.RandomString(10);
            con = new SqlConnection(SqlCon);
            string sql = "update t_user set kartno = @kartno where username=@user and password=@pass";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@user", Veritabani.usersession);
            cmd.Parameters.AddWithValue("@pass", Veritabani.userpass);
            cmd.Parameters.AddWithValue("@kartno", kart);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            string olustukartno = kart;
            con.Close();

            MessageBox.Show("Sanal kart numaranız güncellenmiştir. Güncel kart bilgilerinize yeniden giriş yaparak ulaşabilirsiniz. ");
            }
            else
            {
                string kart = Veritabani.RandomString(10);
                con = new SqlConnection(SqlCon);
                string sql = "update t_admin set rokartno = @kartno where rousername=@user and ropass=@pass";
                cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@user", Veritabani.usersession);
                cmd.Parameters.AddWithValue("@pass", Veritabani.userpass);
                cmd.Parameters.AddWithValue("@kartno", kart);
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                string olustukartno = kart;
                con.Close();

                MessageBox.Show("Sanal kart numaranız güncellenmiştir. Güncel kart bilgilerinize yeniden giriş yaparak ulaşabilirsiniz. ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bakiye bakiye = new Bakiye();
            bakiye.Show();

        }

        private void label_Kartno_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SanalKartIslemYonetici sanalKartIslemYonetici = new SanalKartIslemYonetici();
            sanalKartIslemYonetici.Show();



        }
    }
}
