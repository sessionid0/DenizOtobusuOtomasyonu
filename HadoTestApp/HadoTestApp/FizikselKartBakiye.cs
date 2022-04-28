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
    public partial class FizikselKartBakiye : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";
        public FizikselKartBakiye()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "10";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "40";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "20";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "50";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != null) { 
            double bakiyetl = Convert.ToDouble(maskedTextBox1.Text);
            cmd = new SqlCommand();
            string sql = "update t_fcards set fkartbakiye=@bakiye where fkartno=@kartno";
            cmd.Parameters.AddWithValue("@kartno", FizikselKartGoruntule.fkartnum);
            cmd.Parameters.AddWithValue("@bakiye", FizikselKartGoruntule.fkartbakiye + bakiyetl);

            Veritabani.KomutYollaParametreli(sql, cmd);
            MessageBox.Show("Bakiye fiziksel karta yüklenmiştir. Tekrar sorgulama yaparak güncel bakiyenizi görebilirsiniz.");
            this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen alanı doldurun.");
            }
        }
    }
}
