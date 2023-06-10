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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class FormSatisBilgileri : Form
    {
        ClassKayit kayit = new ClassKayit();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5CM6LIG\\SQLEXPRESS;Initial Catalog=Film_Satis;Integrated Security=True");
        public FormSatisBilgileri()
        {
            InitializeComponent();
        }

        private void FormSatisBilgileri_Load(object sender, EventArgs e)
        {
            Satis_Listele();
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select DISTINCT tarih from Satis_Bilgileri", baglanti);
            SqlDataReader read = komut3.ExecuteReader();

            while (read.Read() == true)
            {
                {
                    comboBox1.Items.Add(read["tarih"].ToString());
                }

            }
            baglanti.Close();
        }
        private void Satis_Listele()
        {
            string bilgiler = "select *from Satis_Bilgileri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = kayit.listele(adtr2, bilgiler);
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bilgiler = "select *from Satis_Bilgileri where tarih = '"+comboBox1.SelectedItem+"'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = kayit.listele(adtr2, bilgiler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFilmKayıt kayit = new FormFilmKayıt();
            kayit.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Satis_Listele();
        }
    }
}
