namespace cfinalproje
{
    partial class giris
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.txt_kadi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(185, 251);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(110, 40);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // txt_kadi
            // 
            this.txt_kadi.Location = new System.Drawing.Point(185, 89);
            this.txt_kadi.Name = "txt_kadi";
            this.txt_kadi.Size = new System.Drawing.Size(161, 26);
            this.txt_kadi.TabIndex = 3;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(185, 152);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(161, 26);
            this.txt_sifre.TabIndex = 4;
            this.txt_sifre.Text = "  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kadi);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.label2);
            this.Name = "giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox txt_kadi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label1;
    }
}

