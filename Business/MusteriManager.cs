using System.Collections.Generic;
using BisarogluOtoGaleri.DataAccess;
using BisarogluOtoGaleri.Entity;

namespace BisarogluOtoGaleri.Business
{
    public class MusteriManager
    {
        MusteriDal _dal = new MusteriDal();

        public List<Musteri> TumMusterileriGetir()
        {
            return _dal.TumMusterileriGetir();
        }
    }
}
