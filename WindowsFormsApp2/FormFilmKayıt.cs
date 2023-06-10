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
    public partial class FormFilmKayıt : Form
    {
        public FormFilmKayıt()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormKullaniciListeleme frm1 = new FormKullaniciListeleme();
            frm1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFilmEkle frm2 = new FormFilmEkle();
            frm2.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSatisBilgileri frm1 = new FormSatisBilgileri();
            frm1.Show();
            this.Close();
           
        }
    }
}
