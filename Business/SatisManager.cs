using BisarogluOtoGaleri.DataAccess;
using BisarogluOtoGaleri.Entity; // Entity katmanını görsün
using System;
using System.Collections.Generic;

namespace BisarogluOtoGaleri // Senin ana namespace ismin neyse o olmalı
{
    public class SatisManager
    {
        // DAL sınıfını çağırıyoruz
        SatisDal _dal = new SatisDal();
        public List<Satis> SatislariGetir()
        {
            // Veritabanından veriyi isteyip Form'a gönderecek
            return _dal.SatislariGetir();
        }

        // Satış Onaylama Metodu
        public void SatisiOnayla(Satis satis)
        {
            // Buraya ileride iş kuralları ekleyebiliriz.
            // Örn: "Satış tarihi bugünden ileri olamaz" gibi.
            // Şimdilik direkt DAL'a iletiyoruz.

            _dal.SatisiOnayla(satis);
        }
    }
}
