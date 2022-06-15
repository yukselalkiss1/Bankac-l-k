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

namespace _202503066_yukselalkis
{
    public partial class HesapHareketleri : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        public static string Sqlcon = @"Data Source=DESKTOP-9C0C8UB\SQLEXPRESS; Initial Catalog=202503066_yukselalkis; Integrated Security=True";
        public HesapHareketleri()
        {
            InitializeComponent();
        }

        private void HesapHareketleri_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void kayitGetir()
        {

            con = new SqlConnection(Sqlcon);
            cmd = new SqlCommand();
            ds = new DataSet();
            con.Open();
            string kayit = "SELECT KISI,ISLEMSAATI,MIKTAR from tbl_hesapozeti where GONDERENTC = @TC";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@TC", KullaniciGiriş.TCNO);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
           
            da.Fill(ds, "tbl_hesapozeti");

            dataGridView1.DataSource = ds.Tables["tbl_hesapozeti"];

            con.Close();
        }
        
       
    }
}
