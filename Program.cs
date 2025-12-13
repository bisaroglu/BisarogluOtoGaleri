using BisarogluOtoGaleri.Business;
using BisarogluOtoGaleri.Entity;

namespace BisarogluOtoGaleri
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Console.WriteLine("--- OTO GALERİ BACKEND TEST SİMÜLASYONU ---\n");

            try
            {
                // 1. ADIM: Yöneticileri ve Araçları Örnekle (Instantiate)
                ArabaManager manager = new ArabaManager();

                // İleride buraya 'YapayZekaFiyatHesaplayici' gelecek.
                // Şimdilik interface üzerinden basit hesaplayıcıyı çağırıyoruz.
                IFiyatHesaplayici fiyatHesaplayici = new BasitFiyatHesaplayici();

                // 2. ADIM: Yeni Bir Araba Oluştur (Entity)
                Araba yeniAraba = new Araba()
                {
                    MarkaID = 1,          // Örn: BMW
                    ModelID = 101,        // Örn: 3.20i
                    Yil = 2020,
                    Kilometre = 45000,
                    YakitTuru = "Benzin",
                    VitesTipi = "Otomatik",
                    DegisenParcaSayisi = 0,
                    BoyaliParcaSayisi = 1, // Sağ çamurluk boyalı diyelim
                    AgirHasarKayitliMi = false,
                    // Fiyatı henüz bilmiyoruz, hesaplatacağız.
                    Fiyat = 0
                };

                Console.WriteLine($"Araba Bilgileri Girildi: {yeniAraba.Yil} Model, {yeniAraba.Kilometre} KM");

                // 3. ADIM: Fiyat Hesaplama (AI / Algoritma Testi)
                Console.WriteLine("Fiyat hesaplanıyor...");

                decimal hesaplananFiyat = fiyatHesaplayici.TahminiFiyatHesapla(yeniAraba);
                yeniAraba.Fiyat = hesaplananFiyat;

                Console.WriteLine($"Sistem Tarafından Belirlenen Fiyat: {yeniAraba.Fiyat:C2}");

                // 4. ADIM: Veritabanına Kayıt (Manager Testi)
                Console.WriteLine("Veritabanına kaydediliyor...");

                manager.ArabaEkle(yeniAraba);

                Console.WriteLine("\n[BAŞARILI] Araba başarıyla veritabanına eklendi.");
            }
            catch (Exception ex)
            {
                // Manager katmanında yazdığımız validasyon hataları (yıl, fiyat vb.) buraya düşer.
                Console.WriteLine($"\n[HATA] Bir sorun oluştu: {ex.Message}");
            }

            Console.WriteLine("\nÇıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
    
}