using System;
using System.IO;
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
            gridView1_FocusedRowChanged(null, null);
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

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // 1. Seçili Araba ID'yi al
            var idDegeri = gridView1.GetRowCellValue(e.FocusedRowHandle, "ArabaID");

            // ID yoksa veya null ise metoddan çık (Hata önleyici)
            if (idDegeri == null) return;

            int arabaID = Convert.ToInt32(idDegeri);

            // 2. Veritabanından resimleri getir
            // Not: Manager'da bu metodun olduğundan eminiz (önceki adımlarda yaptık)
            List<string> resimListesi = _manager.ResimleriGetir(arabaID);

            // 3. YENİ DİZİ: Sadece 4 küçük kutuyu tanımlıyoruz
            DevExpress.XtraEditors.PictureEdit[] kutular = { peK1, peK2, peK3, peK4 };

            // 4. Döngü Limiti: 4 (Kutu sayısı kadar)
            for (int i = 0; i < 4; i++)
            {
                if (i < resimListesi.Count)
                {
                    // Resim varsa kutuya yükle
                    ResmiKutuyaYukle(kutular[i], resimListesi[i]);
                }
                else
                {
                    // Resim yoksa kutuyu temizle (Boş/Gri kalsın)
                    ResmiKutuyaYukle(kutular[i], null);
                }
            }
        }
        void ResmiKutuyaYukle(DevExpress.XtraEditors.PictureEdit kutu, string dosyaAdi)
        {
            if (kutu == null) return; // Güvenlik önlemi

            if (string.IsNullOrEmpty(dosyaAdi))
            {
                kutu.Image = null;
                return;
            }

            string tamYol = Path.Combine(Application.StartupPath, "AracResimleri", dosyaAdi);

            if (File.Exists(tamYol))
            {
                using (var stream = new FileStream(tamYol, FileMode.Open, FileAccess.Read))
                {
                    kutu.Image = Image.FromStream(stream);
                }
            }
            else
            {
                kutu.Image = null;
            }
        }
    }
}