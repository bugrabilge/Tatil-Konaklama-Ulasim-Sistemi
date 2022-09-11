using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari_Proje
{
    public class UlasimDAO
    {
        private VeriTabaniBaglanti _veritabani;
        private UlasimFactory _ulasimFactory;

        public UlasimDAO(VeriTabaniBaglanti veritabani, UlasimFactory ulasimFactory)
        {
            this._veritabani = veritabani;
            this._ulasimFactory = ulasimFactory;
        }

        public List<Ulasim> UygunUlasimSecenekleriniListele(string seyahatEdilecekKonum, string secilenUlasimYontemi, DateTime secilenGidisTarihi, DateTime secilenDonusTarihi)
        {
            List<Ulasim> ulasimlar = new List<Ulasim>();

            _veritabani.BaglantiAc();
            _veritabani.SorguCalistir("SELECT * FROM dbo.UlasimAraclari " +
                                           "WHERE Hedef = '" + seyahatEdilecekKonum + "' AND UlasimTipi = '" + secilenUlasimYontemi + "'");

            while (_veritabani.VeriOkuyucu.Read())
            {
                var veritabaniGidisSaati = Convert.ToDateTime(_veritabani.SonucOku("GidisSaati"));
                secilenGidisTarihi = secilenGidisTarihi.AddHours(-secilenGidisTarihi.Hour).AddMinutes(-secilenGidisTarihi.Minute).AddSeconds(-secilenGidisTarihi.Second);
                secilenGidisTarihi = secilenGidisTarihi.AddHours(veritabaniGidisSaati.Hour).AddMinutes(veritabaniGidisSaati.Minute);
                var veritabaniDonusSaati = Convert.ToDateTime(_veritabani.SonucOku("DonusSaati"));
                secilenDonusTarihi = secilenDonusTarihi.AddHours(-secilenDonusTarihi.Hour).AddMinutes(-secilenDonusTarihi.Minute).AddSeconds(-secilenDonusTarihi.Second);
                secilenDonusTarihi = secilenDonusTarihi.AddHours(veritabaniDonusSaati.Hour).AddMinutes(veritabaniDonusSaati.Minute);

                Ulasim ulasim = _ulasimFactory.UlasimOlustur(
                    secilenUlasimYontemi,
                    _veritabani.SonucOku("FirmaAdi"),
                    secilenGidisTarihi,
                    secilenDonusTarihi,
                    Convert.ToInt32(_veritabani.SonucOku("Fiyat")));

                ulasimlar.Add(ulasim);
            }
            _veritabani.BaglantiyiKes();

            return ulasimlar;
        }
    }
}
