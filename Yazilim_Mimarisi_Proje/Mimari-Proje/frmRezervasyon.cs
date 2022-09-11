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
    public partial class frmRezervasyon : Form
    {
        private Acente acente;
        private List<Ulasim> ulasimlar;
        private List<Konaklama> konaklamalar;
        public frmRezervasyon()
        {
            InitializeComponent();

            VeriTabaniBaglanti veriTabaniBaglanti = new VeriTabaniBaglanti();

            acente = new Acente(veriTabaniBaglanti);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var secilenUlasimYontemi = grpUlasim.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var secilenKonaklamaYontemi = grpKonaklama.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var secilenKonum = cmbKonum.SelectedItem.ToString();

            UygunKonaklamalariListele(secilenKonum, secilenKonaklamaYontemi.Text, dtpGidis.Value, dtpDonus.Value);
            UygunUlasimlariListele(secilenKonum, secilenUlasimYontemi.Text, dtpGidis.Value, dtpDonus.Value);
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            Konaklama secilenKonaklama;
            Ulasim secilenUlasim;
            Musteri musteri = new Musteri(txtIsım.Text, txtSoyisim.Text, Convert.ToUInt64(txtTC.Text));
            int konaklamaIndex = dgvKonaklama.CurrentRow.Index;
            secilenKonaklama = konaklamalar[konaklamaIndex];

            int ulasimIndex = dgvUlasim.CurrentRow.Index;
            secilenUlasim = ulasimlar[ulasimIndex];


            Rezervasyon rezervasyon = acente.RezervasyonYap(secilenKonaklama, secilenUlasim, musteri);

            frmRezervasyonBilgileri frmRezervasyonBilgileri = new frmRezervasyonBilgileri(rezervasyon);
            frmRezervasyonBilgileri.ShowDialog();
        }

        public void UygunKonaklamalariListele(string konaklanacakKonum, string secilenKonaklamaYontemi, DateTime secilenGidisTarihi,DateTime secilenDonusTarihi)
        {
            dgvKonaklama.Rows.Clear();

            konaklamalar = acente.UygunKonaklamaYerleriniListele(konaklanacakKonum, secilenKonaklamaYontemi);

            foreach (Konaklama konaklama in konaklamalar)
            {
                dgvKonaklama.Rows.Add(konaklama.ad, konaklama.fiyat, konaklama.fiyat * (secilenDonusTarihi.Subtract(secilenGidisTarihi).Days));
            }
        }

        public void UygunUlasimlariListele(string secilenKonum, string secilenUlasimYontemi, DateTime secilenGidisTarihi, DateTime secilenDonusTarihi)
        {
            dgvUlasim.Rows.Clear();

            ulasimlar = acente.UygunUlasimSecenekleriniListele(secilenKonum, secilenUlasimYontemi, secilenGidisTarihi, secilenDonusTarihi);

            foreach (Ulasim ulasim in ulasimlar)
            {
                dgvUlasim.Rows.Add(ulasim.firmaAdi, ulasim.gidisTarihi, ulasim.donusTarihi, ulasim.fiyat);
            }
        }
    }
}
