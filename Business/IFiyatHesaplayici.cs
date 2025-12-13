using BisarogluOtoGaleri.Entity;

namespace BisarogluOtoGaleri.Business
{
    public interface IFiyatHesaplayici
    {
        // Dikkat: Kod bloğu yok, sadece noktalı virgül var.
        decimal TahminiFiyatHesapla(Araba araba);
    }
}
