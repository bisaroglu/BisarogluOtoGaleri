using System;
using System.Windows.Forms;
using BisarogluOtoGaleri.Business; // Manager için gerekli
using BisarogluOtoGaleri.DataAccess; // Dal için (Gerekirse)

namespace BisarogluOtoGaleri
{
    public partial class FrmAracListesi : Form
    {
        ArabaManager _manager;

        public FrmAracListesi()
        {
            InitializeComponent();
            // Manager'ı doğru parametrelerle başlattığından emin ol
            // Eğer Manager boş kurucu (constructor) kabul ediyorsa böyle kalsın.
            // Ama genelde: _manager = new ArabaManager(new ArabaDal()); şeklindedir.
            _manager = new ArabaManager(new ArabaDal());
        }

        private void FrmAracListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            var liste = _manager.TumArabalariGetir();
            gridControl1.DataSource = liste;

            // Ayarları uygula (ve sütunları yenile)
            gridView1.PopulateColumns();
            GridAyarlari();
        }

        
        void GridAyarlari()
        {
            var view = gridView1;

            // ... (Eski ayarların: ID gizleme, Başlıklar vs. BURADA KALSIN) ...

            // --- YENİ EKLENEN KISIM: GÜNCELLEME BUTONU ---

            // 1. Eğer "Guncelle" sütunu yoksa sanal olarak ekle
            if (view.Columns["Guncelle"] == null)
            {
                DevExpress.XtraGrid.Columns.GridColumn colGuncelle = view.Columns.AddField("Guncelle");
                colGuncelle.VisibleIndex = 0; // En başa al
                colGuncelle.Caption = "İşlemler";
                colGuncelle.UnboundType = DevExpress.Data.UnboundColumnType.String; // Veritabanında yok, biz uydurduk
                colGuncelle.Visible = true;
            }

            // 2. Hücreye "DÜZENLE" yazısı ve Rengi
            view.CustomColumnDisplayText -= GridView1_CustomColumnDisplayText; // Önce çıkar
            view.CustomColumnDisplayText += GridView1_CustomColumnDisplayText; // Sonra ekle

            // 3. Tıklama Olayı (Zaten vardı, güncelleyeceğiz)
            view.RowCellClick -= GridView1_RowCellClick;
            view.RowCellClick += GridView1_RowCellClick;
        }
        private void GridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            // Resim sütunu ayarı zaten vardı...
            if (e.Column.FieldName == "ResimYolu")
            {
                // ... (Eski kodun kalsın) ...
            }

            // YENİ: Güncelle sütununa yazı yaz
            if (e.Column.FieldName == "Guncelle")
            {
                e.DisplayText = "DÜZENLE 📝";
            }
        }
        private void GridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            // Ortak ID Alma İşlemi (Her iki durumda da lazım)
            var idDegeri = gridView1.GetRowCellValue(e.RowHandle, "ArabaID");
            if (idDegeri == null) return;
            int id = Convert.ToInt32(idDegeri);

            // SENARYO A: Resim sütununa tıklandı -> Sadece Detay/Resim aç
            if (e.Column.FieldName == "ResimYolu")
            {
                FrmAracDetay frm = new FrmAracDetay(id);
                frm.ShowDialog();
                Listele();
            }

            // SENARYO B: "Guncelle" sütununa tıklandı -> Yine Detay aç (Aynı kapıya çıkıyor)
            // Ama kullanıcıya "Butona bastım" hissi verir.
            if (e.Column.FieldName == "Guncelle")
            {
                FrmAracDetay frm = new FrmAracDetay(id);
                frm.ShowDialog();
                Listele(); // Form kapanınca gridi yenile (Fiyat değişmiş olabilir)
            }
        }
    }
}