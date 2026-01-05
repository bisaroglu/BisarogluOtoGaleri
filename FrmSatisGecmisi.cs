using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BisarogluOtoGaleri.DataAccess; // SatisDal burada
using BisarogluOtoGaleri.Entity;     // Satis sınıfı burada

namespace BisarogluOtoGaleri
{
    public partial class FrmSatisGecmisi : Form
    {
        SatisManager _manager = new SatisManager();

        public FrmSatisGecmisi()
        {
            InitializeComponent();
        }

        private void FrmSatisGecmisi_Load(object sender, EventArgs e)
        {
            Listele();       // 1. Veriyi Getir
            GridAyarlari();  // 2. Tabloyu Düzenle
        }

        // --- VERİYİ ÇEKME METODU ---
        public void Listele()
        {
            // Manager üzerinden veriyi çekip Grid'e basıyoruz
            gridControl1.DataSource = _manager.SatislariGetir();
        }

        // --- GÖRÜNÜM AYARLARI METODU ---
        void GridAyarlari()
        {
            // GridView null kontrolü (Proje patlamasın diye)
            if (gridView1.Columns.Count == 0) return;

            // 1. GİZLENECEK SÜTUNLAR
            if (gridView1.Columns["SatisID"] != null)
                gridView1.Columns["SatisID"].Visible = false;

            if (gridView1.Columns["ArabaID"] != null)
                gridView1.Columns["ArabaID"].Visible = false;

            if (gridView1.Columns["MusteriID"] != null)
                gridView1.Columns["MusteriID"].Visible = false;

            // 2. BAŞLIK İSİMLERİ (Caption)
            if (gridView1.Columns["AracBilgi"] != null)
                gridView1.Columns["AracBilgi"].Caption = "Satılan Araç";

            if (gridView1.Columns["MusteriAdSoyad"] != null)
                gridView1.Columns["MusteriAdSoyad"].Caption = "Müşteri";

            if (gridView1.Columns["GercekSatisFiyati"] != null)
            {
                gridView1.Columns["GercekSatisFiyati"].Caption = "Satış Tutarı";
                // Para birimi formatı
                gridView1.Columns["GercekSatisFiyati"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns["GercekSatisFiyati"].DisplayFormat.FormatString = "c2";
            }

            if (gridView1.Columns["SatisTarihi"] != null)
                gridView1.Columns["SatisTarihi"].Caption = "Tarih";

            // 3. GENEL AYARLAR
            gridView1.OptionsBehavior.Editable = false; // Düzenlemeyi kapat
            gridView1.BestFitColumns(); // Sütunları sığdır
        }
    }
}