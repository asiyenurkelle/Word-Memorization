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
    public partial class KelimeEzberleForm : Form
    {
        public KelimeEzberleForm()
        {
            InitializeComponent();
        } 
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=sozluk;Integrated Security=True");

        private void havuzugöster()
        {
            baglan.Open();
            OgrenileceklerListView.Items.Clear();
            SqlCommand komut = new SqlCommand("select * from ogrenilecekler order by id desc", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["turkce"].ToString());
                ekle.SubItems.Add(oku["ingilizce"].ToString());
                OgrenileceklerListView.Items.Add(ekle);
            }
            baglan.Close();

        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void geritusubtn_Click(object sender, EventArgs e)
        {
            AnasayfaForm yeni = new AnasayfaForm();
            yeni.Show();
            this.Hide();
        }

        private void ingilizceezbertxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ezberebaslabtn_Click(object sender, EventArgs e)
        {
            
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select top(1) * from sozluktb order by newid()", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            EzbereBaslaBtn.Enabled = false;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                TurkceEzberleLbl.Text = dr[1].ToString();
                IngilizceEzberleLbl.Text = dr[2].ToString();
            }
            baglan.Close();
        }

        private void kelimeezberle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sozlukDataSet.sozluktb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void turkceezberlelbl_Click(object sender, EventArgs e)
        {

        }

        public void ingilizcezberlelbl_Click(object sender, EventArgs e)
        {

        }

        private void sonrakikelimebtn_Click(object sender, EventArgs e)
        {
            HazneyeEkleBtn.Enabled = true;
            SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=sozluk;Integrated Security=True");
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select top(1) * from sozluktb order by newid()", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                TurkceEzberleLbl.Text = dr[1].ToString();
                IngilizceEzberleLbl.Text = dr[2].ToString();
            }
            baglan.Close();
        }
        private void Hazneyeeklebtn_Click(object sender, EventArgs e)
        {
            HazneyeEkleBtn.Enabled = false;
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert Into ogrenilecekler (turkce,ingilizce) Values ('" + TurkceEzberleLbl.Text.ToString() + "','" + IngilizceEzberleLbl.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            havuzugöster();
        }

        private void kelimeezberlemelbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    }

