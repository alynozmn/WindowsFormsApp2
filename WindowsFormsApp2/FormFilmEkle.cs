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
    public partial class FormFilmEkle : Form
    {
        ClassKayit kayit = new ClassKayit();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5CM6LIG\\SQLEXPRESS;Initial Catalog=Film_Satis;Integrated Security=True");
        public FormFilmEkle()
        {
            InitializeComponent();
        }

        private void FormFilmEkle_Load(object sender, EventArgs e)
        {
            listele3();
        }
        private void listele3()
        {
            string bilgiler = "select *from Film_Bilgiler";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = kayit.listele(adtr2, bilgiler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bilgiler = "insert into Film_Bilgiler(filmadi,yonetmen,tur,vizyon,sure,imdb,yapimyili,konu,resim,kirafiyati,tamfiyat) values(@filmadi,@yonetmen,@tur,@vizyon,@sure,@imdb,@yapimyili,@konu,@resim,@kirafiyati,@tamfiyat)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@filmadi", textBoxad.Text);
            komut2.Parameters.AddWithValue("@yonetmen", textBoxyonetmen.Text);
            komut2.Parameters.AddWithValue("@tur", textBoxtur.Text);
            komut2.Parameters.AddWithValue("@vizyon", maskedTextBoxvizyon.Text);
            komut2.Parameters.AddWithValue("@sure", maskedTextBoxsure.Text);
            komut2.Parameters.AddWithValue("@imdb", textBoximdb.Text);
            komut2.Parameters.AddWithValue("@yapimyili", textBoxyil.Text);
            komut2.Parameters.AddWithValue("@konu", textBoxkonu.Text);
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@kirafiyati", textBoxkira.Text);
            komut2.Parameters.AddWithValue("@tamfiyat", textBoxtam.Text);
            kayit.kullanici_kayit(komut2, bilgiler);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            maskedTextBoxsure.Text = "";
            maskedTextBoxvizyon.Text = "";
            pictureBox1.Image = null; 
            listele3();
            button1.Enabled = false;
            MessageBox.Show("Film Başarıyla Kaydedilmiştir");
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                verisil(id);
                listele3();
            }
        }

        public void verisil(int id)
        {
            string sil = "Delete From Film_Bilgiler Where filmID = @filmID";
            SqlCommand komut = new SqlCommand(sil, baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@filmID", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormFilmKayıt frm = new FormFilmKayıt();
            frm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
