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

    
    public partial class anasayfa : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=SALIH\SQLEXPRESS;Initial Catalog=ckutuphane;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader reade;
        void gridyazar()
        {

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from tbl_kitaplik where kitap_yazar = '"+txt_yazaradi.Text+"'", connection);
            DataSet dataSet = new DataSet();
            connection.Open();
            sqlDataAdapter.Fill(dataSet, "tbl_kitaplik");
            dgw_kitaplar.DataSource = dataSet.Tables["tbl_kitaplik"];
            connection.Close();
        }
        void gridDoldur()
        {
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from tbl_kitaplik", connection);
            DataSet dataSet = new DataSet();
            connection.Open();
            sqlDataAdapter.Fill(dataSet,"tbl_kitaplik");
            dgw_kitaplar.DataSource = dataSet.Tables["tbl_kitaplik"];
            connection.Close();
        }
        public anasayfa()
        {
            InitializeComponent();
            gridDoldur();
        }
       

        private void cbx_yayinevi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            connection.Open();
            string kitap_ad = txt_kitapadi.Text;
            string kitap_yazar = txt_yazaradi.Text;
            string kitap_yayinevi = cbx_yayinevi.Text;
            string kitap_basim_tarihi = dtp_basimtarihi.Text;
            string emanet;
            if (rb_Evet.Checked) { emanet = "EVET"; }
            else { emanet = "HAYIR"; }
            
            command.Connection= connection;
            command.CommandText = "Insert into tbl_kitaplik(kitap_ad,kitap_yazar,kitap_yayinevi,kitap_basim_tarihi,kitap_emanet) values ('"+kitap_ad+ "','" + kitap_yazar + "','" + kitap_yayinevi + "','" + kitap_basim_tarihi + "','" + emanet + "')";
            reade = command.ExecuteReader();
            if (reade.Read())
            {
                MessageBox.Show("Eklendi");
            }
            else if (txt_kitapadi.Text=="" || txt_yazaradi.Text=="" || cbx_yayinevi.Text=="") { MessageBox.Show("Boş alanları doldurunuz"); }
            connection.Close();
            gridDoldur();

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            connection.Open();
            string kitap_ad = txt_kitapadi.Text;
            command.Connection = connection;
            command.CommandText = "delete from tbl_kitaplik where kitap_ad = '"+kitap_ad+"'";
            reade = command.ExecuteReader();
            if (reade.Read())
            {
                MessageBox.Show("Silindi");
            }
            connection.Close();
            gridDoldur();
        } 

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            string kitap_ad = txt_kitapadi.Text;
            string emanet;
            if (rb_Evet.Checked) { emanet = "EVET"; }
            else { emanet = "HAYIR"; }
            command.Connection = connection;
            command.CommandText = "Update tbl_kitaplik set kitap_ad = '"+txt_kitapadi.Text+"', kitap_yazar = '"+txt_yazaradi.Text+"', kitap_yayinevi = '"+cbx_yayinevi.Text+"', kitap_basim_tarihi = '"+dtp_basimtarihi.Text+"', kitap_emanet = '"+emanet+"' where kitap_ad = '" + kitap_ad + "'";
            reade = command.ExecuteReader();
            if (reade.Read())
            {
                MessageBox.Show("Güncellendi");
            }
            connection.Close();
            gridDoldur();

        }

       
        private void btn_ara_Click(object sender, EventArgs e)
        {
            connection.Open();
            string kitap_ad = txt_kitapadi.Text;
            string kitap_yazaradi = txt_yazaradi.Text;
            string emanet;
            
            command.Connection = connection;
            command.CommandText = "Select * from tbl_kitaplik where kitap_ad = '"+kitap_ad+"' or kitap_yazar = '"+kitap_yazaradi+"'";
            reade = command.ExecuteReader();
            if (reade.Read())
            {
                MessageBox.Show("Kitap bulunuyor");
            }
            else
            {
                MessageBox.Show("Kitap Bulunmuyor");
            }
            connection.Close();
            gridyazar();

        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
