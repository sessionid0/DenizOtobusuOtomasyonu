using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace HadoTestApp
{
    class Veritabani
    {
        public static string kartNumarasi="";
        public static string usersession = "";
        public static string userpass = "";
        public static int kartbakiyesi = 0;
        public static string nameData = "";
        public static string surnameData = "";
        public static string hesCode = "";


        Veritabani()
        {

        }
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-F4HJ465\SQLEXPRESS;Initial Catalog=dotobusbase;Integrated Security=True";

        public static DataGridView GridTumunuDoldur(DataGridView gridim, string selectSqlSorgu)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from "+selectSqlSorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, selectSqlSorgu);

            gridim.DataSource = ds.Tables[selectSqlSorgu];
            con.Close();
            return gridim;
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static bool LoginDataKontrolYonetici(string kullaniciadi, string sifre)
        {
            string passhash;
            passhash = Veritabani.MD5Sifrele((sifre));
            string sorgu = "select * from t_admin where rousername =@user and ropass =@pass";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", kullaniciadi);
            cmd.Parameters.AddWithValue("@pass", passhash);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                userpass = passhash;
                usersession = kullaniciadi;
                kartNumarasi = (dr["rokartno"].ToString());
                nameData = (dr["roname"].ToString());
                surnameData = (dr["rosurname"].ToString());
                kartbakiyesi = Convert.ToInt32(dr["robakiye"]);
                hesCode = (dr["roheskod"].ToString());
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }

        }

        public static void LoginDataKontrol(string kullaniciadi, string sifre)
        {
            string passhash;
            passhash = Veritabani.MD5Sifrele((sifre));
            string sorgu = "select * from t_user where username =@user and password =@pass";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", kullaniciadi);
            cmd.Parameters.AddWithValue("@pass", passhash);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                userpass = passhash;
                usersession = kullaniciadi;
                kartNumarasi = (dr["kartno"].ToString());
                nameData = (dr["name"].ToString());
                surnameData = (dr["surname"].ToString());
                kartbakiyesi = Convert.ToInt32(dr["kartbakiye"]);
                hesCode= (dr["heskod"].ToString());
                con.Close();
               
            }
            else
            {
                con.Close();
                
            }

        }

        public static bool LoginKontrol(string kullaniciadi, string sifre)
        {
            string passhash;
            passhash = Veritabani.MD5Sifrele((sifre));
            string sorgu = "select username, password from t_user where username =@user and password =@pass";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", kullaniciadi);
            cmd.Parameters.AddWithValue("@pass", passhash);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                
               
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }

        }

        public static string MD5Sifrele(string sMetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sMetin);

            //Dizinin hash değeri çıkarılıyor
            dizi = md5.ComputeHash(dizi);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte item in dizi)
            {
                stringBuilder.Append(item.ToString("x2").ToLower());
            }


            return stringBuilder.ToString();
        }

        public static string SHA256Sifrele(string sifremetin)
        {
            SHA256 sHA256Hash = SHA256.Create();
            //byte[] dizi = sHA256Hash.ComputeHash(Encoding.UTF8.GetBytes(sifremetin));
            byte[] dizi = Encoding.UTF8.GetBytes(sifremetin);
            dizi = sHA256Hash.ComputeHash(dizi);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte item in dizi)
            {
                stringBuilder.Append(item.ToString("x2").ToLower());
            }


            return stringBuilder.ToString();
        }

        public static void KomutYolla(string sorgu)
        {
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static bool BaglantiDurum()
        {
            //Veritabanı bağlantı kontrolü
            using(con=new SqlConnection(SqlCon))
            {
                try
                {
                    con.Open();
                    //MessageBox.Show("Bağlantı kuruldu.");
                    return true;
                }
                catch (SqlException)
                {
                    //MessageBox.Show("Bağlantı kurulamadı.");
                        return false;
                }
            }
        }
        public static void KomutYollaParametreli(string sql, SqlCommand cmd)
        {
            con = new SqlConnection(SqlCon);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
