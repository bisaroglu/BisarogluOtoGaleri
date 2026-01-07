using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BisarogluOtoGaleri
{
    public static class TextBoxHelper
    {
        // Windows'a gönderilecek özel mesajın kodu (EM_SETCUEBANNER)
        private const int EM_SETCUEBANNER = 0x1501;

        // Windows'un çekirdek dosyası user32.dll'den SendMessage fonksiyonunu çağırıyoruz.
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        /// <summary>
        /// Standart bir TextBox içine placeholder (silik ipucu yazısı) ekler.
        /// </summary>
        /// <param name="textBox">Hangi textbox?</param>
        /// <param name="placeholderText">Ne yazsın?</param>
        public static void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            // Windows'a "Bu textbox'a şu ipucu yazısını koy" emrini gönderiyoruz.
            // 3. parametre '0' olursa tıklayınca kaybolur, '1' olursa yazmaya başlayınca kaybolur. Genelde 0 tercih edilir.
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, placeholderText);
        }
    }
}
