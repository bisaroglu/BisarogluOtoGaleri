using System;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace BisarogluOtoGaleri
{
    public partial class FrmAnaSayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private void btnAracListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmAracListesi) // Eğer form zaten açıksa
                {
                    form.Activate(); // Formu öne getir

                    // İŞTE SİHİRLİ DOKUNUŞ BURADA:
                    // Formu öne getirirken verileri de veritabanından tekrar çek!
                    ((FrmAracListesi)form).Listele();

                    return; // Yeni form açma, buradan çık.
                }
            }

            // 2. Eğer açık değilse sıfırdan oluştur
            FrmAracListesi frm = new FrmAracListesi();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnYeniArac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAracDetay frm = new FrmAracDetay();
            frm.ShowDialog(); // Kod burada bekler, kullanıcı formu kapatana kadar aşağı geçmez.

            // 2. Kullanıcı işini bitirip formu kapattığında burası çalışır.
            // Açık olan Araç Listesi formu varsa bul ve yenile.
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmAracListesi)
                {
                    ((FrmAracListesi)form).Listele(); // Listeyi güncelle!
                }
            }
        }
        // Gelen kullanıcının rolünü hafızada tutmak için değişken
        private string _gelenRol;

        // --- YAPICI METOD (CONSTRUCTOR) ---
        // Burası Login formundan gönderilen "Yönetici" veya "Satış Uzmanı" yazısını karşılar.
        public FrmAnaSayfa(string rol)
        {
            InitializeComponent();
            _gelenRol = rol;
        }

        // --- FORM YÜKLENİRKEN (LOAD EVENT) ---
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            // 1. Formun başlığına kimin girdiğini yazalım (Profesyonel görünüm)
            this.Text = $"BİŞAROĞLU OTOMOTİV - Yönetim Paneli | Aktif Kullanıcı: {_gelenRol}";

            // 2. YETKİLENDİRME KONTROLÜ
            if (_gelenRol == "Satış Uzmanı")
            {
                // Eğer giren kişi Satış Uzmanı ise Raporlar sekmesini gizle.

                // DİKKAT: Tasarım ekranında "İstatistik ve Raporlar" sekmesine tıklayıp
                // Properties panelinden (Name) kısmını 'ribbonPageRaporlar' yapmalısın.
                // Eğer yapmadıysan aşağıdaki satır hata verebilir.
                if (ribbonPageRaporlar != null)
                {
                    ribbonPageRaporlar.Visible = false;
                }
            }
        }
    }
}