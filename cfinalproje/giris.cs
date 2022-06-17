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

namespace cfinalproje
{
    public partial class giris : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=SALIH\SQLEXPRESS;Initial Catalog=ckutuphane;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reade;
        public giris()
        {
            InitializeComponent();
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kadi = txt_kadi.Text;
            string sifre = txt_sifre.Text;
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select * from tbl_yetkililer where yetkili_kadi = '"+kadi+"' and yetkili_sifre= '"+sifre+"'";
            reade = command.ExecuteReader();
            if (reade.Read())
            {
                MessageBox.Show("BAŞARI İLE GİRİŞ YAPTINIZ YÖNLENDİRİLİYORSUNUZ....");
                anasayfa anasayfafrm = new anasayfa();
                //Show metodu ile nesne olarak türettiğim ikinci formumu açıyorum.
                anasayfafrm.Show();
                //Bu mevcut formu kapatıyorum.
                this.Hide();
            }
            else if(txt_kadi.Text == "" || txt_sifre.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz");
            }
            else 
            {
                MessageBox.Show("Hatali giriş"); 
            }
             connection.Close();
        }
    }
}
