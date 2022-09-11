using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari_Proje
{
    public abstract class Konaklama
    {
        public string konum { get; set; }
        public string ad { get; set; }
        public int fiyat { get; set; }
        public string konaklamaTipi { get; set; }

        public Konaklama(string konum, string ad, int fiyat, string konaklamaTipi)
        {
            this.konum = konum;
            this.ad = ad;
            this.fiyat = fiyat;
            this.konaklamaTipi = konaklamaTipi;
        }

    }
}
