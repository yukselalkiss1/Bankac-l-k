using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _202503066_yukselalkis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(51, 122, 183);
        }

        private void kullanicigiris_Click(object sender, EventArgs e)
        {
            KullaniciGiriş kullanicigrs = new KullaniciGiriş();
            kullanicigrs.Show();
            this.Hide();

        }

        private void admingiris_Click(object sender, EventArgs e)
        {
            Admingiris admgrs = new Admingiris();
            admgrs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
