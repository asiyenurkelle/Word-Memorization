using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kelimeezber
{
    public partial class AnasayfaForm : Form
    {
        public AnasayfaForm()
        {
            InitializeComponent();
        }

        private void kelimeezberlebtn_Click(object sender, EventArgs e)
        {
            KelimeEzberleForm yeni = new KelimeEzberleForm();
            yeni.Show();
            this.Hide();

        }

        private void Kelimesorbtn_Click(object sender, EventArgs e)
        {
            KelimeSorForm yeni = new KelimeSorForm();
            yeni.Show();
            this.Hide();
            //kelime sor formuna gider.
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

            IsımLbl.Text = KullanıcıGirisiForm.isim.ToString();
            SoyisimLbl.Text = KullanıcıGirisiForm.soyisim.ToString(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kelimeeklebuton_Click(object sender, EventArgs e)
        {
            KelimeEklemeForm yeni = new KelimeEklemeForm();
            yeni.Show();
            this.Hide();
            //Kelime ekleme formuna gider.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void çıkışbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adlbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void istatistiklerbtn_Click(object sender, EventArgs e)
        {
            IstatistiklerForm yeni = new IstatistiklerForm();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            YapilacaklarForm bilgiler = new YapilacaklarForm();
            bilgiler.Show();
            this.Hide();
        }
    }
}
