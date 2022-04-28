using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HadoTestApp
{
    public partial class SeferBilgileri : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";
        //user Id=sa, password=xxxxxx

        void GridDoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("Select seabusname [Deniz Otobüsü Adı], seabusaktifgun [Aktif günler], seabusaktifsaat [Aktif saatler], seabushat [Hat İsmi] from t_seferinfo", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "t_seferinfo");

            

        }
       

        public SeferBilgileri()
        {
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            GridDoldur();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SeferBilgileri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dotobusbaseDataSet.t_seferinfo' table. You can move, or remove it, as needed.
            this.t_seferinfoTableAdapter.Fill(this.dotobusbaseDataSet.t_seferinfo);
            // TODO: This line of code loads data into the 'dotobusbaseDataSet.t_seferinfo' table. You can move, or remove it, as needed.
            this.t_seferinfoTableAdapter.Fill(this.dotobusbaseDataSet.t_seferinfo);
            // TODO: This line of code loads data into the 'dotobusbaseDataSet.t_seferinfo' table. You can move, or remove it, as needed.
            this.t_seferinfoTableAdapter.Fill(this.dotobusbaseDataSet.t_seferinfo);
            // TODO: This line of code loads data into the 'dotobusbaseDataSet.t_seferinfo' table. You can move, or remove it, as needed.
            this.t_seferinfoTableAdapter.Fill(this.dotobusbaseDataSet.t_seferinfo);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HadoPanelUser hadoPanelUser = new HadoPanelUser();
            hadoPanelUser.Show();
            this.Hide();
        }
    }
}
