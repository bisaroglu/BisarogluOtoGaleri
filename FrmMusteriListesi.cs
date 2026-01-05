using BisarogluOtoGaleri.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisarogluOtoGaleri
{
    public partial class FrmMusteriListesi : Form
    {
        MusteriManager _manager = new MusteriManager();

        public FrmMusteriListesi()
        {
            InitializeComponent();
        }

        private void FrmMusteriListesi_Load(object sender, EventArgs e)
        {
            Listele(); // Temiz kod prensibi: İşi metoda yaptır
            GridAyarlari(); // Sütun başlıklarını düzeltelim
        }

        public void Listele()
        {
            // Veritabanından çekip Grid'e basıyoruz
            gridControl1.DataSource = _manager.MusterileriGetir();
        }

        void GridAyarlari()
        {
            // 1. KULLANICI GÖRÜNÜMÜNÜ DÜZELTME (Best Practice)

            // ID kullanıcıyı ilgilendirmez, gizleyelim
            gridView1.Columns["MusteriID"].Visible = false;

            // Başlıkları Türkçeleştirelim
            gridView1.Columns["Ad"].Caption = "Müşteri Adı";
            gridView1.Columns["Soyad"].Caption = "Soyadı";
            gridView1.Columns["TCKimlik"].Caption = "TC Kimlik No"; // Senin Entity'deki ismin
            gridView1.Columns["Telefon"].Caption = "Telefon";
            gridView1.Columns["Mail"].Caption = "E-Posta";
            gridView1.Columns["Adres"].Caption = "Adres";

            // "AdSoyad" diye birleşmiş property yapmıştık ya, onu gösterelim mi?
            // İstersen Ad ve Soyad sütunlarını gizleyip sadece onu da gösterebilirsin.
            // Şimdilik ayrı kalsınlar.
            // GEREKSİZ SÜTUNU GİZLE
            // Entity'de tanımladığımız birleşik property'yi gizleyelim.
            if (gridView1.Columns["AdSoyad"] != null)
            {
                gridView1.Columns["AdSoyad"].Visible = false;
            }

            // ID'yi de gizlemiş miydik?
            if (gridView1.Columns["MusteriID"] != null)
            {
                gridView1.Columns["MusteriID"].Visible = false;
            }
            // 2. GÜVENLİK
            // Kullanıcı listede kafasına göre değişiklik yapamasın (Sadece seçsin)
            gridView1.OptionsBehavior.Editable = false;

            // Otomatik sığdırma (Best Fit)
            gridView1.BestFitColumns();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }
    }
}
