using DevExpress.XtraBars;

namespace BisarogluOtoGaleri
{
    partial class FrmAnaSayfa
    {
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.ComponentModel.IContainer components = null;

        

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnAracListesi = new BarButtonItem();
            btnYeniArac = new BarButtonItem();
            btnMusteriListesi = new BarButtonItem();
            btnYeniMusteri = new BarButtonItem();
            barButtonItem5 = new BarButtonItem();
            btnSatisGecmisi = new BarButtonItem();
            btnGenelRapor = new BarButtonItem();
            barButtonItem1 = new BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            Müş = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            btnSatisYap = new DevExpress.XtraBars.Ribbon.RibbonPage();
            Satış = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageRaporlar = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ApplicationButtonImageOptions.Image = (Image)resources.GetObject("ribbon.ApplicationButtonImageOptions.Image");
            ribbon.BackColor = Color.FromArgb(0, 64, 0);
            ribbon.EmptyAreaImageOptions.Image = (Image)resources.GetObject("ribbon.EmptyAreaImageOptions.Image");
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new BarItem[] { ribbon.ExpandCollapseItem, btnAracListesi, btnYeniArac, btnMusteriListesi, btnYeniMusteri, barButtonItem5, btnSatisGecmisi, btnGenelRapor, barButtonItem1 });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 9;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2, btnSatisYap, ribbonPageRaporlar });
            ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            ribbon.Size = new Size(805, 158);
            ribbon.StatusBar = ribbonStatusBar;
            ribbon.Click += ribbon_Click;
            // 
            // btnAracListesi
            // 
            btnAracListesi.Caption = "Araç Listesi";
            btnAracListesi.Id = 1;
            btnAracListesi.ImageOptions.Image = (Image)resources.GetObject("btnAracListesi.ImageOptions.Image");
            btnAracListesi.ImageOptions.LargeImage = (Image)resources.GetObject("btnAracListesi.ImageOptions.LargeImage");
            btnAracListesi.Name = "btnAracListesi";
            btnAracListesi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnAracListesi.ItemClick += btnAracListesi_ItemClick;
            // 
            // btnYeniArac
            // 
            btnYeniArac.Caption = "Yeni Araç Girişi";
            btnYeniArac.Id = 2;
            btnYeniArac.ImageOptions.Image = (Image)resources.GetObject("btnYeniArac.ImageOptions.Image");
            btnYeniArac.ImageOptions.LargeImage = (Image)resources.GetObject("btnYeniArac.ImageOptions.LargeImage");
            btnYeniArac.Name = "btnYeniArac";
            btnYeniArac.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnYeniArac.ItemClick += btnYeniArac_ItemClick;
            // 
            // btnMusteriListesi
            // 
            btnMusteriListesi.Caption = "Müşteri Listesi";
            btnMusteriListesi.Id = 3;
            btnMusteriListesi.ImageOptions.Image = (Image)resources.GetObject("btnMusteriListesi.ImageOptions.Image");
            btnMusteriListesi.ImageOptions.LargeImage = (Image)resources.GetObject("btnMusteriListesi.ImageOptions.LargeImage");
            btnMusteriListesi.Name = "btnMusteriListesi";
            btnMusteriListesi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnMusteriListesi.ItemClick += btnMusteriListesi_ItemClick;
            // 
            // btnYeniMusteri
            // 
            btnYeniMusteri.Caption = "Müşteri Ekle";
            btnYeniMusteri.Id = 4;
            btnYeniMusteri.ImageOptions.Image = (Image)resources.GetObject("btnYeniMusteri.ImageOptions.Image");
            btnYeniMusteri.ImageOptions.LargeImage = (Image)resources.GetObject("btnYeniMusteri.ImageOptions.LargeImage");
            btnYeniMusteri.Name = "btnYeniMusteri";
            btnYeniMusteri.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnYeniMusteri.ItemClick += btnYeniMusteri_ItemClick;
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "Satış Başlat";
            barButtonItem5.Id = 5;
            barButtonItem5.ImageOptions.Image = (Image)resources.GetObject("barButtonItem5.ImageOptions.Image");
            barButtonItem5.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem5.ImageOptions.LargeImage");
            barButtonItem5.Name = "barButtonItem5";
            barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            barButtonItem5.ItemClick += barButtonItem5_ItemClick;
            // 
            // btnSatisGecmisi
            // 
            btnSatisGecmisi.Caption = "Satış Geçmişi";
            btnSatisGecmisi.Id = 6;
            btnSatisGecmisi.ImageOptions.Image = (Image)resources.GetObject("btnSatisGecmisi.ImageOptions.Image");
            btnSatisGecmisi.ImageOptions.LargeImage = (Image)resources.GetObject("btnSatisGecmisi.ImageOptions.LargeImage");
            btnSatisGecmisi.Name = "btnSatisGecmisi";
            btnSatisGecmisi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnSatisGecmisi.ItemClick += btnSatisGecmisi_ItemClick;
            // 
            // btnGenelRapor
            // 
            btnGenelRapor.Caption = "Özet Rapor";
            btnGenelRapor.Id = 7;
            btnGenelRapor.ImageOptions.Image = (Image)resources.GetObject("btnGenelRapor.ImageOptions.Image");
            btnGenelRapor.ImageOptions.LargeImage = (Image)resources.GetObject("btnGenelRapor.ImageOptions.LargeImage");
            btnGenelRapor.Name = "btnGenelRapor";
            btnGenelRapor.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "barButtonItem1";
            barButtonItem1.Id = 8;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Araç Yönetimi";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnAracListesi);
            ribbonPageGroup1.ItemLinks.Add(btnYeniArac);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Araç İşlemleri";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { Müş });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "Müşteri Yönetimi";
            // 
            // Müş
            // 
            Müş.ItemLinks.Add(btnMusteriListesi);
            Müş.ItemLinks.Add(btnYeniMusteri);
            Müş.Name = "Müş";
            Müş.Text = "Müşteri İşlemleri";
            // 
            // btnSatisYap
            // 
            btnSatisYap.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { Satış });
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Text = "Satış Yönetimi";
            // 
            // Satış
            // 
            Satış.ItemLinks.Add(barButtonItem5);
            Satış.ItemLinks.Add(btnSatisGecmisi);
            Satış.Name = "Satış";
            Satış.Text = "Satış İşlemleri";
            // 
            // ribbonPageRaporlar
            // 
            ribbonPageRaporlar.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup4 });
            ribbonPageRaporlar.Name = "ribbonPageRaporlar";
            ribbonPageRaporlar.Text = "İstatistik ve Raporlar";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(btnGenelRapor);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            ribbonPageGroup4.Text = "Genel Durum";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 555);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(805, 24);
            // 
            // FrmAnaSayfa
            // 
            AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            Appearance.BackColor = Color.FromArgb(0, 64, 0);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 579);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            IsMdiContainer = true;
            Name = "FrmAnaSayfa";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "RibbonForm1";
            Load += FrmAnaSayfa_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        

        private void BtnYeniArac_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion


        private DevExpress.XtraBars.BarButtonItem btnAracListesi;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Müş;
        private DevExpress.XtraBars.BarButtonItem btnYeniArac;
        private DevExpress.XtraBars.BarButtonItem btnMusteriListesi;
        private DevExpress.XtraBars.BarButtonItem btnYeniMusteri;
        private DevExpress.XtraBars.Ribbon.RibbonPage btnSatisYap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Satış;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageRaporlar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnSatisGecmisi;
        private DevExpress.XtraBars.BarButtonItem btnGenelRapor;
        private BarButtonItem barButtonItem1;
    }
}