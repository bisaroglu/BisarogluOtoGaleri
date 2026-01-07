using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisarogluOtoGaleri
{
    public static class BisarogluMsg
    {
        // 1. Basit Kullanım: Sadece Mesaj
        public static void Goster(string mesaj)
        {
            Goster(mesaj, "BİLGİ");
        }

        // 2. Gelişmiş Kullanım: Mesaj + Başlık
        public static void Goster(string mesaj, string baslik)
        {
            // Formu oluştur
            using (FrmMesaj frm = new FrmMesaj())
            {
                // Verileri aktar (Label'ların public veya internal olması gerekebilir, 
                // ya da Controls["lblMesaj"] ile erişebilirsin. 
                // En temiz yol: FrmMesaj içine public metod yazmaktır ama 
                // hızlı çözüm için Controls kullanıyoruz:

                frm.Controls["lblMesaj"].Text = mesaj;
                frm.Controls["lblBaslik"].Text = baslik.ToUpper();

                // Sesi çal (Windows uyarı sesi)
                System.Media.SystemSounds.Exclamation.Play();

                // Dialog olarak göster (Arka plan kilitlenir)
                frm.ShowDialog();
            }
        }
    }
}
