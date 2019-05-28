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
    public partial class YapilacaklarForm : Form
    {
        public YapilacaklarForm()
        {
            InitializeComponent();
        }

        private void Bilgi_Load(object sender, EventArgs e)
        {
            VeritabaniIslemleri vt = new VeritabaniIslemleri();
            DataTable dt = new DataTable();
            OgrenileceklerDataGridView.DataSource = vt.veriTablosuDondur("select * from ogrenilecekler where kacinciOgrenme = 0");
            OgrenileceklerDataGridView.Columns[0].Visible = false;
            OgrenileceklerDataGridView.Columns[4].Visible = false;
            OgrenileceklerDataGridView.Columns[3].Visible = false;
            vt = new VeritabaniIslemleri();
            TestDataGridView.DataSource = vt.veriTablosuDondur("select * from ogrenilecekler where kacinciOgrenme = 1 or kacinciOgrenme = 2");
            TestDataGridView.Columns[0].Visible = false;
            TestDataGridView.Columns[4].Visible = false;
            TestDataGridView.Columns[3].Visible = false;
            vt = new VeritabaniIslemleri();
            KazanimlarDataGridView.DataSource = vt.veriTablosuDondur("select * from ogrenilecekler where kacinciOgrenme = -1");
            KazanimlarDataGridView.Columns[0].Visible = false;
            KazanimlarDataGridView.Columns[4].Visible = false;
            KazanimlarDataGridView.Columns[3].Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void geripictureBox2_Click(object sender, EventArgs e)
        {
            AnasayfaForm anasayfa = new AnasayfaForm();
            anasayfa.Show();
            this.Hide();
        }

        private void testDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
