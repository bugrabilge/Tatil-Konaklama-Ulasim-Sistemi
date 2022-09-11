using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari_Proje
{
    public class HtmlRaporBuilder : RaporBuilderBase
    {
        public HtmlRaporBuilder(Rezervasyon rezervasyonBilgileri) : base(rezervasyonBilgileri)
        {
        }

        public override string SeyahatBilgileriniGetir()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Baslangıç Tarihi", typeof(string)),
                new DataColumn("Bitiş Tarihi", typeof(string)),
                new DataColumn("Rezervasyon Konumu", typeof(string)),
                new DataColumn("Kullanıcı Adı",typeof(string)),
                new DataColumn("Kullanıcı Soyadı",typeof(string)),
                new DataColumn("Kullanıcı Kimlik Numarası",typeof(string))

            });

            dt.Rows.Add(rezervasyon.baslangicTarihi.ToString("dd/MM/yyyy"),
                rezervasyon.bitisTarihi.ToString("dd/MM/yyyy"), rezervasyon.rezervasyonKonumu, rezervasyon.musteri.isim, rezervasyon.musteri.soyIsim, rezervasyon.musteri.TC);

            return DataTableToHtml(dt);
        }

        private static string DataTableToHtml(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(
                "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:Arial'>");

            sb.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                sb.Append("<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.ColumnName +
                          "</th>");
            }

            sb.Append("</tr>");

            foreach (DataRow row in dt.Rows)
            {
                sb.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    sb.Append("<td style='width:100px;border: 1px solid #ccc'>" + row[column.ColumnName].ToString() +
                              "</td>");
                }

                sb.Append("</tr>");
            }

            sb.Append("</table>");

            return sb.ToString();
        }

        public override string KonaklamaBilgileriniGetir()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Konaklama Tipi", typeof(string)),
                new DataColumn("Konaklama Fiyatı", typeof(string)),
            });
            dt.Rows.Add(rezervasyon.konaklama?.konaklamaTipi, rezervasyon.konaklama?.fiyat.ToString());
            return DataTableToHtml(dt);
        }

        public override string UlasimBilgileriniGetir()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Ulaşım Tipi", typeof(string)),
                new DataColumn("Ulaşım Fiyatı", typeof(string)),
            });
            dt.Rows.Add(rezervasyon.ulasim?.ulasimTipi, rezervasyon.ulasim?.fiyat.ToString());
            return DataTableToHtml(dt);
        }

        public override string OdemeBilgileriniGetir()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Ödeme Tutarı", typeof(string)),
            });
            dt.Rows.Add(rezervasyon.ToplamUcret().ToString());
            return DataTableToHtml(dt);
        }

        public override string RaporOlustur()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html>");
            sb.Append("<head>");
            sb.Append("<title>Rezervasyon Raporu</title>");
            sb.Append("</head>");
            sb.Append("<body>");
            sb.Append("<h1>Rezervasyon Raporu</h1>");
            sb.Append("<h2>Seyahat Bilgileri</h2>");
            sb.Append(SeyahatBilgileriniGetir());
            sb.Append("<h2>Konaklama Bilgileri</h2>");
            sb.Append(KonaklamaBilgileriniGetir());
            sb.Append("<h2>Ulaşım Bilgileri</h2>");
            sb.Append(UlasimBilgileriniGetir());
            sb.Append("<h2>Ödeme Bilgileri</h2>");
            sb.Append(OdemeBilgileriniGetir());
            sb.Append("</body>");
            sb.Append("</html>");
            return sb.ToString();
        }
        public override string RaporYaz(string path = "", string uzanti = "")
        {
            if (string.IsNullOrEmpty(uzanti))
            {
                uzanti = ".html";
            }
            return base.RaporYaz(path, uzanti);
        }
    }
}