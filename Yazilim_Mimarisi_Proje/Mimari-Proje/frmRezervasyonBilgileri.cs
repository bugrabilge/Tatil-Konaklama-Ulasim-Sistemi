using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mimari_Proje
{
    public partial class frmRezervasyonBilgileri : Form
    {
        Dictionary<string, RaporBuilderBase> raporBuilders = new Dictionary<string, RaporBuilderBase>();
        public Rezervasyon yapilanRezervasyon { get; set; }
        public frmRezervasyonBilgileri(Rezervasyon yapilanRezervasyon)
        {
            InitializeComponent();
            this.yapilanRezervasyon = yapilanRezervasyon;
            this.yapilanRezervasyon.baslangicTarihi = yapilanRezervasyon.ulasim.gidisTarihi;
            this.yapilanRezervasyon.bitisTarihi = yapilanRezervasyon.ulasim.donusTarihi;
            this.yapilanRezervasyon.rezervasyonKonumu = yapilanRezervasyon.konaklama.konum;
            raporBuilders.Add("XML", new XmlRaporBuilder(yapilanRezervasyon));
            raporBuilders.Add("JSON", new JsonRaporBuilder(yapilanRezervasyon));
            raporBuilders.Add("HTML", new HtmlRaporBuilder(yapilanRezervasyon));
            this.cmbRaporTuru.DataSource = new BindingSource(raporBuilders, null);
            this.cmbRaporTuru.DisplayMember = "Key";
            this.cmbRaporTuru.ValueMember = "Value";
        }

        private void frmRezervasyonBilgileri_Load(object sender, EventArgs e)
        {
            RezervasyonBilgileriniEkranaYansit();
        }

        private void btnKonaklamaIptal_Click(object sender, EventArgs e)
        {
            yapilanRezervasyon.konaklama = null;

            DialogResult result1 = MessageBox.Show("Ulaşım Rezervasyonunu Da İptal Etmek İster Misiniz?",
                                                    "Rezervasyon İptal", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                yapilanRezervasyon.ulasim = null;
                RezervasyonBilgileriniEkranaYansit();
            }
            else
            {
                RezervasyonBilgileriniEkranaYansit();
                return;
            }
        }

        private void btnUlasimIptal_Click(object sender, EventArgs e)
        {
            yapilanRezervasyon.ulasim = null;

            DialogResult result1 = MessageBox.Show("Konaklama Rezervasyonunu Da İptal Etmek İster Misiniz?",
                                                    "Rezervasyon İptal", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                yapilanRezervasyon.konaklama = null;
                RezervasyonBilgileriniEkranaYansit();
            }
            else
            {
                RezervasyonBilgileriniEkranaYansit();
                return;
            }
        }
        private void RezervasyonBilgileriniEkranaYansit()
        {
            TextboxlariTemizle();
            txtYolcuIsim.Text = yapilanRezervasyon.musteri.isim;
            txtYolcuSoyisim.Text = yapilanRezervasyon.musteri.soyIsim;
            txtYolcuTC.Text = yapilanRezervasyon.musteri.TC.ToString();
            txtTatilKonum.Text = yapilanRezervasyon.rezervasyonKonumu;

            if (yapilanRezervasyon.konaklama != null)
            {
                txtKonaklamaTipi.Text = yapilanRezervasyon.konaklama.konaklamaTipi;
                txtKonaklanilacakFirma.Text = yapilanRezervasyon.konaklama.ad;
                txtGunSayisi.Text = (yapilanRezervasyon.bitisTarihi.Subtract(yapilanRezervasyon.baslangicTarihi).Days).ToString();
                txtKonaklamaToplam.Text = yapilanRezervasyon.konaklamaToplamUcret().ToString();
            }

            if (yapilanRezervasyon.ulasim != null)
            {
                txtUlasimTipi.Text = yapilanRezervasyon.ulasim.ulasimTipi;
                txtSeyahatEdilecekFirma.Text = yapilanRezervasyon.ulasim.firmaAdi;
                txtTatilGidisTarihi.Text = yapilanRezervasyon.ulasim.gidisTarihi.ToString();
                txtTatilDonusTarihi.Text = yapilanRezervasyon.ulasim.donusTarihi.ToString();
                txtSeyahatUcret.Text = yapilanRezervasyon.ulasim.fiyat.ToString();
            }

            if (yapilanRezervasyon.konaklama != null && yapilanRezervasyon.ulasim != null)
            {
                txtToplamUcret.Text = yapilanRezervasyon.ToplamUcret().ToString();
            }
        }

        private void TextboxlariTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
            }
        }

        private void btnRaporOlustur_Click(object sender, EventArgs e)
        {
            var raporBuilder = ((KeyValuePair<string, RaporBuilderBase>)cmbRaporTuru.SelectedItem).Value;
            raporBuilder.RaporOlustur();
            var path=raporBuilder.RaporYaz();
            System.Diagnostics.Process.Start(path);
            //MessageBox.Show("Rapor Oluşturuldu.");
        }
    }
}
