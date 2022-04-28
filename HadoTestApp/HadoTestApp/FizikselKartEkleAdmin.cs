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
    public partial class FizikselKartEkleAdmin : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";
        public FizikselKartEkleAdmin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void FizikselKartEkleAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dotobusbaseDataSet1.t_fcards' table. You can move, or remove it, as needed.
            this.t_fcardsTableAdapter1.Fill(this.dotobusbaseDataSet1.t_fcards);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kart = Veritabani.RandomString(11);
            con = new SqlConnection(SqlCon);
            string sql = "insert into t_fcards (fkartno, fkartbakiye) values (@kartno, @bakiye)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@kartno", kart);
            cmd.Parameters.AddWithValue("@bakiye", 0);

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            string olustukartno = kart;
            con.Close();

            MessageBox.Show("Fiziksel kart numarası başarıyla oluşturuldu.  " + olustukartno);
            FizikselKartEkleAdmin_Load(sender, e);
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "delete from t_fcards where fkartno=@kartno";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@kartno", textBox2.Text);
            Veritabani.KomutYollaParametreli(sql, cmd);

            string sqlh = "insert into t_fcards (fkartno, fkartbakiye, fkartsahipad, fkartsahipsoyad) values (@kartno, @bakiye, @ad, @soyad)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@kartno", textBox2.Text);
            cmd.Parameters.AddWithValue("@bakiye", textBox3.Text);
            cmd.Parameters.AddWithValue("@ad", textBox6.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox5.Text);
            Veritabani.KomutYollaParametreli(sqlh, cmd);

            MessageBox.Show("Başarıyla güncellenmiştir.");
            FizikselKartEkleAdmin_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "delete from t_fcards where fkartno=@kartno";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@kartno", textBox2.Text);
            Veritabani.KomutYollaParametreli(sql, cmd);

            MessageBox.Show("Başarıyla silindi.");
            FizikselKartEkleAdmin_Load(sender, e);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
