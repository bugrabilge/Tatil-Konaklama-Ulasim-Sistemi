using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Mimari_Proje
{
    public class XmlRaporBuilder : RaporBuilderBase
    {
        public XmlRaporBuilder(Rezervasyon rezervasyonBilgileri) : base(rezervasyonBilgileri)
        {
        }

        public override string SeyahatBilgileriniGetir()
        {
            var seyahatBilgileri = new
            {
                baslangicTarihi = rezervasyon.baslangicTarihi,
                bitisTarihi = rezervasyon.bitisTarihi,
                rezervasyonKonumu = rezervasyon.rezervasyonKonumu,
                kullanici=rezervasyon.musteri
            };

            return seyahatBilgileri.ToXml("SeyahatBilgileri").ToString();


        }

        public override string KonaklamaBilgileriniGetir()
        {
            var konaklamaBilgileri = new
            { konaklamaTipi = rezervasyon.konaklama?.konaklamaTipi, fiyat = rezervasyon.konaklama?.fiyat };

            return konaklamaBilgileri.ToXml("KonaklamaBilgileri").ToString();

        }

        public override string UlasimBilgileriniGetir()
        {
            var ulasimBilgileri = new { fiyat = rezervasyon.ulasim?.fiyat, ulasimTipi = rezervasyon.ulasim?.ulasimTipi };

            return ulasimBilgileri.ToXml("UlasimBilgileri").ToString();

        }

        public override string OdemeBilgileriniGetir()
        {
            var odemeBilgileri = new { odemeTutari = rezervasyon.ToplamUcret() };

            return odemeBilgileri.ToXml("OdemeBilgileri").ToString();

        }

        public override string RaporOlustur()
        {
            XmlDocument xml = new XmlDocument();
            var root = xml.CreateElement("Rezervasyon");
            xml.AppendChild(root);
            var seyahatBilgileri = xml.CreateDocumentFragment();
            seyahatBilgileri.InnerXml = SeyahatBilgileriniGetir();
            root.AppendChild(seyahatBilgileri);
            XmlNode konaklamaBilgileri = xml.CreateDocumentFragment();
            konaklamaBilgileri.InnerXml = KonaklamaBilgileriniGetir();
            root.AppendChild(konaklamaBilgileri);
            XmlNode ulasimBilgileri = xml.CreateDocumentFragment();
            ulasimBilgileri.InnerXml = UlasimBilgileriniGetir();
            root.AppendChild(ulasimBilgileri);
            XmlNode odemeBilgileri = xml.CreateDocumentFragment();
            odemeBilgileri.InnerXml = OdemeBilgileriniGetir();
            root.AppendChild(odemeBilgileri);
            return xml.OuterXml;
        }
        public override string RaporYaz(string path = "", string uzanti = "")
        {
            if (string.IsNullOrEmpty(uzanti))
                uzanti = ".xml";
            return base.RaporYaz(path, uzanti);
        }

    }

    public static class Tools
    {
        private static readonly Type[] WriteTypes = new[] {
        typeof(string), typeof(DateTime), typeof(Enum),
        typeof(decimal), typeof(Guid),
    };
        public static bool IsSimpleType(this Type type)
        {
            return type.IsPrimitive || WriteTypes.Contains(type);
        } 
        public static XElement ToXml(this object input)
        {
            return input.ToXml(null);
        }
        public static XElement ToXml(this object input, string element)
        {
            if (input == null)
                return null;

            if (string.IsNullOrEmpty(element))
                element = "object";
            element = XmlConvert.EncodeName(element);
            var ret = new XElement(element);

            if (input != null)
            {
                var type = input.GetType();
                var props = type.GetProperties();

                var elements = from prop in props
                               let name = XmlConvert.EncodeName(prop.Name)
                               let val = prop.GetValue(input, null)
                               let value = prop.PropertyType.IsSimpleType()
                                    ? new XElement(name, val)
                                    : val.ToXml(name)
                               where value != null
                               select value;

                ret.Add(elements);
            }

            return ret;
        }
    }
}
