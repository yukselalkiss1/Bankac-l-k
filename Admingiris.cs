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
    public partial class Admingiris : Form
    {
        
        public Admingiris()
        {
            InitializeComponent();
        }

        private void Admingiris_Load(object sender, EventArgs e)
        {
            this.BackColor=Color.FromArgb(51, 122, 183);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ISTEBANKA1" && maskedTextBox1.Text == "istebanka1")
            {
                Admin admfrm = new Admin();
                admfrm.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Kullanici adi ve ya sifre yanlis ");
        }
    }
}
