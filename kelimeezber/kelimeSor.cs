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
    public partial class KelimeSorForm : Form
    {
        public KelimeSorForm()
        {
            InitializeComponent();
        }
        SoruObjesi donecekSoru = new SoruObjesi();
        private void kelimeSor_Load(object sender, EventArgs e)
        {
            yeniSoru();

        }
        public void yeniSoru()
        {
            SoruGetir();
            if (donecekSoru.ingilizce == "" || donecekSoru.ingilizce == null)
            {
                MessageBox.Show("Sorulacak kelime yok");
                this.Close();
                return;
            }
            SoruMetniLbl.Text = donecekSoru.turkce.Trim() + " kelimesinin ingilizcesi hangi şıkta yer almıştır ?";
            Random rnd = new Random();
            int dogruSecenek = rnd.Next(1, 4);
            if (dogruSecenek == 1)
            {
                Secenek1Btn.Text = donecekSoru.ingilizce;
                Secenek2Btn.Text = SoruIcinSecenekGetir();
                Secenek3Btn.Text = SoruIcinSecenekGetir();
                Secenek4Btn.Text = SoruIcinSecenekGetir();
            }
            else if (dogruSecenek == 2)
            {
                Secenek1Btn.Text = SoruIcinSecenekGetir();
                Secenek2Btn.Text = donecekSoru.ingilizce;
                Secenek3Btn.Text = SoruIcinSecenekGetir();
                Secenek4Btn.Text = SoruIcinSecenekGetir();
            }
            else if (dogruSecenek == 3)
            {
                Secenek1Btn.Text = SoruIcinSecenekGetir();
                Secenek2Btn.Text = SoruIcinSecenekGetir();
                Secenek3Btn.Text = donecekSoru.ingilizce;
                Secenek4Btn.Text = SoruIcinSecenekGetir();
            }
            else if (dogruSecenek == 4)
            {
                Secenek1Btn.Text = SoruIcinSecenekGetir();
                Secenek2Btn.Text = SoruIcinSecenekGetir();
                Secenek3Btn.Text = SoruIcinSecenekGetir();
                Secenek4Btn.Text = donecekSoru.ingilizce;
            }
        }
        public SoruObjesi SoruGetir()
        {
            VeritabaniIslemleri vt = new VeritabaniIslemleri();
            DataTable dt = new DataTable();
            DateTime birHaftaOnce = DateTime.Now.AddDays(-7);
            DateTime birAyOnce = DateTime.Now.AddMonths(-1);
            DateTime altiAyOnce = DateTime.Now.AddMonths(-6);
            string BirHaftaOnceBaslangicTarihi = birHaftaOnce.Year + (birHaftaOnce.Month.ToString().Length == 1 ? ("0" + birHaftaOnce.Month.ToString()) : birHaftaOnce.Month.ToString()) + (birHaftaOnce.Day.ToString().Length == 1 ? ("0" + birHaftaOnce.Day.ToString()) : birHaftaOnce.Day.ToString());
            string birAyOnceninBitisTarihi = birAyOnce.Year + (birAyOnce.Month.ToString().Length == 1 ? ("0" + birAyOnce.Month.ToString()) : birAyOnce.Month.ToString()) + (birAyOnce.Day.ToString().Length == 1 ? ("0" + birAyOnce.Day.ToString()) : birAyOnce.Day.ToString());
            string altiAyOnceninBitisTarihi = altiAyOnce.Year + (altiAyOnce.Month.ToString().Length == 1 ? ("0" + altiAyOnce.Month.ToString()) : altiAyOnce.Month.ToString()) + (altiAyOnce.Day.ToString().Length == 1 ? ("0" + altiAyOnce.Day.ToString()) : altiAyOnce.Day.ToString());
            DateTime bugun = DateTime.Now;
            string bitisTarihi = bugun.Year + (bugun.Month.ToString().Length == 1 ? ("0" + bugun.Month.ToString()) : bugun.Month.ToString()) + (bugun.Day.ToString().Length == 1 ? ("0" + bugun.Day.ToString()) : bugun.Day.ToString());
            string sorgu = "select * from ogrenilecekler where kacinciOgrenme = 0 and ogrenilmetarihi <= '" + BirHaftaOnceBaslangicTarihi + "'";
            dt = vt.veriTablosuDondur(sorgu);
            if (dt.Rows.Count == 0)
            {
                // 1 hafta önce öğrenilen kelime yok.
                dt = vt.veriTablosuDondur("select * from ogrenilecekler where kacinciOgrenme = 1 and ogrenilmetarihi <= '" + birAyOnceninBitisTarihi + "'");
                if (dt.Rows.Count == 0)
                {
                    // 1 ay önce öğrenilen kelime yok.
                    dt = vt.veriTablosuDondur("select * from ogrenilecekler where kacinciOgrenme = 2 and ogrenilmetarihi <='" + altiAyOnceninBitisTarihi + "'");
                    if (dt.Rows.Count == 0)
                    {
                        // 6 ay önce öğrenilen kelimesi yok.
                        SoruObjesi soru = new SoruObjesi();
                        donecekSoru = soru;
                        return soru;
                    }
                }
            }
            Random rnd = new Random();
            int sayi = rnd.Next(0, dt.Rows.Count);
            DataRow k = dt.NewRow();
            k = dt.Rows[sayi];
            donecekSoru.id = Convert.ToInt32(k[0].ToString());
            donecekSoru.turkce = k[1].ToString();
            donecekSoru.ingilizce = k[2].ToString();
            donecekSoru.kacinciOgrenme = Convert.ToInt32(k[4].ToString()); 
            return donecekSoru;
        }
        Random rnd = new Random();
        public string SoruIcinSecenekGetir()
        {
            string kelime = "";
            do
            {
                VeritabaniIslemleri vt = new VeritabaniIslemleri();
                DataTable dt = new DataTable();
                dt = vt.veriTablosuDondur("select ingilizce from sozluktb");
                
                int sayi = rnd.Next(0, dt.Rows.Count);
                kelime = dt.Rows[sayi][0].ToString(); 
                
            } while (kelime == donecekSoru.ingilizce);
            return kelime;
        }

        private void secenek_Click(object sender, EventArgs e)
        {
            Button buton = sender as Button;
            VeritabaniIslemleri vt = new VeritabaniIslemleri();
            if (buton.Text == donecekSoru.ingilizce)
            {
                //kullanıcı soruyu doğru cevapladı
                if (donecekSoru.kacinciOgrenme == 2)
                {
                    vt.sorguCalistir("update ogrenilecekler set kacinciOgrenme = -1 where id = " + donecekSoru.id);
                } else
                {
                    vt.sorguCalistir("update ogrenilecekler set kacinciOgrenme = (kacinciOgrenme + 1), ogrenilmetarihi = getdate() where id = " + donecekSoru.id);
                }
                MessageBox.Show("Tebrikler doğru cevap");
            }
            else
            {
                if (donecekSoru.kacinciOgrenme != 0)
                {
                    vt.sorguCalistir("update ogrenilecekler set kacinciOgrenme = (kacinciOgrenme - 1) where id = " + donecekSoru.id);
                }
                MessageBox.Show("Maalesef yanlış cevap");
                AnasayfaForm anasyf = new AnasayfaForm();
                anasyf.Show();
                this.Hide();
                //kullanıcı soruyu yanlış cevapladı
            }
            yeniSoru();
        }

        private void secenek1Resim_Click(object sender, EventArgs e)
        {

        }

        private void SürepictureBox_Click(object sender, EventArgs e)
        {

        }
    }

    public class SoruObjesi
    {
        public int id { get; set; }
        public string turkce { get; set; }
        public string ingilizce { get; set; }
        public int kacinciOgrenme { get; set; }
    }
}
