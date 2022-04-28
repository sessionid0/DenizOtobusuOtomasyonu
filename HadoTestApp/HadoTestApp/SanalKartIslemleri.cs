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
    public partial class SanalKartIslemleri : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";
        public SanalKartIslemleri()
        {
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SanalKartIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guncelkartno = Veritabani.kartNumarasi;
            SanalKartOlusturGoruntule sanalKartGoruntule = new SanalKartOlusturGoruntule();
            sanalKartGoruntule.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SanalKartOlusturGoruntule sanalKartGoruntule = new SanalKartOlusturGoruntule();
            sanalKartGoruntule.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HesKod hesKod = new HesKod();
            hesKod.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FizikselKartBakiye fizikselKartBakiye = new FizikselKartBakiye();
            fizikselKartBakiye.Show();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Veritabani.kartNumarasi == "")
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

                MessageBox.Show("Sanal kartınız başarıyla oluşturuldu. Değişikliğin geçerli olması için lütfen yeniden giriş yapın." );
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();

        }
            else
            {
                MessageBox.Show(@"Sanal kart hesabınızda zaten bulunmaktadır. Dilerseniz sanal kart numaranızı ""Sanal Kartımı Görüntüle"" bölümünden güncelleyebilirsiniz.");
            }

}

        private void button3_Click_1(object sender, EventArgs e)
        {
            HesKod hesKod = new HesKod();
            hesKod.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            FizikselKartGoruntule fizikselKartGoruntule = new FizikselKartGoruntule();
            fizikselKartGoruntule.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            HadoPanelUser hadoPanelUser = new HadoPanelUser();
            hadoPanelUser.Show();
            this.Hide();
        }
    }
}
