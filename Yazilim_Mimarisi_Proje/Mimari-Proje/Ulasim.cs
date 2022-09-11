using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari_Proje
{
    public abstract class Ulasim
    {
        public string firmaAdi { get; set; }
        public DateTime gidisTarihi { get; set; }
        public DateTime donusTarihi { get; set; }
        public int fiyat { get; set; }
        public string ulasimTipi { get; set; }

        public Ulasim(string firmaAdi, DateTime gidisTarihi, DateTime donusTarihi, int fiyat, string ulasimTipi)
        {
            this.firmaAdi = firmaAdi;
            this.gidisTarihi = gidisTarihi;
            this.donusTarihi = donusTarihi;
            this.fiyat = fiyat;
            this.ulasimTipi = ulasimTipi;
        }
    }
}
