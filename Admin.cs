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
    public partial class Admin : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlCommand cmd1;
        DataSet ds;
        SqlDataAdapter da;

        public static string Sqlcon = @"Data Source=DESKTOP-9C0C8UB\SQLEXPRESS; Initial Catalog=202503066_yukselalkis; Integrated Security=True";

        public Admin()
        {
            InitializeComponent();
        }


        void kayitGetir()
        {
            con = new SqlConnection(Sqlcon);
            da = new SqlDataAdapter("select *from tbl_basvuru",con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_basvuru");

            dataGridView1.DataSource = ds.Tables["tbl_basvuru"];
            con.Close();

        }
        /*public void listele()
        {

            con = new SqlConnection(Sqlcon);
            cmd = new SqlCommand();

            con.Open();
            cmd.CommandText = ("select * from tbl_basvuru WHERE TCNO = @TCNO");

            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@TCNO", KullaniciGiriş.TCNO);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                labeliban.Text = dr["IBAN"].ToString();
                label2.Text = dr["BAKIYE"].ToString();
            }

            con.Close();
        }*/



        private void Admin_Load(object sender, EventArgs e)
        {
           // dateTimePicker1.Value = DateTime.UtcNow;

            kayitGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            label9.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label10.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label11.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            label12.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            label13.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            label14.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            label15.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

       private void sutunsilme()
        {
            con = new SqlConnection(Sqlcon);
             string sorgu1 = "delete from tbl_basvuru where TCNO=@tc and ANNEKIZLIKSOYADI=@dt and DOGUMYERI=@dy and TELNO=@tel and GELIR=@gelir and VARLIK=@varlik and KREDI=@kredi";
             cmd1 = new SqlCommand();

             cmd1.Parameters.AddWithValue("tc", label9.Text);
             cmd1.Parameters.AddWithValue("dt",label10.Text );
             cmd1.Parameters.AddWithValue("dy", label11.Text);
             cmd1.Parameters.AddWithValue("tel", label12.Text);
             cmd1.Parameters.AddWithValue("gelir", label13.Text);
             cmd1.Parameters.AddWithValue("varlik", label14.Text);
             cmd1.Parameters.AddWithValue("kredi", label15.Text);
             con.Open();
             cmd1.Connection = con;
             cmd1.CommandText = sorgu1;
             cmd1.ExecuteNonQuery();
             con.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Sqlcon);
            string sorgu = "insert into tbl_onaylanan (TCNO,ANNEKIZLIKSOYADI,DOGUMYERI,TELNO,GELIR,VARLIK,KREDI) values (@tc,@dt,@dy,@tel,@gelir,@varlik,@kredi)";
            cmd = new SqlCommand();
                    
            cmd.Parameters.AddWithValue("tc",label9.Text);
            cmd.Parameters.AddWithValue("dt", label10.Text);
            cmd.Parameters.AddWithValue("dy", label11.Text);
            cmd.Parameters.AddWithValue("tel", label12.Text);
            cmd.Parameters.AddWithValue("gelir", label13.Text);
            cmd.Parameters.AddWithValue("varlik", label14.Text);
            cmd.Parameters.AddWithValue("kredi", label15.Text);

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Kredi basvurusu onaylanmistir");
            sutunsilme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Sqlcon);
            string sorgu = "insert into tbl_redkredi (TCNO,ANNEKIZLIKSOYADI,DOGUMYERI,TELNO,GELIR,VARLIK,KREDI,ACIKLAMA) values (@tc,@dt,@dy,@tel,@gelir,@varlik,@kredi,@aciklama)";
            cmd = new SqlCommand();
           

            cmd.Parameters.AddWithValue("tc", label9.Text);
            cmd.Parameters.AddWithValue("dt", label10.Text);
            cmd.Parameters.AddWithValue("dy", label11.Text);
            cmd.Parameters.AddWithValue("tel", label12.Text);
            cmd.Parameters.AddWithValue("gelir", label13.Text);
            cmd.Parameters.AddWithValue("varlik", label14.Text);
            cmd.Parameters.AddWithValue("kredi", label15.Text);
            cmd.Parameters.AddWithValue("aciklama", textBox1.Text);

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Kredi basvurusu red edilmistir");
            sutunsilme();
        }

        private void button3_Click(object sender, EventArgs e)
        { 
        }
    }
}
