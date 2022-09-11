using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari_Proje
{
    public class KonaklamaFactory
    {
        public Konaklama KonaklamaOlustur(string konaklamaTipi, string konum, string firmaAdi, int fiyat)
        {
            switch (konaklamaTipi)
            {
                case "Çadır":
                    return new CadirKonaklama(konum, firmaAdi, fiyat, konaklamaTipi);

                case "Otel":
                    return new OtelKonaklama(konum, firmaAdi, fiyat, konaklamaTipi);

                default:
                    return null;
            }
        }
    }
}
