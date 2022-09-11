using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mimari_Proje
{
    public class VeriTabaniBaglanti
    {
        public SqlConnection Baglanti { get; set; }
        public SqlCommand Komut { get; set; }
        public SqlDataReader VeriOkuyucu { get; set; }

        public VeriTabaniBaglanti()
        {
            this.Baglanti = new SqlConnection("Data Source=.;Initial Catalog=dbAcenta;Integrated Security=True");
            this.Komut = new SqlCommand();
            Baglanti.Open();
            this.Komut.Connection = Baglanti;
        }

        public void BaglantiyiKes()
        {
            Baglanti.Close();
        }

        public void BaglantiAc()
        {
            if (Baglanti != null && Baglanti.State == ConnectionState.Closed)
            {
                Baglanti.Open();
                this.Komut.Connection = Baglanti;
            }
        }

        public void SorguCalistir(string sorgu)
        {
            Komut.CommandText = sorgu;
            VeriOkuyucu = Komut.ExecuteReader();
        }

        public string SonucOku(string kolon)
        {
            return VeriOkuyucu[kolon].ToString();
        }
    }
}
