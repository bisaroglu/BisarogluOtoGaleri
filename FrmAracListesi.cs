using BisarogluOtoGaleri.Business;
using BisarogluOtoGaleri.DataAccess;
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
    public partial class FrmAracListesi : Form
    {
        ArabaManager _manager;
        public FrmAracListesi()
        {
            InitializeComponent();
            _manager = new ArabaManager();
        }
        private void FrmAracListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            var liste = _manager.TumArabalariGetir();
            gridControl1.DataSource = liste;

            // Ayarları uygula
            GridAyarlari();
        }
        void GridAyarlari()
        {
            // GridView üzerinden ayar yapıyoruz (GridControl'ün beyni GridView'dir)
            var view = gridView1; // Tasarımdaki adı gridView1 ise

            // 1. İstenmeyen Sütunları Gizle (Kullanıcı ID görmemeli)
            if (view.Columns["ArabaID"] != null) view.Columns["ArabaID"].Visible = false;

            // NOT: Şimdilik MarkaID ve ModelID'yi gizlemiyoruz çünkü JOIN yapmadık.
            // İleride buraya "MarkaAdi" gelince ID'leri gizleyeceğiz.

            // 2. Başlıkları Türkçeleştir (Kullanıcı Dostu İsimler)
            if (view.Columns["MarkaID"] != null) view.Columns["MarkaID"].Caption = "Marka Kodu";
            if (view.Columns["ModelID"] != null) view.Columns["ModelID"].Caption = "Model Kodu";
            if (view.Columns["Yil"] != null) view.Columns["Yil"].Caption = "Yıl";
            if (view.Columns["Kilometre"] != null) view.Columns["Kilometre"].Caption = "KM";
            if (view.Columns["Fiyat"] != null) view.Columns["Fiyat"].Caption = "Satış Fiyatı";
            if (view.Columns["Durum"] != null) view.Columns["Durum"].Caption = "Araç Durumu";
            if (view.Columns["AgirHasarKayitliMi"] != null) view.Columns["AgirHasarKayitliMi"].Caption = "Ağır Hasar";

            // 3. Para Birimi Formatı (₺ Simgesi ve Binlik Ayıraç)
            if (view.Columns["Fiyat"] != null)
            {
                view.Columns["Fiyat"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                view.Columns["Fiyat"].DisplayFormat.FormatString = "c2"; // Currency (Para) formatı (₺1.500.000,00 gibi yapar)
            }

            // 4. Diğer Görsel Ayarlar
            view.OptionsBehavior.Editable = false; // Kullanıcı listeden direkt değiştiremesin (Detay'dan yapsın)
            view.OptionsView.ShowGroupPanel = false; // Üstteki "Gruplamak için sürükleyin" yazısını gizle (Sade olsun)
            view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // Başlıkları ortala
            view.Appearance.Row.BackColor = System.Drawing.Color.AliceBlue; // Satırlara hafif renk ver
            view.Appearance.Row.BackColor2 = System.Drawing.Color.White; // Zebra deseni olsun mu? (Gerekirse)
        }
    }
}
