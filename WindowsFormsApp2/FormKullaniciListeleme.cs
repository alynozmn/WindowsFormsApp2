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
    public partial class FormKullaniciListeleme : Form
    {
        ClassKayit kayit = new ClassKayit();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5CM6LIG\\SQLEXPRESS;Initial Catalog=Film_Satis;Integrated Security=True");
        public FormKullaniciListeleme()
        {
            InitializeComponent();
        }

        private void FormKullaniciListeleme_Load(object sender, EventArgs e)
        {
            listele2();
        }
        private void listele2()
        {
            string bilgiler = "select *from Kullanici_Bilgiler";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = kayit.listele(adtr2, bilgiler);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string bilgiler = "select *from Kullanici_Bilgiler where ad like '%" + textBox1.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = kayit.listele(adtr2, bilgiler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFilmKayıt frm = new FormFilmKayıt();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                verisil(id);
                listele();
            }
        }
        public void verisil(int id)
        {
            string sil = "Delete From Kullanici_Bilgiler where KullaniciID = @KullaniciID";
            SqlCommand komut = new SqlCommand(sil, baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@kullaniciID", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void listele()
        {
            string bilgiler = "select *from Kullanici_Bilgiler";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = kayit.listele(adtr2, bilgiler);
        }
    }

}
