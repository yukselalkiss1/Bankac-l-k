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
using System.Diagnostics;

namespace _202503066_yukselalkis
{
    public partial class KullaniciAnasayfa : Form
    {
        public string iban;
        static SqlConnection con;
        //static SqlDataAdapter da;
        static SqlCommand cmd;

        //DataSet ds;
        public static string Sqlcon = @"Data Source=DESKTOP-9C0C8UB\SQLEXPRESS; Initial Catalog=202503066_yukselalkis; Integrated Security=True";

        public KullaniciAnasayfa()
        {
            InitializeComponent();
        }


        private void FormGetir(Form frm)
        {
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel4.Controls.Add(frm);
            frm.Show();
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
                labeliban.Text = dr["IBAN"].ToString();
                label2.Text = dr["BAKIYE"].ToString();
            }

            con.Close();
        }

        private void KullaniciAnasayfa_Load(object sender, EventArgs e)
        {


            anasayfacikisbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BackColor = Color.White;

            panel2.BackColor = Color.FromArgb(51, 122, 183);
            button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(51, 122, 183);
            paratransferibtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(51, 122, 183);
            btnCopyIban.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(51, 122, 183);
            paraCekbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(51, 122, 183);
            PiyasalarBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(51, 122, 183);
            panel6.BackColor = Color.White;
            btnCopyIban.BackColor = Color.White;

            con = new SqlConnection(Sqlcon);
            cmd = new SqlCommand();
           
            listele();

        }

        private void anasayfacikisbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paratransferibtn_Click(object sender, EventArgs e)
        {

            iban = labeliban.Text;
            KullaniciGiriş.BAKIYE = label2.Text;
            panel4.Controls.Clear();
            ParaTransferi paratransferifrm = new ParaTransferi();
            FormGetir(paratransferifrm);
        }


        private void paraCekbtn_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            KredilerForm kredifrm = new KredilerForm();
            FormGetir(kredifrm);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel4.Controls.Clear();
            HesapHareketleri hesaps = new HesapHareketleri();
            FormGetir(hesaps);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labeliban.Text);
        }

        private void btnAnaSayfaCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnaSayfaGizle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }




      

        private void PiyasalarBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+menu/istatistikler/doviz+kurlari/saat+basi+belirlenen+doviz+kurlari+ve+altin+fiyatlari");
        }

       
    }

}

