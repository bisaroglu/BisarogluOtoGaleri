using System.IO;
using BisarogluOtoGaleri.DataAccess;
using BisarogluOtoGaleri.Entity;
using System;

namespace BisarogluOtoGaleri.Business
{
    public class ArabaManager
    {
        ArabaDal _arabaDal = new ArabaDal();
        public List<Araba> TumArabalariGetir()
        {
            // Burada ileride "Sadece Satılık olanları getir" gibi iş kuralları yazabiliriz.
            return _arabaDal.TumArabalariGetir();
        }
        public string ResimDosyasiniYonet(string kaynakDosyaYolu)
        {
            // Eğer kullanıcı resim seçmediyse boş dön.
            if (string.IsNullOrEmpty(kaynakDosyaYolu)) return "";

            // 1. Hedef Klasörü Belirle (Projenin çalıştığı yer / AracResimleri)
            // Application.StartupPath, bin/Debug klasörüdür.
            string hedefKlasor = Path.Combine(System.Windows.Forms.Application.StartupPath, "AracResimleri");

            // 2. Klasör yoksa oluştur
            if (!Directory.Exists(hedefKlasor))
            {
                Directory.CreateDirectory(hedefKlasor);
            }

            // 3. Benzersiz bir dosya adı üret (Çakışmayı önlemek için GUID kullanıyoruz)
            // Örn: "bmw.jpg" -> "550e8400-e29b-41d4-a716-446655440000.jpg" olur.
            string dosyaUzantisi = Path.GetExtension(kaynakDosyaYolu);
            string yeniDosyaAdi = Guid.NewGuid().ToString() + dosyaUzantisi;
            string hedefTamYol = Path.Combine(hedefKlasor, yeniDosyaAdi);

            // 4. Dosyayı kopyala
            File.Copy(kaynakDosyaYolu, hedefTamYol, true); // true = üzerine yaz (gerekirse)

            // Veritabanına sadece dosya adını kaydedeceğiz (Klasör yolu dinamik olabilir)
            return yeniDosyaAdi;
        }
        public int ArabaEkle(Araba araba)
        {
            // 1. Validasyon (Doğrulama) Kuralları
            if (araba.Fiyat <= 0)
            {
                throw new Exception("Araba fiyatı 0 veya negatif olamaz!");
            }

            if (araba.Yil > DateTime.Now.Year + 1 || araba.Yil < 1900)
            {
                throw new Exception("Geçersiz model yılı girdiniz.");
            }

            // 2. İş Kuralı: AI Entegrasyonu için Hazırlık
            // Eğer kullanıcı fiyat girmediyse (0 geldiyse), ileride burada AI metodunu çağırıp
            // "Tahmini fiyatı ben atadım" diyebiliriz. Şimdilik manuel girişe izin veriyoruz.

            // 3. Veritabanına Kayıt
            _arabaDal.ArabaEkle(araba);
            return _arabaDal.ArabaEkle(araba);
        }
        public void ResimEkle(AracResim resim)
        {
            // DAL katmanındaki metodu çağırıyoruz
            _arabaDal.ResimEkle(resim);
        }

    }
}