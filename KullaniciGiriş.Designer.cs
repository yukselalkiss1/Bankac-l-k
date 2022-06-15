
namespace _202503066_yukselalkis
{
    partial class KullaniciGiriş
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiriş));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Yenikayitbtn = new System.Windows.Forms.Button();
            this.SifreUnuttumBtn = new System.Windows.Forms.Button();
            this.girisBtn = new System.Windows.Forms.Button();
            this.maskedSifrebox = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cikisbtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 204);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Yenikayitbtn);
            this.panel2.Controls.Add(this.SifreUnuttumBtn);
            this.panel2.Controls.Add(this.girisBtn);
            this.panel2.Controls.Add(this.maskedSifrebox);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cikisbtn);
            this.panel2.Location = new System.Drawing.Point(12, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 238);
            this.panel2.TabIndex = 1;
            // 
            // Yenikayitbtn
            // 
            this.Yenikayitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Yenikayitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yenikayitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenikayitbtn.Location = new System.Drawing.Point(253, 147);
            this.Yenikayitbtn.Name = "Yenikayitbtn";
            this.Yenikayitbtn.Size = new System.Drawing.Size(98, 67);
            this.Yenikayitbtn.TabIndex = 5;
            this.Yenikayitbtn.Text = "Yeni Kayıt";
            this.Yenikayitbtn.UseVisualStyleBackColor = true;
            this.Yenikayitbtn.Click += new System.EventHandler(this.Yenikayitbtn_Click);
            // 
            // SifreUnuttumBtn
            // 
            this.SifreUnuttumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SifreUnuttumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreUnuttumBtn.Location = new System.Drawing.Point(58, 148);
            this.SifreUnuttumBtn.Name = "SifreUnuttumBtn";
            this.SifreUnuttumBtn.Size = new System.Drawing.Size(99, 67);
            this.SifreUnuttumBtn.TabIndex = 4;
            this.SifreUnuttumBtn.Text = "Şifremi Unuttum";
            this.SifreUnuttumBtn.UseVisualStyleBackColor = true;
            this.SifreUnuttumBtn.Click += new System.EventHandler(this.SifreUnuttumBtn_Click);
            // 
            // girisBtn
            // 
            this.girisBtn.BackColor = System.Drawing.Color.White;
            this.girisBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("girisBtn.BackgroundImage")));
            this.girisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.girisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisBtn.ForeColor = System.Drawing.Color.Black;
            this.girisBtn.Location = new System.Drawing.Point(433, 149);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(86, 67);
            this.girisBtn.TabIndex = 3;
            this.girisBtn.UseVisualStyleBackColor = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // maskedSifrebox
            // 
            this.maskedSifrebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedSifrebox.Location = new System.Drawing.Point(225, 85);
            this.maskedSifrebox.Mask = "000000";
            this.maskedSifrebox.Name = "maskedSifrebox";
            this.maskedSifrebox.PasswordChar = '*';
            this.maskedSifrebox.Size = new System.Drawing.Size(158, 24);
            this.maskedSifrebox.TabIndex = 2;
            this.maskedSifrebox.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO";
            // 
            // cikisbtn
            // 
            this.cikisbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cikisbtn.Location = new System.Drawing.Point(444, 190);
            this.cikisbtn.Name = "cikisbtn";
            this.cikisbtn.Size = new System.Drawing.Size(22, 25);
            this.cikisbtn.TabIndex = 6;
            this.cikisbtn.Text = "button1";
            this.cikisbtn.UseVisualStyleBackColor = true;
            this.cikisbtn.Click += new System.EventHandler(this.cikisbtn_Click);
            // 
            // KullaniciGiriş
            // 
            this.AcceptButton = this.girisBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cikisbtn;
            this.ClientSize = new System.Drawing.Size(602, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "KullaniciGiriş";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciGiriş";
            this.Load += new System.EventHandler(this.KullaniciGiriş_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox maskedSifrebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Yenikayitbtn;
        private System.Windows.Forms.Button SifreUnuttumBtn;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Button cikisbtn;
        public System.Windows.Forms.TextBox textBox1;
    }
}