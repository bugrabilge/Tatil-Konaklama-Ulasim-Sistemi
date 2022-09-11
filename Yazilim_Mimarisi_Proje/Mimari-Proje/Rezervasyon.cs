using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari_Proje
{
    public class Rezervasyon
    {
        public Konaklama konaklama { get; set; }
        public Ulasim ulasim { get; set; }
        public DateTime baslangicTarihi { get; set; }
        public DateTime bitisTarihi { get; set; }
        public Musteri musteri { get; set; }
        public string rezervasyonKonumu { get; set; }

        public Rezervasyon()
        {
        }

        public int ToplamUcret()
        {
            return konaklamaToplamUcret() + ulasim.fiyat;
        }
        public int konaklamaToplamUcret()
        {
            return konaklama.fiyat * bitisTarihi.Subtract(baslangicTarihi).Days;
        }
    }
}
