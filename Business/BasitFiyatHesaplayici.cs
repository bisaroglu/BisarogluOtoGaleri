using BisarogluOtoGaleri.Entity;
using System;

namespace BisarogluOtoGaleri.Business
{
    // Class tanımlıyoruz, Interface DEĞİL.
    public class BasitFiyatHesaplayici : IFiyatHesaplayici
    {
        public decimal TahminiFiyatHesapla(Araba araba)
        {
            // İŞTE MANTIK KODLARI BURADA OLACAK

            decimal tabanFiyat = 500000;

            // Yıl başına (Basit mantık: Yeni araba pahalıdır)
            int yas = DateTime.Now.Year - araba.Yil;
            if (yas < 0) yas = 0; // Gelecek yıl girildiyse patlamasın

            // Yaş arttıkça fiyat düşsün
            tabanFiyat -= yas * 20000;

            // Km başına düşür
            tabanFiyat -= (araba.Kilometre / 10000) * 5000;

            // Fiyat eksiye düşerse minimum 100.000 TL olsun
            return tabanFiyat > 100000 ? tabanFiyat : 100000;
        }
    }
}