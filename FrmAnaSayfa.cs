using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Drawing;
using System.Windows.Controls.Ribbon;
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

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
        FrmMusteriListesi _frmMusteriListesi;
        private void btnMusteriListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frmMusteriListesi == null || _frmMusteriListesi.IsDisposed)
            {
                _frmMusteriListesi = new FrmMusteriListesi();
                _frmMusteriListesi.MdiParent = this; // Ana formun çocuğu ol

                // --- İŞTE EKSİK OLAN PARÇA ---
                // Formu açılırken maksimize et ki boşluğa tam otursun, oynamasın.
                _frmMusteriListesi.WindowState = FormWindowState.Maximized;

                _frmMusteriListesi.Show();
            }
            else
            {
                _frmMusteriListesi.Activate();
            }
        }

        private void btnYeniMusteri_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMusteriEkle frm = new FrmMusteriEkle();
            frm.ShowDialog(); // Kullanıcı işlemi bitirene kadar bekle

            // İşlem bitti, pencere kapandı. Şimdi listeyi yenile.
            if (_frmMusteriListesi != null && !_frmMusteriListesi.IsDisposed)
            {
                _frmMusteriListesi.Listele(); // Listeyi güncelle
            }
        }
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmSatis frm = new FrmSatis();
            frm.ShowDialog(); // Kullanıcı işlemi bitirene kadar bekle
            
        }


        FrmSatisGecmisi _frmSatisGecmisi;
        private void btnSatisGecmisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_frmSatisGecmisi == null || _frmSatisGecmisi.IsDisposed)
            {
                _frmSatisGecmisi = new FrmSatisGecmisi();
                _frmSatisGecmisi.MdiParent = this; // Ana formun çocuğu ol

                // --- İŞTE EKSİK OLAN PARÇA ---
                // Formu açılırken maksimize et ki boşluğa tam otursun, oynamasın.
                _frmSatisGecmisi.WindowState = FormWindowState.Maximized;

                _frmSatisGecmisi.Show();
            }
            else
            {
                _frmSatisGecmisi.Activate();
            }

        }
    }
}