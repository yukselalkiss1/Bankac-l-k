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
    public partial class SifremiUnuttumForm : Form
    {
        public int toplama1;
        public int sayi1;
        public int sayi2;
        public string toplama;
        SqlConnection con;
        SqlCommand cmd;

        public static string Sqlcon = @"Data Source=DESKTOP-9C0C8UB\SQLEXPRESS; Initial Catalog=202503066_yukselalkis; Integrated Security=True";

        public SifremiUnuttumForm()
        {
            InitializeComponent();
        }

        private void SifremiUnuttumForm_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(51, 122, 183);
            maskedSifreUnuttumSifreBox1.PromptChar = ' ';
            maskedSifreTekrarBox1.PromptChar = ' ';
            SifreUnuttumDvmBTN.FlatAppearance.BorderColor= System.Drawing.Color.FromArgb(51, 122, 183);
            textBox3.MaxLength = 11;
            textBox3.Focus();
            Random rastgele = new Random();
            int sayi1 = rastgele.Next(0,100);
            int sayi2 = rastgele.Next(0,50);
            toplama = sayi1.ToString() + "+" + sayi2.ToString();
            label5.Text = toplama;
            toplama1 = sayi1 + sayi2;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciGiriş kullanicigrs = new KullaniciGiriş();
            kullanicigrs.Show();
            this.Hide();
        }

        private void SifreUnuttumDvmBTN_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Sqlcon);
            cmd = new SqlCommand();

            con.Open();
            cmd.CommandText = ("select * from tbl_kullanici WHERE TCNO = @TCNO ");

            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@TCNO", textBox3.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                label6.Text = dr["GUVENLIKSORUSUCEVABI"].ToString();
            }

            con.Close();
            if (maskedSifreUnuttumSifreBox1.Text == "" || maskedSifreTekrarBox1.Text == "" || textgvlikcvpbox.Text == "" || textBox3.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız");
            }
           else if (maskedSifreUnuttumSifreBox1.Text==maskedSifreTekrarBox1.Text && label6.Text==textgvlikcvpbox.Text && textBox2.Text==toplama1.ToString() ) 
            {
                con = new SqlConnection(Sqlcon);
                cmd = new SqlCommand();
                con.Open();
                string sorgu = ("update tbl_kullanici set SIFRE=@sifre where TCNO=@tc");
                cmd.CommandText = sorgu;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@sifre", BankaOtomasyonu.Sifreleme(maskedSifreUnuttumSifreBox1.Text));
                cmd.Parameters.AddWithValue("@tc", textBox3.Text);
               
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Şifreniz başarıyla değiştirilmiştir");

                KullaniciGiriş kullanicigrs = new KullaniciGiriş();
                kullanicigrs.Show();
                this.Hide();

            }
            else if (maskedSifreUnuttumSifreBox1.Text != maskedSifreTekrarBox1.Text)
            {
                MessageBox.Show("Sifreleriniz uyuşmuyor.");
            }
            else
            {
                MessageBox.Show("Bilgilerini kontrol ediniz");
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength == 11)
            {
                con = new SqlConnection(Sqlcon);
                cmd = new SqlCommand();

                con.Open();
                cmd.CommandText = ("select * from tbl_kullanici WHERE TCNO = @TCNO");

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@TCNO", textBox3.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    label2.Text = dr["GUVENLIKSORUSU"].ToString();
                }

                con.Close();
            }
            else 
            {
                label2.Text = "Güvenlik sorusu";
            }
        }





        
    }
}
