using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace kelimeezber
{
    class VeritabaniIslemleri
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=sozluk;Integrated Security=True");
        public DataTable datatbl=new DataTable();
        public SqlDataAdapter adtr =new SqlDataAdapter();
        public SqlCommand sqlkomut =  new SqlCommand();
        public VeritabaniIslemleri()
        {
 
        }

        public bool baglantiAc()
        {
            try
            {
                baglanti.Open();
                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool baglantiKapat()
        {
            try
            {
                baglanti.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable veriTablosuDondur(string sqlSorgusu)
        {
            datatbl.Clear();
            if (baglantiAc())
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sqlSorgusu;

                adtr.SelectCommand = sqlkomut;
                adtr.Fill(datatbl);

                baglantiKapat();
                return datatbl;
            }
            else
                return null;
        }

        public int sorguCalistir(string sqlSorgusu)
        {
            if (baglantiAc())
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sqlSorgusu;
                int i= sqlkomut.ExecuteNonQuery();
                baglantiKapat();
                return i;
            }
            return 0;
        }
    }
}
