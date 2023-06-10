using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp2
{
    public partial class FormKullaniciGiriş : Form
    {
        ClassKayit kayit = new ClassKayit();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5CM6LIG\\SQLEXPRESS;Initial Catalog=Film_Satis;Integrated Security=True");
        public FormKullaniciGiriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
                string sql = "Select * From Kullanici_Bilgiler where ad = @ad AND sifre = @sifre";
                SqlParameter prmt1 = new SqlParameter("ad", textBoxad.Text.Trim());
                SqlParameter prmt2 = new SqlParameter("sifre", textBoxsifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prmt1);
                komut.Parameters.Add(prmt2);
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(komut);
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                { 
                    string bilgiler = "insert into Kullanici_Giris_Bilgileri(KullaniciAdi) values(@KullaniciAdi)";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.AddWithValue("@KullaniciAdi",textBoxad.Text);
                    kayit.kullanici_kayit(komut2, bilgiler);
                    FormAnaSayfa frm4 = new FormAnaSayfa();
                    frm4.Show();
                    this.Close();
                }
            else
            {
                MessageBox.Show("Girdiğiniz Bilgiler Yanlıştır.");
                textBoxad.Text = "";
                textBoxsifre.Text = "";
            }
            
            
            
    }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
    }
}