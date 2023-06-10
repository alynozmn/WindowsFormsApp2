using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsApp2
{
    public partial class FormSatisEkrani : Form
    {
        ClassKayit kayit = new ClassKayit();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5CM6LIG\\SQLEXPRESS;Initial Catalog=Film_Satis;Integrated Security=True");
        public FormSatisEkrani()
        {
            InitializeComponent();
        }

        private void FormSatisEkrani_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select *from Satis_Ekrani", baglanti);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                labelad.Text = reader["UrunAdi"].ToString();
                labelfiyat.Text = reader["UrunFiyati"].ToString();
                labeltip.Text = reader["UrunTipi"].ToString();
                pictureBox1.ImageLocation = reader["UrunAfisi"].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select *from Kullanici_Giris_Bilgileri", baglanti);
            SqlDataReader read2 = komut2.ExecuteReader();
            while (read2.Read())
            {
                labelkullanici.Text = read2["KullaniciAdi"].ToString();
            }
            baglanti.Close();
            labeltarih.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {if(textBox1.Text !=""&&maskedTextBox1.Text!="" && maskedTextBox2.Text != "" && maskedTextBox3.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Satis_Ekrani", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                string bilgiler = "insert into Satis_Bilgileri(musteriadi,urun,uruntipi,urunfiyati,indirimtutari,tarih) values(@musteriadi,@urun,@uruntipi,@urunfiyati,@indirimtutari,@tarih)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@musteriadi",labelkullanici.Text);
                komut2.Parameters.AddWithValue("@urun",labelad.Text);
                komut2.Parameters.AddWithValue("@uruntipi",labeltip.Text);
                komut2.Parameters.AddWithValue("@urunfiyati", labelfiyat.Text);
                komut2.Parameters.AddWithValue("@indirimtutari",labelindirim.Text);
                komut2.Parameters.AddWithValue("@tarih",labeltarih.Text);
                kayit.kullanici_kayit(komut2, bilgiler);
               




                MessageBox.Show("SATIN ALMA İŞLEMİNİZ BAŞARIYLA GERÇEKLEŞMİŞTİR.İYİ GÜNLER DİLERİZ");
                this.Hide();
                FormAnaSayfa frm1 = new FormAnaSayfa();
                frm1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("EKSİK BİLGİLERİ DOLDURUNUZ");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

                if (textBox2.Text == "mutlugünler")
                {
                    double indirimtutari = Convert.ToInt32(labelfiyat.Text); ;
                    double tutar = Convert.ToInt32(labelfiyat.Text);
                    tutar *=0.95;
                    indirimtutari *= 0.05;
                    labelfiyat.Text = tutar.ToString();
                    labelindirim.Text = indirimtutari.ToString();
                    MessageBox.Show("%5 İndirim Kazandınız");
                    textBox2.Text = "";
                    button2.Enabled = false;
            }
            else if (textBox2.Text == "keyif")
            {
                double indirimtutari = Convert.ToInt32(labelfiyat.Text); ;
                double tutar = Convert.ToInt32(labelfiyat.Text);
                tutar *= 0.90;
                indirimtutari *= 0.10;
                labelfiyat.Text = tutar.ToString();
                labelindirim.Text = indirimtutari.ToString();
                MessageBox.Show("%10 İndirim Kazandınız");
                textBox2.Text = "";
                button2.Enabled = false;


            }
            else if (textBox2.Text == "sunrise")
            {
                double indirimtutari = Convert.ToInt32(labelfiyat.Text); ;
                double tutar = Convert.ToInt32(labelfiyat.Text);
                tutar *= 0.75;
                indirimtutari *= 0.25;
                labelfiyat.Text = tutar.ToString();
                labelindirim.Text = indirimtutari.ToString();
                MessageBox.Show("%25 İndirim Kazandınız");
                textBox2.Text = "";
                button2.Enabled = false;

            }
            else MessageBox.Show("Kodunuz Geçersiz");
            textBox2.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult secenek = new DialogResult();
            secenek = MessageBox.Show("İşleminiz İptal Edilsin Mi?", "Uyarı", MessageBoxButtons.YesNo);
            if(secenek== DialogResult.Yes)
            {
                MessageBox.Show("İşleminiz İptal Edilmiştir.Ana Sayfaya Yönlendiriliyorsunuz");
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Satis_Ekrani", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                FormAnaSayfa frm1 = new FormAnaSayfa();
                frm1.Show();
                this.Close();
            }
            else
            {

            }
            
        }
    }


    }

