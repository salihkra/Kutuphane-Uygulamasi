namespace cfinalproje
{
    partial class anasayfa
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
            this.dgw_kitaplar = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.rb_Hayir = new System.Windows.Forms.RadioButton();
            this.rb_Evet = new System.Windows.Forms.RadioButton();
            this.dtp_basimtarihi = new System.Windows.Forms.DateTimePicker();
            this.cbx_yayinevi = new System.Windows.Forms.ComboBox();
            this.txt_yazaradi = new System.Windows.Forms.TextBox();
            this.txt_kitapadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kitaplar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_kitaplar
            // 
            this.dgw_kitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_kitaplar.Location = new System.Drawing.Point(13, 375);
            this.dgw_kitaplar.Name = "dgw_kitaplar";
            this.dgw_kitaplar.RowHeadersWidth = 62;
            this.dgw_kitaplar.RowTemplate.Height = 28;
            this.dgw_kitaplar.Size = new System.Drawing.Size(1082, 413);
            this.dgw_kitaplar.TabIndex = 20;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(881, 25);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(143, 48);
            this.btn_ekle.TabIndex = 18;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rb_Hayir);
            this.panel1.Controls.Add(this.rb_Evet);
            this.panel1.Controls.Add(this.dtp_basimtarihi);
            this.panel1.Controls.Add(this.cbx_yayinevi);
            this.panel1.Controls.Add(this.txt_yazaradi);
            this.panel1.Controls.Add(this.txt_kitapadi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(120, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 312);
            this.panel1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Emanet verilebilir ";
            // 
            // rb_Hayir
            // 
            this.rb_Hayir.AutoSize = true;
            this.rb_Hayir.Location = new System.Drawing.Point(315, 252);
            this.rb_Hayir.Name = "rb_Hayir";
            this.rb_Hayir.Size = new System.Drawing.Size(70, 24);
            this.rb_Hayir.TabIndex = 16;
            this.rb_Hayir.TabStop = true;
            this.rb_Hayir.Text = "Hayır";
            this.rb_Hayir.UseVisualStyleBackColor = true;
            // 
            // rb_Evet
            // 
            this.rb_Evet.AutoSize = true;
            this.rb_Evet.Location = new System.Drawing.Point(230, 252);
            this.rb_Evet.Name = "rb_Evet";
            this.rb_Evet.Size = new System.Drawing.Size(66, 24);
            this.rb_Evet.TabIndex = 15;
            this.rb_Evet.TabStop = true;
            this.rb_Evet.Text = "Evet";
            this.rb_Evet.UseVisualStyleBackColor = true;
            // 
            // dtp_basimtarihi
            // 
            this.dtp_basimtarihi.Location = new System.Drawing.Point(200, 209);
            this.dtp_basimtarihi.Name = "dtp_basimtarihi";
            this.dtp_basimtarihi.Size = new System.Drawing.Size(200, 26);
            this.dtp_basimtarihi.TabIndex = 14;
            // 
            // cbx_yayinevi
            // 
            this.cbx_yayinevi.FormattingEnabled = true;
            this.cbx_yayinevi.Items.AddRange(new object[] {
            "YAPI KREDİ YAYINLARI",
            " CAN YAYINLARI",
            " CEZVE ÇOCUK",
            " KAPRA YAYINCILIK",
            " TÜRKİYE İŞ BANKASI KÜLTÜR YAYINLARI",
            " PEGASUS YAYINLARI",
            " KARBON KİTAPLAR",
            " İTHAKİ YAYINLARI",
            " KRONİK KİTAP",
            " TİMAŞ YAYINLARI",
            " İLETİŞİM YAYINLARI",
            " HAYY KİTAP",
            " DOĞAN KİTAP",
            "DOMİNGO YAYINEVİ",
            "CAN ÇOCUK YAYINLARI"});
            this.cbx_yayinevi.Location = new System.Drawing.Point(200, 159);
            this.cbx_yayinevi.Name = "cbx_yayinevi";
            this.cbx_yayinevi.Size = new System.Drawing.Size(200, 28);
            this.cbx_yayinevi.TabIndex = 13;
            this.cbx_yayinevi.SelectedIndexChanged += new System.EventHandler(this.cbx_yayinevi_SelectedIndexChanged);
            // 
            // txt_yazaradi
            // 
            this.txt_yazaradi.Location = new System.Drawing.Point(200, 109);
            this.txt_yazaradi.Name = "txt_yazaradi";
            this.txt_yazaradi.Size = new System.Drawing.Size(200, 26);
            this.txt_yazaradi.TabIndex = 12;
            // 
            // txt_kitapadi
            // 
            this.txt_kitapadi.Location = new System.Drawing.Point(200, 54);
            this.txt_kitapadi.Name = "txt_kitapadi";
            this.txt_kitapadi.Size = new System.Drawing.Size(200, 26);
            this.txt_kitapadi.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Basım Tarihi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yayınevi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yazar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kitap Adı : ";
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(881, 106);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(143, 48);
            this.btn_sil.TabIndex = 21;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(881, 259);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(143, 55);
            this.btn_guncelle.TabIndex = 24;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ara.Location = new System.Drawing.Point(881, 184);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(143, 52);
            this.btn_ara.TabIndex = 25;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1101, 805);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgw_kitaplar);
            this.Name = "anasayfa";
            this.Text = "Kütüphane";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kitaplar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgw_kitaplar;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rb_Hayir;
        private System.Windows.Forms.RadioButton rb_Evet;
        private System.Windows.Forms.DateTimePicker dtp_basimtarihi;
        private System.Windows.Forms.ComboBox cbx_yayinevi;
        private System.Windows.Forms.TextBox txt_yazaradi;
        private System.Windows.Forms.TextBox txt_kitapadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ara;
    }
}