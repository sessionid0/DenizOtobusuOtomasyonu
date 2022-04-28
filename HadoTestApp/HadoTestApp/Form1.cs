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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";
        //user Id=sa, password=xxxxxx
        // Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True
        public static int clickedWhere;
        



        public Form1()
        {
            InitializeComponent();
            //this.formborderstyle = system.windows.forms.formborderstyle.fixedsingle;
            //this.maximizebox = false;
            //this.minimizebox = false;
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testdatabaseDataSet1.tb_admin' table. You can move, or remove it, as needed.
            //GridDoldur();
        

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            FormSifreUnuttum formSifreUnuttum = new FormSifreUnuttum();
            formSifreUnuttum.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormYeniKayit formYeniKayit = new FormYeniKayit();
            formYeniKayit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            HadoPanelUser hadoPanelUser = new HadoPanelUser();
            string passhash;
            passhash = Veritabani.MD5Sifrele((textBox2.Text));
            string sorgu = "select * from t_user where username =@user and password =@pass";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", passhash);
            con.Open();
            dr = cmd.ExecuteReader();
           Veritabani.LoginDataKontrol(textBox1.Text, textBox2.Text);
            clickedWhere = 0;
            if (dr.Read())
            {
               
               
                hadoPanelUser.Show();
            
                this.Hide();

                con.Close();
               
            }
            else
            {
                con.Close();
                MessageBox.Show("Kullanıcı adı veya şifre hatalıdır.");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                
            }
            //string passhash;
            //passhash = Veritabani.MD5Sifrele((textBox2.Text));
            //string sorgu = "select username, password from t_user where username = '"+textBox1.Text+"' and password = '"+passhash+"'";
            //con = new SqlConnection(SqlCon);
            //cmd = new SqlCommand(sorgu, con);

            //con.Open();
            //dr = cmd.ExecuteReader();


        }



        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void şifreDeğiştirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifreDegisikligi sifre = new SifreDegisikligi();
            sifre.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            
            string passhash;
            passhash = Veritabani.MD5Sifrele((textBox2.Text));
            string sorgu = "select * from t_admin where rousername =@user and ropass =@pass";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", passhash);
            con.Open();
            dr = cmd.ExecuteReader();
            Veritabani.LoginDataKontrolYonetici(textBox1.Text, textBox2.Text);
            clickedWhere = 1;
            if (dr.Read())
            {

                HadoPanelAdmin hadoPanelAdmin = new HadoPanelAdmin();
                hadoPanelAdmin.Show();

                this.Hide();

                con.Close();

            }
            else
            {
                con.Close();
                MessageBox.Show("Kullanıcı adı veya şifre hatalıdır.");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
        }
    }
}
