using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _202503066_yukselalkis
{
    public partial class YeniKayitFormcs : Form
    {
       
        static SqlConnection con;
        //static SqlDataAdapter da;
        static SqlCommand cmd;
        //DataSet ds;
        public static string Sqlcon = @"Data Source=DESKTOP-9C0C8UB\SQLEXPRESS; Initial Catalog=202503066_yukselalkis; Integrated Security=True";


        public YeniKayitFormcs()
        {
            InitializeComponent();
        }

        private void YeniKayitFormcs_Load(object sender, EventArgs e)

        {
            
            this.BackColor = Color.FromArgb(51, 122, 183);
            maskedTcYeniKayitBox.PromptChar = ' ';
            maskedsifreBox2.PromptChar = ' ';
            comboBox1.Items.Add("En sevdiğiniz yemek");
            comboBox1.Items.Add("En sevdiğiniz renk");
            comboBox1.Items.Add("En sevdiğiniz arkadaşınız");
            comboBox1.Items.Add("Uğurlu sayınız");
            
            DevamBtn.Enabled = false;
            
        }


        public void checkkontrol()
        {
            if(checkBox1.Checked==true&& checkBox2.Checked==true)
            {
                DevamBtn.Enabled = true;
            }
        }


        

        private void DevamBtn_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            double rstgliban = rastgele.Next(99999999,999999999); 
            double rstgliban2 = rastgele.Next(99999999, 999999999);
            double rstgliban3 = rastgele.Next(9999999, 99999999);
                
            string normaliban = (rstgliban.ToString() + rstgliban2.ToString() + rstgliban3.ToString());
            con = new SqlConnection(Sqlcon);
            string sql = "insert into tbl_kullanici (TCNO,IBAN,AD,SOYAD,SIFRE,TELNO,DOGUMTARIHI,DOGUMYERI,ANNEKIZLIKSOYADI,GUVENLIKSORUSU,GUVENLIKSORUSUCEVABI,BAKIYE) values (@tcno,@iban,@ad,@soyad,@sifre,@telno,@dogumtarihi,@dogumyeri,@annekizli,@guvenliksorusu,@guvenlikcevap,@bakiye)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@tcno", maskedTcYeniKayitBox.Text);
            cmd.Parameters.AddWithValue("@iban",normaliban);
            cmd.Parameters.AddWithValue("@ad", adTextBox1.Text);
            cmd.Parameters.AddWithValue("@soyad", soyadtextBox2.Text);
            cmd.Parameters.AddWithValue("@sifre", BankaOtomasyonu.Sifreleme(maskedsifreBox2.Text));
            cmd.Parameters.AddWithValue("@telno", maskedtelTextBox1.Text);
            cmd.Parameters.AddWithValue("@dogumtarihi", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@dogumyeri", YertextBox3.Text);
            cmd.Parameters.AddWithValue("@annekizli", AnnetextBox4.Text);
            cmd.Parameters.AddWithValue("@guvenliksorusu", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@guvenlikcevap", CevaptextBox5.Text);
            cmd.Parameters.AddWithValue("@bakiye", BakiyemaskedTextBox3.Text);
           // cmd.Parameters.AddWithValue("@krediler", "yok"); 
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();


            KullaniciGiriş kullanicigrs = new KullaniciGiriş();
            kullanicigrs.Show();
            this.Hide();
        }

        public void EklemeSorgu(string sql)
        {
            con = new SqlConnection(Sqlcon);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkkontrol();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkkontrol();
        }

        private void yenikytanasayfabtn_Click(object sender, EventArgs e)
        {
            KullaniciGiriş kullanicigrs = new KullaniciGiriş();
            kullanicigrs.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://kvkk.gov.tr/Icerik/6844/2020-765");
        }
    }
}
