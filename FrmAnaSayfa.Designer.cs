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
            components = new System.ComponentModel.Container();
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
            barButtonItem2 = new BarButtonItem();
            I = new BarButtonItem();
            barButtonItem3 = new BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            Müş = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            btnSatisYap = new DevExpress.XtraBars.Ribbon.RibbonPage();
            Satış = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(components);
            tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(components);
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView1).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.BackColor = Color.FromArgb(0, 64, 0);
            ribbon.CaptionBarMinWidth = 500;
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new BarItem[] { ribbon.ExpandCollapseItem, btnAracListesi, btnYeniArac, btnMusteriListesi, btnYeniMusteri, barButtonItem5, btnSatisGecmisi, btnGenelRapor, barButtonItem1, barButtonItem2, I, barButtonItem3 });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 12;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2, btnSatisYap });
            ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            ribbon.Size = new Size(1266, 158);
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
            btnYeniArac.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
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
            // barButtonItem2
            // 
            barButtonItem2.Id = 9;
            barButtonItem2.Name = "barButtonItem2";
            // 
            // I
            // 
            I.Id = 10;
            I.Name = "I";
            // 
            // barButtonItem3
            // 
            barButtonItem3.Id = 11;
            barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Appearance.ForeColor = Color.Gold;
            ribbonPage1.Appearance.Options.UseForeColor = true;
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.ImageOptions.Alignment = DevExpress.Utils.HorzAlignment.Far;
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "    Araç Yönetimi     ";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnAracListesi);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup1.ItemLinks.Add(btnYeniArac);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Araç İşlemleri";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Appearance.ForeColor = Color.Gold;
            ribbonPage2.Appearance.Options.UseForeColor = true;
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { Müş });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "    Müşteri Yönetimi    ";
            // 
            // Müş
            // 
            Müş.ItemLinks.Add(btnMusteriListesi);
            Müş.ItemLinks.Add(I);
            Müş.ItemLinks.Add(btnYeniMusteri);
            Müş.Name = "Müş";
            Müş.Text = "Müşteri İşlemleri";
            // 
            // btnSatisYap
            // 
            btnSatisYap.Appearance.ForeColor = Color.Gold;
            btnSatisYap.Appearance.Options.UseForeColor = true;
            btnSatisYap.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { Satış });
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Text = "    Satış Yönetimi    ";
            // 
            // Satış
            // 
            Satış.ItemLinks.Add(barButtonItem5);
            Satış.ItemLinks.Add(barButtonItem3);
            Satış.ItemLinks.Add(btnSatisGecmisi);
            Satış.Name = "Satış";
            Satış.Text = "Satış İşlemleri";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 743);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1266, 24);
            // 
            // documentManager1
            // 
            documentManager1.MdiParent = this;
            documentManager1.MenuManager = ribbon;
            documentManager1.View = tabbedView1;
            documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] { tabbedView1 });
            // 
            // FrmAnaSayfa
            // 
            ActiveGlowColor = Color.Yellow;
            AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            Appearance.BackColor = Color.FromArgb(0, 64, 0);
            Appearance.ForeColor = Color.Gold;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseForeColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayoutStore = ImageLayout.Stretch;
            BackgroundImageStore = Properties.Resources.arkaplanzümrüt;
            ClientSize = new Size(1266, 767);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.Icon = (Icon)resources.GetObject("FrmAnaSayfa.IconOptions.Icon");
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "FrmAnaSayfa";
            Ribbon = ribbon;
            StartPosition = FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "BIŞAROĞLU OTO GALERİ";
            Load += FrmAnaSayfa_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView1).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnSatisGecmisi;
        private DevExpress.XtraBars.BarButtonItem btnGenelRapor;
        private BarButtonItem barButtonItem1;
        private BarButtonItem barButtonItem2;
        private BarButtonItem I;
        private BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
    }
}