using BisarogluOtoGaleri.Business;
using BisarogluOtoGaleri.DataAccess;
using BisarogluOtoGaleri.Entity;
using DevExpress.RichEdit.Core.Accessibility;
using System;
using System.Collections.Generic; // <-- BU SATIR ŞART!
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BisarogluOtoGaleri
{
    public partial class FrmAracDetay : Form
    {
        ArabaManager _manager;
        List<string> _secilenDosyaYollari = new List<string>(); // Yeni seçilen resimlerin yolları
        List<string> _dbGelenResimler = new List<string>();     // Veritabanından gelen mevcut resim adları
        int _aktifResimIndex = 0; // Galeri gezinme indeksi
        int _gelenArabaID = 0;

        public FrmAracDetay(int id = 0)
        {
            InitializeComponent();
            
            
            // Gelen ID'yi içeri alıyoruz
            _gelenArabaID = id;

            // Manager'ı hatasız başlatmak için (1. Çözümdeki yapıya uygun)
            _manager = new ArabaManager(new ArabaDal());
        }

        private void FrmAracDetay_Load(object sender, EventArgs e)
        {
            MarkalariYukle();
            lkeModel.EditValue = null;
            lkeModel.Properties.DataSource = null;

            if (_gelenArabaID > 0)
            {
                BilgileriGetir(_gelenArabaID);
                ResimleriGetir(_gelenArabaID);

                // Düzenleme modunda olduğumuz için Kaydet butonu yerine "Güncelle" mantığı çalışmalı
                btnKaydet.Text = "GÜNCELLE";
            }
            else
            {
                // Yeni kayıt modu: İleri/Geri butonlarını gizle
                btnGeri.Visible = false;
                btnIleri.Visible = false;
                lblResimSayac.Visible = false;
                this.Text = "Yeni Araç Girişi";
            }
        }
        void MarkalariYukle()
        {
            var markalar = _manager.MarkalariGetir();

            // LookUpEdit Ayarları (Bunları Kodla Yapıyoruz ki sağlam olsun)
            lkeMarka.Properties.DataSource = markalar;
            lkeMarka.Properties.DisplayMember = "MarkaAdi"; // Ekranda görünen
            lkeMarka.Properties.ValueMember = "MarkaID";    // Arkada tutulan ID

            lkeMarka.Properties.NullText = "Marka Seçiniz...";
            lkeMarka.Properties.PopulateColumns();
            if (lkeMarka.Properties.Columns["MarkaID"] != null)
                lkeMarka.Properties.Columns["MarkaID"].Visible = false;
        }
        private void lkeMarka_EditValueChanged(object sender, EventArgs e)
        {
            // Seçilen Marka ID'yi al
            if (lkeMarka.EditValue != null)
            {
                int secilenID = Convert.ToInt32(lkeMarka.EditValue);
                var modeller = _manager.ModelleriGetir(secilenID);

                lkeModel.Properties.DataSource = modeller;

                // --- BU İKİ SATIR HAYATİ ÖNEM TAŞIR ---
                lkeModel.Properties.DisplayMember = "ModelAdi"; // Ekranda 'X5' yazsın
                lkeModel.Properties.ValueMember = "ModelID";    // Arkada '102' tutsun

                // Gereksiz sütunları gizle (Opsiyonel ama şık durur)
                lkeModel.Properties.NullText = "Model Seçiniz";
                lkeModel.Properties.PopulateColumns();
                if (lkeModel.Properties.Columns["ModelID"] != null)
                    lkeModel.Properties.Columns["ModelID"].Visible = false;
                if (lkeModel.Properties.Columns["MarkaID"] != null)
                    lkeModel.Properties.Columns["MarkaID"].Visible = false;
            }
        }

        void ResimleriGetir(int id)
        {
            // Manager'dan resim listesini çek (Bunu az önce yazmıştık)
            _dbGelenResimler = _manager.ResimleriGetir(id);

            if (_dbGelenResimler.Count > 0)
            {
                _aktifResimIndex = 0;
                DbResminiGoster();

                // Butonları göster
                btnGeri.Visible = true;
                btnIleri.Visible = true;
                lblResimSayac.Visible = true;
            }
        }
        void DbResminiGoster()
        {
            if (_dbGelenResimler.Count == 0) return;

            string dosyaAdi = _dbGelenResimler[_aktifResimIndex];
            string tamYol = Path.Combine(Application.StartupPath, "AracResimleri", dosyaAdi);

            if (File.Exists(tamYol))
            {
                pbxAracResim.ImageLocation = tamYol;
                lblResimSayac.Text = $"{_aktifResimIndex + 1} / {_dbGelenResimler.Count}";
            }
            else
            {
                // Resim veritabanında var ama klasörde yoksa placeholder gösterilebilir.
                pbxAracResim.Image = null;
            }
        }
        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (_aktifResimIndex < _dbGelenResimler.Count - 1)
            {
                _aktifResimIndex++;
                DbResminiGoster();
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (_aktifResimIndex > 0)
            {
                _aktifResimIndex--;
                DbResminiGoster();
            }
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
        void BilgileriGetir(int id)
        {
            // 1. Veritabanından aracı çek
            Araba gelenAraba = _manager.ArabaGetir(id);

            if (gelenAraba != null)
            {
                // LookUpEdit'lere ID atayınca otomatik olarak metni gösterirler
                lkeMarka.EditValue = gelenAraba.MarkaID;
                // Marka seçilince Model event'i tetiklenir, ardından modeli seçeriz.
                Application.DoEvents(); // Eventin işlenmesini bekle
                lkeModel.EditValue = gelenAraba.ModelID;

                txtYil.Text = gelenAraba.Yil.ToString();
                txtKilometre.Text = gelenAraba.Kilometre.ToString();
                txtFiyat.Text = gelenAraba.Fiyat.ToString();
                chkAgirHasar.Checked = gelenAraba.AgirHasarKayitliMi;

                // --- EKLENEN KISIM: Yakıt ve Vites Bilgilerini Getir ---
                // (UI'da bu isimde ComboBox'lar olduğunu varsayıyorum)
                cmbYakit.Text = gelenAraba.YakitTuru;
                cmbVites.Text = gelenAraba.VitesTipi;
                // -----------------------------------------------------

                this.Text = $"Araç Düzenle - Kayıt No: {id}";
            }
            else
            {
                BisarogluMsg.Goster("Araç bilgileri veritabanından okunamadı!", "Hata");
                this.Close();
            }
        }
        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lkeMarka.EditValue == null || lkeModel.EditValue == null || string.IsNullOrEmpty(txtFiyat.Text))
            {
                BisarogluMsg.Goster("Lütfen Marka, Model ve Fiyat bilgilerini eksiksiz giriniz.", "Uyarı");
                return;
            }
            try
            {
                // 1. Nesneyi Oluştur ve Ortak Verileri Doldur
                Araba arabaNesnesi = new Araba();

                // --- TEXTBOX VERİLERİNİ AL (Kendi formuna göre düzenle) ---
                arabaNesnesi.MarkaID = Convert.ToInt32(lkeMarka.EditValue);
                arabaNesnesi.ModelID = Convert.ToInt32(lkeModel.EditValue);
                arabaNesnesi.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                arabaNesnesi.Yil = Convert.ToInt32(txtYil.Text);
                arabaNesnesi.Kilometre = Convert.ToInt32(txtKilometre.Text);
                arabaNesnesi.YakitTuru = cmbYakit.Text;
                arabaNesnesi.VitesTipi = cmbVites.Text;
                arabaNesnesi.AgirHasarKayitliMi = chkAgirHasar.Checked;


                // 2. RESİM MANTIĞI (Hem Ekleme Hem Güncelleme İçin)

                bool yeniResimSecildiMi = _secilenDosyaYollari.Count > 0;

                if (yeniResimSecildiMi)
                {
                    // Yeni resim seçildiyse, ilki kapak resmi olur, klasöre kopyalanır.
                    string kapakResimAdi = _manager.ResimDosyasiniYonet(_secilenDosyaYollari[0]);
                    arabaNesnesi.ResimYolu = kapakResimAdi;
                }
                else
                {
                    // Yeni resim seçilmediyse:
                    if (_gelenArabaID > 0)
                    {
                        arabaNesnesi.ResimYolu = null; // Veya mevcut path
                    }
                }



                // 3. KARAR ANI: EKLEME Mİ, GÜNCELLEME Mİ?

                if (_gelenArabaID == 0)
                {
                    // === YENİ KAYIT MODU ===
                    int yeniID = _manager.ArabaEkle(arabaNesnesi);

                    // Ekstra resimleri kaydet
                    EkstraResimleriKaydet(yeniID);

                    BisarogluMsg.Goster("Yeni araç başarıyla eklendi!", "Bilgi");
                }
                else
                {
                    // === GÜNCELLEME MODU ===
                    arabaNesnesi.ArabaID = _gelenArabaID; // Hangi aracı güncelleyeceğimizi belirtiyoruz!

                    // Eğer yeni resim seçilmediyse, eski resim yolunun kaybolmaması lazım.
                    // Bu yüzden buraya küçük bir "Veritabanındaki Eski Resmi Çek" kodu gerekebilir.
                    // Şimdilik eğer resim seçilmediyse "null" gönderiyoruz, 
                    // DAL tarafında NULL ise güncelleme yapma diyebiliriz (bunu DAL'da yapmadık henüz).

                    _manager.ArabaGuncelle(arabaNesnesi);

                    // Eğer yeni resimler seçildiyse onları da galeriye EKLE (Eskileri silmiyoruz, üstüne ekliyoruz)
                    if (yeniResimSecildiMi)
                    {
                        EkstraResimleriKaydet(_gelenArabaID);
                    }

                    BisarogluMsg.Goster("Araç bilgileri güncellendi!", "Bilgi");
                }

                this.Close();
            }
            catch (FormatException)
            {
                BisarogluMsg.Goster("Fiyat, Yıl veya Kilometre alanlarına geçersiz bir değer girdiniz. Lütfen sadece sayı kullanın.", "Hata");
            }
            catch (Exception ex)
            {
                BisarogluMsg.Goster("Hata: " + ex.Message);
            }
        }
        void EkstraResimleriKaydet(int arabaID)
        {
            foreach (string dosyaYolu in _secilenDosyaYollari)
            {
                string kaydedilenAd = _manager.ResimDosyasiniYonet(dosyaYolu);
                AracResim resim = new AracResim();
                resim.ArabaID = arabaID;
                resim.ResimYolu = kaydedilenAd;
                _manager.ResimEkle(resim);
            }
        }

        private void cmbYakit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
