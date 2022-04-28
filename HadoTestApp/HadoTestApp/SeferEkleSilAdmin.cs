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
    public partial class SeferEkleSilAdmin : Form
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";
        public SeferEkleSilAdmin()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void SeferEkleSilAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dotobusbaseDataSet2.t_seferinfo' table. You can move, or remove it, as needed.
            this.t_seferinfoTableAdapter2.Fill(this.dotobusbaseDataSet2.t_seferinfo);
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string sqlh = "insert into t_seferinfo (seabusname, seabusaktifgun, seabusaktifsaat, seabushat) values (@name, @gun, @saat, @hat)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@name", textBox6.Text);
            cmd.Parameters.AddWithValue("@gun", textBox5.Text);
            cmd.Parameters.AddWithValue("@saat", textBox2.Text);
            cmd.Parameters.AddWithValue("@hat", textBox3.Text);
            Veritabani.KomutYollaParametreli(sqlh, cmd);

            MessageBox.Show("Başarıyla oluşuturuldu.");
            SeferEkleSilAdmin_Load(sender, e);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "delete from t_seferinfo where doID=@id ";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@id", textBox4.Text);
            Veritabani.KomutYollaParametreli(sql, cmd);

            string sqlh = "insert into t_seferinfo (seabusname, seabusaktifgun, seabusaktifsaat, seabushat) values (@name, @gun, @saat, @hat)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@name", textBox6.Text);
            cmd.Parameters.AddWithValue("@gun", textBox5.Text);
            cmd.Parameters.AddWithValue("@saat", textBox2.Text);
            cmd.Parameters.AddWithValue("@hat", textBox3.Text);
            Veritabani.KomutYollaParametreli(sqlh, cmd);

            MessageBox.Show("Başarıyla güncellenmiştir.");
            SeferEkleSilAdmin_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            textBox5.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "delete from t_seferinfo where doID=@id ";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@id", textBox4.Text);
            Veritabani.KomutYollaParametreli(sql, cmd);

            MessageBox.Show("İlgili kayıt silindi.");
            SeferEkleSilAdmin_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
