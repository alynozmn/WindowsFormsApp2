using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormYonetici : Form
    {
        public FormYonetici()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, sifre;
            ad = textBox1.Text;
            sifre = textBox2.Text;
            if (ad == "yönetici" && sifre == "12345")
            {
                FormFilmKayıt filmKayıt = new FormFilmKayıt();
                filmKayıt.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifre veya kullanıcı adınız yanlış.Tekrar giriniz");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
