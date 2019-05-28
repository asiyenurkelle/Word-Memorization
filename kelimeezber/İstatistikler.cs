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
using System.Windows.Forms.DataVisualization.Charting;
  namespace kelimeezber
{
    public partial class IstatistiklerForm : Form
    {
        public IstatistiklerForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AnasayfaForm yeni = new AnasayfaForm();
            yeni.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void haftalıklbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void İstatistikler_Load(object sender, EventArgs e)
        {
            VeritabaniIslemleri vt = new VeritabaniIslemleri();
            DataTable dt = new DataTable();
            dt = vt.veriTablosuDondur("select Count(*) from ogrenilecekler where kacinciOgrenme = 0");
            string buHafta = dt.Rows[0][0].ToString();
            dt.Clear();
            vt = new VeritabaniIslemleri();
            dt = vt.veriTablosuDondur("select Count(*) from ogrenilecekler where kacinciOgrenme = 1");
            string buAy = dt.Rows[0][0].ToString();
            dt.Clear();
            vt = new VeritabaniIslemleri();
            dt = vt.veriTablosuDondur("select Count(*) from ogrenilecekler where kacinciOgrenme = 2");
            string buAltiAy = dt.Rows[0][0].ToString();
            dt.Clear();
            vt = new VeritabaniIslemleri();
            dt = vt.veriTablosuDondur("select Count(*) from ogrenilecekler where kacinciOgrenme = -1");
            string hepsi = dt.Rows[0][0].ToString(); 

            IstatistiklerChart.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column
            }; 

            this.IstatistiklerChart.Series.Add(series1); 
            series1.Points.Add(Convert.ToInt32(buHafta));
            series1.Points[0].AxisLabel = "Bu hafta öğrendiğim kelimeler";
            series1.Points.Add(Convert.ToInt32(buAy));
            series1.Points[1].AxisLabel = "Bu ay öğrendiğim kelimeler";
            series1.Points.Add(Convert.ToInt32(buAltiAy));
            series1.Points[2].AxisLabel = "Son altı içinde öğrendiğim kelimeler";
            series1.Points.Add(Convert.ToInt32(hepsi));
            series1.Points[3].AxisLabel = "Öğrendiğim kelimeler";
            IstatistiklerChart.Invalidate();
        }

        private void OgrendikleriminSayisiLbl_Click(object sender, EventArgs e)
        {

        }

        private void ResimPictureBox_Click(object sender, EventArgs e)
        {

        }
       
    }
}
