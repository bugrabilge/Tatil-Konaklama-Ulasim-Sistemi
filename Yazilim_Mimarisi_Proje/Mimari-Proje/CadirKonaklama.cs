using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari_Proje
{
    public class CadirKonaklama : Konaklama
    {
        public CadirKonaklama(string konum, string ad, int fiyat, string konaklamaTipi)
            : base(konum, ad, fiyat, konaklamaTipi)
        {
        }
    }
}
