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
using System.Data.Sql;

namespace _202503066_yukselalkis
{
    public partial class KullaniciGiriş : Form
    {
        SqlConnection con;
        //SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
       // public static string IBAN = default;
        public static string TCNO = default;
        public static string BAKIYE = default;
        public static string Sqlcon = @" Data Source=DESKTOP-9C0C8UB\SQLEXPRESS; Initial Catalog=202503066_yukselalkis; Integrated Security=True";



        public KullaniciGiriş()
        {
            InitializeComponent();
           con = new SqlConnection(Sqlcon);
        }

        private void KullaniciGiriş_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(51, 122, 183);
            panel2.BackColor = Color.White;
            textBox1.MaxLength = 11;
            girisBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(51, 122, 183);
            Yenikayitbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(51, 122, 183);
            SifreUnuttumBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(51, 122, 183);
            maskedSifrebox.PromptChar = ' ';
        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Yenikayitbtn_Click(object sender, EventArgs e)
        {
            
            YeniKayitFormcs yenikayitgrs = new YeniKayitFormcs();
            yenikayitgrs.Show();
            this.Hide();
        }

        private void SifreUnuttumBtn_Click(object sender, EventArgs e)
        {
            SifremiUnuttumForm sifremiunuttumfrm = new SifremiUnuttumForm();
            sifremiunuttumfrm.Show();
            this.Hide();
        }



        public void Login()
        {
            
            TCNO = textBox1.Text;
            
            string sorgu = "select *from tbl_kullanici where TCNO=@tcno and SIFRE=@sifre";

            con = new SqlConnection(Sqlcon);
            cmd = new SqlCommand(sorgu, con);
            con.Open();
            cmd.Parameters.AddWithValue("@tcno", textBox1.Text);
            cmd.Parameters.AddWithValue("@sifre", BankaOtomasyonu.Sifreleme(maskedSifrebox.Text));
           
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Hosgeldiniz.");
                KullaniciAnasayfa kullanıcıanasayfafrm = new KullaniciAnasayfa();
                kullanıcıanasayfafrm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("TC No veye Sifreniz hatali!");
                textBox1.Clear();
                maskedSifrebox.Clear();
                textBox1.Focus();

            }
            con.Close();

        }
      
        private void girisBtn_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
