using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari_Proje
{
    public class UlasimFactory
    {
        public Ulasim UlasimOlustur(string ulasimTipi, string firmaAdi, DateTime gidisTarihi, DateTime donusTarihi, int fiyat)
        {
            switch (ulasimTipi)
            {
                case "Otobüs":
                    return new OtobusUlasim(firmaAdi, gidisTarihi, donusTarihi, fiyat, ulasimTipi);

                case "Uçak":
                    return new UcakUlasim(firmaAdi, gidisTarihi, donusTarihi, fiyat, ulasimTipi);

                default:
                    return null;
            }
        }
    }
}
