using BisarogluOtoGaleri.Business;
using BisarogluOtoGaleri.DataAccess;
using BisarogluOtoGaleri.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic; // <-- BU SATIR ŞART!
using System.IO;

namespace BisarogluOtoGaleri
{
    public partial class FrmAracDetay : Form
    {
        ArabaManager _manager;
        List<string> _secilenDosyaYollari = new List<string>();
        public FrmAracDetay()
        {
            InitializeComponent();
            _manager = new ArabaManager();
        }

        private void FrmAracDetay_Load(object sender, EventArgs e)
        {

        }
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Araç Resimlerini Seçin";
            openFileDialog1.Multiselect = true; // Çoklu seçim açık

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Listeyi temizle
                _secilenDosyaYollari.Clear();

                // Yeni seçilenleri listeye ekle
                _secilenDosyaYollari.AddRange(openFileDialog1.FileNames);

                // Kullanıcıya bilgi ver
                MessageBox.Show($"{_secilenDosyaYollari.Count} adet resim seçildi.");

                // İlk resmi göster
                if (_secilenDosyaYollari.Count > 0)
                {
                    pbxAracResim.ImageLocation = _secilenDosyaYollari[0];
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Formdaki verileri Araba nesnesine doldur
                Araba yeniAraba = new Araba();

                // Sayısal değerleri çevirirken (Convert) hata olmaması için basit önlem:
                yeniAraba.MarkaID = int.Parse(txtMarka.Text);
                yeniAraba.ModelID = int.Parse(txtModel.Text);
                yeniAraba.Yil = int.Parse(txtYil.Text);
                yeniAraba.MarkaID = int.Parse(txtMarka.Text);
                yeniAraba.Kilometre = int.Parse(txtKilometre.Text);
                yeniAraba.VitesTipi = cmbVites.Text;
                yeniAraba.YakitTuru = cmbYakit.Text;
                yeniAraba.AgirHasarKayitliMi = chkAgirHasar.Checked;
                decimal fiyat;
                decimal.TryParse(txtFiyat.Text, out fiyat);
                yeniAraba.Fiyat = fiyat;

                if (_secilenDosyaYollari.Count > 0)
                {
                    // Değişkeni burada oluşturuyoruz: Adı 'kapakResimAdi'
                    string kapakResimAdi = _manager.ResimDosyasiniYonet(_secilenDosyaYollari[0]);

                    // Oluşturduğumuz değişkeni buraya veriyoruz (İsimler aynı!)
                    yeniAraba.ResimYolu = kapakResimAdi;
                }
                else
                {
                    yeniAraba.ResimYolu = ""; // Resim seçilmediyse boş geç
                }




                // Sabit değerler (Şimdilik)
                
                yeniAraba.Durum = "Satılık";
                yeniAraba.DegisenParcaSayisi = 0;
                yeniAraba.BoyaliParcaSayisi = 0;

                
                int yeniArabaID = _manager.ArabaEkle(yeniAraba);
                // 2. Manager'a gönder
                //_manager.ArabaEkle(yeniAraba);

                foreach (string dosyaYolu in _secilenDosyaYollari)
                {
                    // Dosyayı kopyala
                    string kaydedilenAd = _manager.ResimDosyasiniYonet(dosyaYolu);

                    // Resim nesnesini oluştur
                    AracResim resim = new AracResim();
                    resim.ArabaID = yeniArabaID; // ID bağlantısını kurduk!
                    resim.ResimYolu = kaydedilenAd;

                    // Veritabanına ekle
                    _manager.ResimEkle(resim);
                }
                MessageBox.Show("İşlem Başarılı!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        
    }
}
