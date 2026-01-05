using System.Collections.Generic;
using BisarogluOtoGaleri.DataAccess;
using BisarogluOtoGaleri.Entity;

namespace BisarogluOtoGaleri.Business
{
    public class MusteriManager
    {
        MusteriDal _dal = new MusteriDal();

        public List<Musteri> MusterileriGetir()
        {
            return _dal.TumMusterileriGetir();
        }

        public void MusteriEkle(Musteri m)
        {
            // İleride buraya: "TC 11 haneli mi?" kontrolü ekleyeceğiz.
            _dal.MusteriEkle(m);
        }
    }
}
