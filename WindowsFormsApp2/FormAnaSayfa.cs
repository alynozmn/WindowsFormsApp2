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
    public partial class FormAnaSayfa : Form
    {
        ClassKayit kayit = new ClassKayit();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5CM6LIG\\SQLEXPRESS;Initial Catalog=Film_Satis;Integrated Security=True");
        
        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            KategoriTur();
            button4.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            KategoriTur();
            button4.Enabled = true;
        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            FilmEkle(comboBox3, "select *from Film_Bilgiler", "filmadi");
            FilmTurEkle(comboBox2, "select DISTINCT tur from Film_Bilgiler", "tur");
            FilmYapimYiliEkle(comboBox1, "select DISTINCT yapimyili from Film_Bilgiler", "yapimyili");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Film_Bilgiler where filmadi = '" + comboBox3.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                labelad.Text = read["filmadi"].ToString();
                labelyonetmen.Text = read["yonetmen"].ToString();
                labeltur.Text = read["tur"].ToString();
                labeltarih.Text = read["vizyon"].ToString();
                labelsure.Text = read["sure"].ToString();
                labelimdb.Text = read["imdb"].ToString();
                labelyil.Text = read["yapimyili"].ToString();
                richTextBox1.Text = read["konu"].ToString();
                pictureBox1.ImageLocation = read["resim"].ToString();
                labelkira.Text = read["kirafiyati"].ToString();
                labeltam.Text = read["tamfiyat"].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select *from Kullanici_Giris_Bilgileri",baglanti);
            SqlDataReader read2 = komut2.ExecuteReader();
            while (read2.Read())
            {
                labelkullanici.Text = read2["KullaniciAdi"].ToString();
            }
            baglanti.Close();
    }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmBilgileriGöster();
            button2.Enabled = true;
            button5.Enabled = true;
        }

        void FilmEkle(ComboBox combobox, string bilgi1,string bilgi2)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand(bilgi1,baglanti);
            SqlDataReader read = komut3.ExecuteReader();
            while (read.Read() == true)
            {
                comboBox3.Items.Add(read[bilgi2].ToString());
            }
            baglanti.Close();
        }
       void FilmTurEkle(ComboBox combobox, string bilgi1, string bilgi2)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand(bilgi1, baglanti);
            SqlDataReader read = komut3.ExecuteReader();
            
            while (read.Read() == true)
            {
                {
                   comboBox2.Items.Add(read[bilgi2].ToString());
                }
                
            }
            baglanti.Close();
        }
        void FilmYapimYiliEkle(ComboBox combobox, string bilgi1, string bilgi2)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand(bilgi1, baglanti);
            SqlDataReader read = komut3.ExecuteReader();
            while (read.Read() == true)
            {
                comboBox1.Items.Add(read[bilgi2].ToString());
            }
            baglanti.Close();
        }
        void FilmBilgileriGöster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Film_Bilgiler where filmadi = '" + comboBox3.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                labelad.Text = read["filmadi"].ToString();
                labelyonetmen.Text = read["yonetmen"].ToString();
                labeltur.Text = read["tur"].ToString();
                labeltarih.Text = read["vizyon"].ToString();
                labelsure.Text = read["sure"].ToString();
                labelimdb.Text = read["imdb"].ToString();
                labelyil.Text = read["yapimyili"].ToString();
                richTextBox1.Text = read["konu"].ToString();
                pictureBox1.ImageLocation = read["resim"].ToString();
                labelkira.Text = read["kirafiyati"].ToString();
                labeltam.Text = read["tamfiyat"].ToString();
            }

            baglanti.Close(); }

           void KategoriTur()
            {
            if (comboBox2.SelectedIndex != -1)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from Film_Bilgiler where tur = '" + comboBox2.SelectedItem + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                comboBox3.Items.Clear();
                while (read.Read())
                {
                    comboBox3.Items.Add(read["filmadi"].ToString());
                }
                baglanti.Close();
            }
             if (comboBox1.SelectedIndex != -1)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from Film_Bilgiler where yapimyili = '" + comboBox1.SelectedItem + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                comboBox3.Items.Clear();
                while (read.Read())
                {
                    comboBox3.Items.Add(read["filmadi"].ToString());
                }
                baglanti.Close();
            }
             if(comboBox2.SelectedIndex != -1 && comboBox1.SelectedIndex != -1)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from Film_Bilgiler where tur = '" + comboBox2.SelectedItem + "' and yapimyili ='" + comboBox1.SelectedItem + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                comboBox3.Items.Clear();
                while (read.Read())
                {
                    comboBox3.Items.Add(read["filmadi"].ToString());
                }
                baglanti.Close();
            }
            }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temizle();
            
        }
        

            

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select *from Satis_Bilgileri where musteriadi = '" + labelkullanici.Text + "'and urun = '" + labelad.Text + "'", baglanti);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Bu Film Daha Önce Satın Alınmıştır");
            }
            else
            {
                string bilgi = "insert into Satis_Ekrani(UrunAdi,UrunTipi,UrunFiyati,UrunAfisi) values(@Urunadi,@UrunTipi,@UrunFiyati,@UrunAfisi)";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@UrunAdi", labelad.Text);
                komut.Parameters.AddWithValue("@UrunTipi", label1.Text);
                komut.Parameters.AddWithValue("@UrunFiyati", labeltam.Text);
                komut.Parameters.AddWithValue("@UrunAfisi", pictureBox1.ImageLocation);
                kayit.kullanici_kayit(komut, bilgi);
                MessageBox.Show("Satış Ekranına Yönlendiriliyorsunuz");
                FormSatisEkrani frm1 = new FormSatisEkrani();
                frm1.Show();
                this.Hide();
            }
            baglanti.Close();
            

        }
        void temizle()
        {
            comboBox2.SelectedItem = null;
            comboBox1.SelectedItem = null;
            comboBox3.SelectedItem = null;
            comboBox3.Items.Clear();
            FilmEkle(comboBox3, "select *from Film_Bilgiler", "filmadi");
            button4.Enabled = false;
            pictureBox1.Image = null;
            labelad.Text = "";
            labelyonetmen.Text = "";
            labeltur.Text = "";
            labeltarih.Text = "";
            labelsure.Text = "";
            labelimdb.Text = "";
            labelyil.Text = "";
            richTextBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select *from Satis_Bilgileri where musteriadi = '" + labelkullanici.Text + "'and urun = '"+labelad.Text+"'", baglanti);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Bu Film Daha Önce Satın Alınmıştır");
            }
            else
            {
                string bilgi = "insert into Satis_Ekrani(UrunAdi,UrunTipi,UrunFiyati,UrunAfisi) values(@Urunadi,@UrunTipi,@UrunFiyati,@UrunAfisi)";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@UrunAdi", labelad.Text);
                komut.Parameters.AddWithValue("@UrunTipi", label2.Text);
                komut.Parameters.AddWithValue("@UrunFiyati", labelkira.Text);
                komut.Parameters.AddWithValue("@UrunAfisi", pictureBox1.ImageLocation);
                kayit.kullanici_kayit(komut, bilgi);
                MessageBox.Show("SATIŞ EKRANINA YÖNLENDİRİLİYORSUNUZ");
                FormSatisEkrani frm1 = new FormSatisEkrani();
                frm1.Show();
                this.Hide();
            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
           SqlCommand komut = new SqlCommand("Delete From Kullanici_Giris_Bilgileri",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSatinAlinanFilmler frm1 = new FormSatinAlinanFilmler();
            frm1.Show();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }
    
