using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;

namespace _202503066_yukselalkis
{
    class BankaOtomasyonu
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        DataSet ds;
        public static string Sqlcon = @"Data Source=DESKTOP-9C0C8UB\SQLEXPRESS; Initial Catalog=202503066_yukselalkis; Integrated Security=True";


        public static bool BaglantiDurum()
        {
            using (con = new SqlConnection(Sqlcon)) 
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (SqlException exp) 
                {
                    MessageBox.Show(exp.Message);
                    return false;
                    
                }   
            }
        }

      
        

        public static string Sifreleme(string sifre)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sifre);
            dizi = md5.ComputeHash(dizi);
            StringBuilder stringbuildersifre = new StringBuilder();
            foreach(byte item in dizi) 
                stringbuildersifre.Append(item.ToString("x2").ToLower());
            return stringbuildersifre.ToString();

        }


    }
   
}
