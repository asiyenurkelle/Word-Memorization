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
    public partial class KullanıcıGirisiForm : Form
    {
        public KullanıcıGirisiForm()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=Asiye;Initial Catalog=sozluk;Integrated Security=True");
        private void girisyapbtn_Click(object sender, EventArgs e)
        { 
            getir();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from kullanıcılar where kullaniciadi='" + KullanıcıAdıtTxtbx.Text + "' and sifre = '" + SifreTxtbx.Text + "'", baglan);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                AnasayfaForm yeni = new AnasayfaForm();
                yeni.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Sifre Yanlış");
            }
            baglan.Close();
        }
        public static string isim;
        public static string soyisim;

        private void getir()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select isim ,soyisim from kullanıcılar where kullaniciadi='" + KullanıcıAdıtTxtbx.Text + "' and sifre='" + SifreTxtbx.Text + "'", baglan);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                isim = dr[0].ToString();
                soyisim = dr[1].ToString();
            }
            baglan.Close();

        }

        private void Kullanıcıgirisi_Load(object sender, EventArgs e)
        {
           
        }
    }
}
