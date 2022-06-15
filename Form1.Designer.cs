
namespace _202503066_yukselalkis
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.admingiris = new System.Windows.Forms.Button();
            this.kullanicigiris = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 125);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // admingiris
            // 
            this.admingiris.BackColor = System.Drawing.Color.White;
            this.admingiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admingiris.Location = new System.Drawing.Point(12, 178);
            this.admingiris.Name = "admingiris";
            this.admingiris.Size = new System.Drawing.Size(185, 58);
            this.admingiris.TabIndex = 1;
            this.admingiris.Text = "Admin";
            this.admingiris.UseVisualStyleBackColor = false;
            this.admingiris.Click += new System.EventHandler(this.admingiris_Click);
            // 
            // kullanicigiris
            // 
            this.kullanicigiris.BackColor = System.Drawing.Color.White;
            this.kullanicigiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanicigiris.Location = new System.Drawing.Point(203, 178);
            this.kullanicigiris.Name = "kullanicigiris";
            this.kullanicigiris.Size = new System.Drawing.Size(187, 58);
            this.kullanicigiris.TabIndex = 2;
            this.kullanicigiris.Text = "Kullanıcı";
            this.kullanicigiris.UseVisualStyleBackColor = false;
            this.kullanicigiris.Click += new System.EventHandler(this.kullanicigiris_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(403, 266);
            this.Controls.Add(this.kullanicigiris);
            this.Controls.Add(this.admingiris);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "anagiris";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button admingiris;
        private System.Windows.Forms.Button kullanicigiris;
        private System.Windows.Forms.Button button1;
    }
}

