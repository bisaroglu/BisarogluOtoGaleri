using BisarogluOtoGaleri.DataAccess;
using BisarogluOtoGaleri.Entity;
using BisarogluOtoGaleri.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisarogluOtoGaleri
{
    public partial class FrmSatis : Form
    {
        SatisManager _manager = new SatisManager();
        public FrmSatis()
        {
            InitializeComponent();
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            AraclariGetir();
            MusterileriGetir();

            // Tarih kutusuna bugünü atayalım
            dateTarih.DateTime = DateTime.Now;
        }
        void AraclariGetir()
        {
            try
            {
                // JOIN İŞLEMİ:
                // Arabalar tablosunu (A), Markalar (M) ve Modeller (MO) ile birleştiriyoruz.
                // Böylece ID'lerin karşılığındaki gerçek isimleri (BMW, 5.20) alabiliyoruz.

                string sorgu = @"
            SELECT 
                A.ArabaID, 
                A.Yil, 
                A.YakitTuru, 
                A.VitesTipi, 
                A.Fiyat, 
                
                -- KULLANICININ GÖRECEĞİ METİN (Örn: BMW 5.20 - 2023 Model)
                (M.MarkaAdi + ' ' + MO.ModelAdi + ' - ' + CAST(A.Yil AS NVARCHAR) + ' Model') AS Gorunum

            FROM Tbl_Arabalar A
            INNER JOIN Tbl_Markalar M ON A.MarkaID = M.MarkaID
            INNER JOIN Tbl_Modeller MO ON A.ModelID = MO.ModelID
            
            WHERE A.Durum = 'Satılık'";
                // Veya 'Galeride'. Veritabanında hangisini kullanıyorsan onu yaz.

                using (SqlDataAdapter da = new SqlDataAdapter(sorgu, Baglanti.Adres))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    lueArac.Properties.ValueMember = "ArabaID"; // Arka planda ID tutmaya devam!
                    lueArac.Properties.DisplayMember = "Gorunum"; // Listede Marka+Model yazacak
                    lueArac.Properties.DataSource = dt;

                    // Sütunları Gizleme Ayarları (Temiz Görüntü İçin)
                    lueArac.Properties.PopulateColumns();
                    lueArac.Properties.Columns["ArabaID"].Visible = false;
                    lueArac.Properties.Columns["Yil"].Visible = false;
                    lueArac.Properties.Columns["YakitTuru"].Visible = false;
                    lueArac.Properties.Columns["VitesTipi"].Visible = false;
                    lueArac.Properties.Columns["Fiyat"].Visible = false;

                    // Başlık ayarı
                    lueArac.Properties.Columns["Gorunum"].Caption = "Araç";

                    lueArac.EditValue = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araçlar yüklenirken hata: " + ex.Message + "\n\nİPUCU: Marka/Model tablo isimlerin farklı olabilir, kontrol et.");
            }
        }
        // --- 2. MÜŞTERİLERİ GETİR ---
        void MusterileriGetir()
        {
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT MusteriID, (Ad + ' ' + Soyad) AS AdSoyad FROM Tbl_Musteriler", Baglanti.Adres))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                lueMusteri.Properties.ValueMember = "MusteriID";
                lueMusteri.Properties.DisplayMember = "AdSoyad";
                lueMusteri.Properties.DataSource = dt;
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            // 1. VALIDASYON (Seçim yapıldı mı?)
            if (lueArac.EditValue == null || lueMusteri.EditValue == null)
            {
                MessageBox.Show("Lütfen araç ve müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. NESNE OLUŞTURMA
            Satis satis = new Satis();
            satis.ArabaID = Convert.ToInt32(lueArac.EditValue); // Seçilen aracın ID'sini al
            satis.MusteriID = Convert.ToInt32(lueMusteri.EditValue);
            satis.GercekSatisFiyati = Convert.ToDecimal(txtFiyat.Text);
            satis.SatisTarihi = dateTarih.DateTime;

            // 3. KAYDETME
            try
            {
                // Burada SatisDal'ı doğrudan çağırabiliriz veya Manager üzerinden gidebiliriz.
                SatisDal dal = new SatisDal();
                dal.SatisiOnayla(satis);

                MessageBox.Show("Satış başarıyla gerçekleştirildi! Araç durumu güncellendi.", "Hayırlı Olsun", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void lueArac_EditValueChanged(object sender, EventArgs e)
        {
            // 1. Seçilen satırı 'DataRowView' olarak yakalıyoruz
            var secilenSatir = lueArac.GetSelectedDataRow() as System.Data.DataRowView;

            // 2. Eğer seçim boş değilse kutuları doldur
            if (secilenSatir != null)
            {
                // 'Yil' sütununu txtYil kutusuna yaz
                txtYil.Text = secilenSatir["Yil"].ToString();

                // 'YakitTuru' sütununu txtYakit kutusuna yaz
                txtYakit.Text = secilenSatir["YakitTuru"].ToString();

                // 'VitesTipi' sütununu txtVites kutusuna yaz
                txtVites.Text = secilenSatir["VitesTipi"].ToString();

                // 'Fiyat' sütununu txtFiyat kutusuna yaz (Boşsa 0 yaz)
                if (secilenSatir["Fiyat"] != DBNull.Value)
                {
                    txtFiyat.Text = secilenSatir["Fiyat"].ToString();
                }
                else
                {
                    txtFiyat.Text = "0";
                }
            }
            else
            {
                // Eğer seçim temizlendiyse kutuları da temizle
                txtYil.Text = "";
                txtYakit.Text = "";
                txtVites.Text = "";
                txtFiyat.Text = "";
            }
        }
    }
}
