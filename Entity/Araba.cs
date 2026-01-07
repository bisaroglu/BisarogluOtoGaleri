using System;

namespace BisarogluOtoGaleri.Entity
{
    public class Araba
    {
        public int ArabaID { get; set; }
        public int MarkaID { get; set; }      // Örn: 1-BMW, 2-Mercedes (AI Marka bağımlılığı sever)
        public int ModelID { get; set; }      // Örn: 320i, C180
        public int Yil { get; set; }          // Model Yılı (Fiyat için kritik)
        public int Kilometre { get; set; }    // Km arttıkça fiyat düşer
        public string YakitTuru { get; set; } // Benzin, Dizel, Hibrit
        public string VitesTipi { get; set; } // Manuel, Otomatik
        
        public bool AgirHasarKayitliMi { get; set; } // Fiyatı direkt %30-%50 etkiler
        public decimal Fiyat { get; set; }    // Gerçek fiyat (AI eğitimi için lazım olacak)
        public string Durum { get; set; }
        public string ResimYolu { get; set; }

        // İlişkisel veriler için (Ekranda göstermek adına)
        // Veritabanı mapping'inde ignore edilebilir ama UI için lazımdır.
        // Şimdilik basit tutuyoruz.
    }
}