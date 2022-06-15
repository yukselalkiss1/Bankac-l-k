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
using System.Globalization;

namespace _202503066_yukselalkis
{
    public partial class KredilerForm : Form
    {


        SqlConnection con;
        SqlCommand cmd;
        public static string Sqlcon = @"Data Source=DESKTOP-9C0C8UB\SQLEXPRESS; Initial Catalog=202503066_yukselalkis; Integrated Security=True";
        double tutar = 0;

        public int sayi1;
        public int sayi2;
        public int toplam;
        public string toplam1;
        public string dt;
        public string dy;
        public string tel;
        public string bune;

        public KredilerForm()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void KredilerForm_Load(object sender, EventArgs e)
        {
            toolTip1.AutomaticDelay = 200;
            toolTip1.SetToolTip(this.textBox4, "Sahip olduğunuz ev araba vs.");
            basvurbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(51, 122, 183);


            comboBox1.Items.Add("1.000"); 
            comboBox1.Items.Add("10.000");
            comboBox1.Items.Add("50.000");
            comboBox1.Items.Add("100.000");
            listele();

            Random rastgele = new Random();
            int sayi1 = rastgele.Next(0, 100);
            int sayi2 = rastgele.Next(0, 50);
            toplam = sayi1 + sayi2;
            toplam1 = (sayi1.ToString() + "+" + sayi2.ToString());
            label6.Text = toplam1;
           label12.Hide();
           label13.Hide(); 
           label14.Hide();

           
       
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          if(comboBox1.Text== "1.000")
            {
                double faizorani1 = 1.79;
                tutar = 1000 + (faizorani1 * 1000);
                label10.Text = tutar.ToString();
            }

            else if (comboBox1.Text == "10.000")
            {
                double faizorani2 = 1.85;
                tutar = 10000 + (10000 * faizorani2);
                label10.Text = tutar.ToString();
            }

            if (comboBox1.Text == "50.000")
            {
                double faizorani3 = 1.94;
                tutar = 50000 + (50000 * faizorani3);
                label10.Text = tutar.ToString();
            }

            if (comboBox1.Text == "100.000")
            {
                double faizorani4 = 2.04;
                tutar = 100000 + (100000 * faizorani4);
                label10.Text = tutar.ToString();
            }

        }

        public void listele()
        {

            con = new SqlConnection(Sqlcon);
            cmd = new SqlCommand();

            con.Open();
            cmd.CommandText = ("select * from tbl_kullanici WHERE TCNO = @TCNO");

            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@TCNO", KullaniciGiriş.TCNO);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                dt = dr["ANNEKIZLIKSOYADI"].ToString();
                dy = dr["DOGUMYERI"].ToString();
                tel = dr["TELNO"].ToString();
                label12.Text = dt;
                label13.Text = dy;
                label14.Text = tel;
            }

            con.Close();
        }

        private void basvurbtn_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "" || textBox1.Text == "" || maskedTextBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("BOS BIRAKMA");
            }

            else if (KullaniciGiriş.TCNO == maskedTextBox1.Text && dt == textBox2.Text && dy == textBox1.Text && tel == maskedTextBox2.Text && textBox5.Text == toplam.ToString())
            {
                con = new SqlConnection(Sqlcon);
                string sorgu = "insert into tbl_basvuru(TCNO,ANNEKIZLIKSOYADI,DOGUMYERI,TELNO,GELIR, VARLIK,KREDI) VALUES (@tc,@dt,@dy,@tel,@gelir,@varlik,@kredi)";
                cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@tc", maskedTextBox1.Text);
                cmd.Parameters.AddWithValue("@dt", textBox2.Text);
                cmd.Parameters.AddWithValue("@dy", textBox1.Text);
                cmd.Parameters.AddWithValue("@tel", maskedTextBox2.Text);
                cmd.Parameters.AddWithValue("@gelir", textBox3.Text);
                cmd.Parameters.AddWithValue("@varlik", textBox4.Text);
                cmd.Parameters.AddWithValue("@kredi", tutar);


                con.Open();
                cmd.Connection = con;
                cmd.CommandText = sorgu;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Basvurunuz alinmistir");
                con.Close();
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol Edip Tekara Deneyiniz");
            }
        }

        
    }
}
