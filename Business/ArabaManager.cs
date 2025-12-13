using BisarogluOtoGaleri.DataAccess;
using BisarogluOtoGaleri.Entity;
using System;

namespace BisarogluOtoGaleri.Business
{
    public class ArabaManager
    {
        ArabaDal _arabaDal = new ArabaDal();

        public void ArabaEkle(Araba araba)
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
        }
    }
}