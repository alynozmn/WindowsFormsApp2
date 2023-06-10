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

namespace WindowsFormsApp2
{
    public partial class FormSatinAlinanFilmler : Form
    {
        ClassKayit kayit = new ClassKayit();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5CM6LIG\\SQLEXPRESS;Initial Catalog=Film_Satis;Integrated Security=True");
        public FormSatinAlinanFilmler()
        {
            InitializeComponent();
        }

        private void FormSatinAlinanFilmler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select *from Kullanici_Giris_Bilgileri", baglanti);
            SqlDataReader read2 = komut2.ExecuteReader();
            while (read2.Read())
            {
                labelkullanici.Text = read2["KullaniciAdi"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            string bilgi = "SELECT urun,uruntipi,urunfiyati,tarih FROM Satis_Bilgileri WHERE musteriadi ='" + labelkullanici.Text + "'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = kayit.listele(adtr2, bilgi);
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAnaSayfa frm1 = new FormAnaSayfa();
            frm1.Show();
            this.Close();
        }
    }
}
