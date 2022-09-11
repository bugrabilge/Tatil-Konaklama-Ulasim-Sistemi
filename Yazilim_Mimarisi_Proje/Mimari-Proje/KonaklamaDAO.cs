using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari_Proje
{
    public class KonaklamaDAO
    {
        private VeriTabaniBaglanti _veritabani;
        private KonaklamaFactory _konaklamaFactory;

        public KonaklamaDAO(VeriTabaniBaglanti veritabani, KonaklamaFactory konaklamaFactory)
        {
            this._veritabani = veritabani;
            this._konaklamaFactory = konaklamaFactory;
        }

        public List<Konaklama> UygunKonaklamaYerleriniListele(string konaklanacakKonum, string secilenKonaklamaYontemi)
        {
            List<Konaklama> konaklamalar = new List<Konaklama>();

            _veritabani.BaglantiAc();
            _veritabani.SorguCalistir("SELECT * FROM dbo.KonaklamaYerleri " +
                                           "WHERE Konum = '" + konaklanacakKonum + "' AND KonaklamaTipi = '" + secilenKonaklamaYontemi + "'");

            while (_veritabani.VeriOkuyucu.Read())
            {
                Konaklama konaklama = _konaklamaFactory.KonaklamaOlustur(
                    secilenKonaklamaYontemi,
                    konaklanacakKonum,
                    _veritabani.SonucOku("FirmaAdi"),
                    Convert.ToInt32(_veritabani.SonucOku("Fiyat")));

                konaklamalar.Add(konaklama);
            }
            _veritabani.BaglantiyiKes();

            return konaklamalar;
        }
    }
}
