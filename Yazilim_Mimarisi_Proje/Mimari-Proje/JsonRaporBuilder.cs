using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Mimari_Proje
{
    public class JsonRaporBuilder : RaporBuilderBase
    {
        public JsonRaporBuilder(Rezervasyon rezervasyon) : base(rezervasyon)
        {
        }
        public override string SeyahatBilgileriniGetir()
        {
            return JsonConvert.SerializeObject(new { baslangicTarihi = rezervasyon.baslangicTarihi, bitisTarihi = rezervasyon.bitisTarihi, rezervasyonKonumu = rezervasyon.rezervasyonKonumu , kullanici = rezervasyon.musteri });
        }

        public override string KonaklamaBilgileriniGetir()
        {
            return JsonConvert.SerializeObject(new
                {konaklamaTipi = rezervasyon.konaklama?.konaklamaTipi, fiyat = rezervasyon.konaklama?.fiyat});
        }

        public override string UlasimBilgileriniGetir()
        {
            return JsonConvert.SerializeObject(new { fiyat = rezervasyon.ulasim?.fiyat, ulasimTipi = rezervasyon.ulasim?.ulasimTipi });
        }
        public override string OdemeBilgileriniGetir()
        {
            return JsonConvert.SerializeObject(new {  odemeTutari = rezervasyon.ToplamUcret() });
        }
        public override string RaporOlustur()
        {
            JToken seyahatBilgileriJson = JObject.Parse(SeyahatBilgileriniGetir());
            JToken konaklamaBilgileriJson = JObject.Parse(KonaklamaBilgileriniGetir());
            JToken ulasimBilgileriJson = JObject.Parse(UlasimBilgileriniGetir());
            JToken odemeBilgileriJson = JObject.Parse(OdemeBilgileriniGetir());
            JObject raporJson = new JObject();
            raporJson.Add("Seyahat Bilgileri", seyahatBilgileriJson);
            raporJson.Add("Konaklama Bilgileri", konaklamaBilgileriJson);
            raporJson.Add("Ulaşım Bilgileri", ulasimBilgileriJson);
            raporJson.Add("Ödeme Bilgileri", odemeBilgileriJson);
            return raporJson.ToString();
        }
        public override string RaporYaz(string path = "", string uzanti = "")
        {
            if (string.IsNullOrEmpty(uzanti))
                uzanti = ".json";
            return base.RaporYaz(path, uzanti);
        }
    }
}