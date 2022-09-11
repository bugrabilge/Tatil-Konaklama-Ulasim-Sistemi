using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari_Proje
{
    public abstract class RaporBuilderBase
    {
        protected Rezervasyon rezervasyon;

        public RaporBuilderBase(Rezervasyon rezervasyonBilgileri)
        {
            this.rezervasyon = rezervasyonBilgileri;
        }

        public abstract string SeyahatBilgileriniGetir();
        public abstract string KonaklamaBilgileriniGetir();
        public abstract string UlasimBilgileriniGetir();
        public abstract string OdemeBilgileriniGetir();
        public abstract string RaporOlustur();
        
        public virtual string RaporYaz(string path="",string uzanti="")
        {
            
            if(string.IsNullOrEmpty(path))
                path= Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path=Path.Combine(path, "Rapor");
            path += uzanti;
            File.WriteAllText(path, RaporOlustur());
            return path;
        }
    }
}