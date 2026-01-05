using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BisarogluOtoGaleri.Entity
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // DEĞİŞİKLİK BURADA: Veritabanındaki ismin aynısını kullandık
        public string TCKimlik { get; set; }

        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }

        // Yardımcı özellik (Listede Ad Soyad yanyana görünsün diye)
        public string AdSoyad { get { return Ad + " " + Soyad; } }
    }
}