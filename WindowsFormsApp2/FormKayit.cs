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
    public partial class FormKayit : Form

        
    {
        ClassKayit kayit = new ClassKayit();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LPISQRK\\SQLEXPRESS;Initial Catalog=Film_Satis;Integrated Security=True");
        public FormKayit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select *from Kullanici_Bilgiler where ad = '" + textBoxad.Text + "'", baglanti);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Bu Ada Sahip Bir Kullanıcı Kayıtlıdır.Lütfen Başka Bir Kullanıcı Adı Koyunuz"); ;
            }
            else
            {
                if (textBoxad.Text != "" && textBoxsifre.Text != "" && textBoxmail.Text != "" && maskedTextBoxtelno.Text.Length > 13)
                {
                    string bilgiler = "insert into Kullanici_Bilgiler(ad,sifre,telefon,email) values(@ad,@sifre,@telefon,@email)";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.AddWithValue("@ad", textBoxad.Text);
                    komut2.Parameters.AddWithValue("@sifre", textBoxsifre.Text);
                    komut2.Parameters.AddWithValue("@telefon", maskedTextBoxtelno.Text);
                    komut2.Parameters.AddWithValue("@email", textBoxmail.Text);
                    kayit.kullanici_kayit(komut2, bilgiler);
                    foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                    maskedTextBoxtelno.Text = "";
                    MessageBox.Show("Kullanıcı Başarıyla Kaydedilmiştir");
                }
                else
                {
                    MessageBox.Show("EKSİK BİLGİLERİ DOLDURUNUZ!");
                }
            }
            baglanti.Close();
        }
    }
}
