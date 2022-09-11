using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mimari_Proje
{
    public class Acente
    {
        private UlasimDAO _ulasimDAO;
        private KonaklamaDAO _konaklamaDAO;

        public Acente(VeriTabaniBaglanti veriTabaniBaglanti)
        {
            _ulasimDAO = new UlasimDAO(veriTabaniBaglanti, new UlasimFactory());
            _konaklamaDAO = new KonaklamaDAO(veriTabaniBaglanti, new KonaklamaFactory());
        }

        public Rezervasyon RezervasyonYap(Konaklama konaklama, Ulasim ulasim, Musteri musteri)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.konaklama = konaklama;
            rezervasyon.ulasim = ulasim;
            rezervasyon.musteri = musteri;
            return rezervasyon;
        }

        public List<Ulasim> UygunUlasimSecenekleriniListele(string seyahatEdilecekKonum, string secilenUlasimYontemi, DateTime secilenGidisTarihi, DateTime secilenDonusTarihi)
        {
            return _ulasimDAO.UygunUlasimSecenekleriniListele(seyahatEdilecekKonum, secilenUlasimYontemi, secilenGidisTarihi, secilenDonusTarihi);
        }

        public List<Konaklama> UygunKonaklamaYerleriniListele(string konaklanacakKonum, string secilenKonaklamaYontemi)
        {
            return _konaklamaDAO.UygunKonaklamaYerleriniListele(konaklanacakKonum, secilenKonaklamaYontemi);
        }
    }
}
