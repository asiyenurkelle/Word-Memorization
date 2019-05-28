using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kelimeezber
{
    public partial class KelimeEklemeForm : Form
    {
        public KelimeEklemeForm()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=sozluk;Integrated Security=True");
        private void verilerigöster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select*from sozluktb", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["turkce"].ToString());
                ekle.SubItems.Add (oku["ingilizce"].ToString());
                ekle.SubItems.Add(oku["kelimeTuru"].ToString());
                KelimeHavuzuListView.Items.Add(ekle);
                //veritabanından verileri çekerek,listview'e yazdırır.//
            }
            baglan.Close();
        }
     private void kelimeekleme_Load(object sender, EventArgs e)
        {
            
        }

        private void verilerigösterbtn_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }

        private void kelimeeklebtn_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert Into sozluktb (turkce,ingilizce,kelimeTuru) Values('" + KelimeGirTxtbx.Text.ToString() + "','" + IngilizceKelimeEkleTxtbox.Text.ToString() + "','" + KelimeTurTxtbx.Text.ToString() +"')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigöster();
            MessageBox.Show("Kelime Başarı İle Eklendi");
            KelimeGirTxtbx.Clear();
            IngilizceKelimeEkleTxtbox.Clear();
            KelimeTurTxtbx.Clear();
            //yeni kelime girişi yaptıktan sonra textbox'ları temizler.//
        }

        private void geridönüsbtn_Click(object sender, EventArgs e)
        {
            AnasayfaForm yeni = new AnasayfaForm();
            yeni.Show();
            this.Hide();
        }

        private void exitpictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KelimeHavuzuListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
