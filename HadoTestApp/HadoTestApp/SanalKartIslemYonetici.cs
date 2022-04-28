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
    public partial class SanalKartIslemYonetici : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";
        public static string olustukartno = "";
        public SanalKartIslemYonetici()
        {
            InitializeComponent();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Veritabani.kartNumarasi == "" || olustukartno=="" )
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
               olustukartno = kart;
                con.Close();

                MessageBox.Show("Sanal kartınız başarıyla oluşturuldu. " + olustukartno);


            }
            else
            {
                MessageBox.Show(@"Sanal kart hesabınızda zaten bulunmaktadır. Dilerseniz sanal kart numaranızı ""Sanal Kartımı Görüntüle"" bölümünden güncelleyebilirsiniz.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guncelkartno = Veritabani.kartNumarasi;
            SanalKartOlusturGoruntule sanalKartGoruntule = new SanalKartOlusturGoruntule();
            sanalKartGoruntule.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HesKod hesKod = new HesKod();
            hesKod.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FizikselKartGoruntule fizikselKartGoruntule = new FizikselKartGoruntule();
            fizikselKartGoruntule.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HadoPanelAdmin hadoPanelAdmin = new HadoPanelAdmin();
            hadoPanelAdmin.Show();
            this.Hide();
        }
    }
}
