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
    public partial class ParaTransferi : Form
    {
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlCommand cmd2;
        SqlCommand cmd4;
        SqlConnection con;

        public static string Sqlcon = @"Data Source=DESKTOP-9C0C8UB\SQLEXPRESS; Initial Catalog=202503066_yukselalkis; Integrated Security=True";
        public long krssonuc;
        public long sonuc;
        public static long bakiye;
        public string gonderilenad;
        public string gonderilensoyad;
        public string gonderilentoplam;
        public int sayi1;
        public int sayi2;
        public int toplam;
        public string toplam1;
        
        public ParaTransferi()
        {
            InitializeComponent();
        }

        private void ParaTransferi_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            paragonderbtn.Enabled = true;
            maskedTutarBox1.PromptChar = ' ';
            KRSBAKIYELBL.Hide();
            BAKIYELBL.Hide();
            paragonderbtn.BackColor = Color.FromArgb(51, 122, 183);
            paragonderbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(51, 122, 183);
            //this.BackColor = Color.FromArgb(51, 122, 183);
            //  paragonderbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(51, 122, 183);
            // paragonderbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(51, 122, 183);
            Random rastgele = new Random();
            int sayi1 = rastgele.Next(0,100);
            int sayi2 = rastgele.Next(0,50);
            toplam = sayi1 + sayi2;
            toplam1 = (sayi1.ToString() + "+" + sayi2.ToString());
            label5.Text = toplam1;

        }
        public void listele()
        {
            con = new SqlConnection(Sqlcon);
            cmd4 = new SqlCommand();

            con.Open();
            cmd4.CommandText = ("select AD,SOYAD from tbl_kullanici WHERE IBAN = @iban");

            cmd4.Connection = con;
            cmd4.Parameters.AddWithValue("@iban",textBox1.Text);

            SqlDataReader dr = cmd4.ExecuteReader();

            if (dr.Read())
            {
                gonderilenad = dr["AD"].ToString();
                gonderilensoyad = dr["SOYAD"].ToString();
                gonderilentoplam = gonderilenad + " " + gonderilensoyad;
            }

            con.Close();
        }

        private void paragonderbtn_Click(object sender, EventArgs e)
        {
            listele();
            con = new SqlConnection(Sqlcon);
            cmd = new SqlCommand();

            con.Open();
            cmd.CommandText = ("select * from tbl_kullanici WHERE IBAN = @iban ");

            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@iban", textBox1.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                KRSBAKIYELBL.Text = dr["BAKIYE"].ToString();
            }

            if (textBox1.TextLength != 26 || textBox2.Text == "" || maskedTutarBox1.Text == "" )
            {
                MessageBox.Show("Bos birakmayiniz ");
            }


            else if (Convert.ToInt64(KullaniciGiriş.BAKIYE) > Convert.ToInt64(maskedTutarBox1.Text))
            {
                krssonuc = Convert.ToInt64(KRSBAKIYELBL.Text) + Convert.ToInt64(maskedTutarBox1.Text);
                sonuc = Convert.ToInt64(KullaniciGiriş.BAKIYE) - Convert.ToInt64(maskedTutarBox1.Text);
                bakiye = sonuc;
                con = new SqlConnection(Sqlcon);
                cmd = new SqlCommand();
                cmd1 = new SqlCommand();
                cmd2 = new SqlCommand();

                con.Open();
                string sorgu = ("update tbl_kullanici set BAKIYE=@bakiye where IBAN=@iban");
                string sorgu1 = ("update tbl_kullanici set BAKIYE=@bakiye1 where TCNO=@tc");
                string sorgu2 = ("insert into tbl_hesapozeti(GONDERENTC,KISI,ISLEMSAATI,MIKTAR) VALUES (@gtc,@kisi,@islemsaati,@miktar)");
                
                cmd.CommandText = sorgu;
                cmd1.CommandText = sorgu1;
                cmd2.CommandText = sorgu2;
                cmd.Connection = con;
                cmd1.Connection = con;
                cmd2.Connection = con;
                cmd.Parameters.AddWithValue("@bakiye", krssonuc.ToString());
                cmd.Parameters.AddWithValue("@iban", textBox1.Text);
                cmd1.Parameters.AddWithValue("@bakiye1", sonuc.ToString());
                cmd1.Parameters.AddWithValue("@tc", KullaniciGiriş.TCNO);
                cmd2.Parameters.AddWithValue("@gtc", KullaniciGiriş.TCNO);
                cmd2.Parameters.AddWithValue("@kisi", gonderilentoplam);
                cmd2.Parameters.AddWithValue("@islemsaati", dateTimePicker1.Value);
                cmd2.Parameters.AddWithValue("@miktar", maskedTutarBox1.Text);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();

                KullaniciAnasayfa kullaniciAnasayfa = new KullaniciAnasayfa();
                kullaniciAnasayfa.label2.Text = bakiye.ToString();
                textBox1.Text = "";
                textBox2.Text = "";
                maskedTutarBox1.Text = "";
                richTextBox1.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                MessageBox.Show("OGRENCIYE ULASILDI ");


            }
            else
            {
                MessageBox.Show("Kendi Tutarınızdan Fazla Gönderemezsiniz");
            }

            con.Close();

        }
    }
}
