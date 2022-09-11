using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari_Proje
{
    public class Musteri
    {
        public string isim { get; set; }
        public string soyIsim { get; set; }
        public ulong TC { get; set; }

        public Musteri(string isim, string soyisim, ulong tc)
        {
            this.isim = isim;
            this.soyIsim = soyisim;
            this.TC = tc;
        }
    }
}
