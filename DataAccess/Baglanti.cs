using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BisarogluOtoGaleri.DataAccess
{
    public class Baglanti
    {
        public static SqlConnection BaglantiGetir()
        {
            // Veritabanı ismin 'DbGaleriOtomasyonu' idi, onu yazdım.
            string adres = @"Data Source=.\SQLEXPRESS;Initial Catalog=DbGaleriOtomasyonu;Integrated Security=True";

            SqlConnection baglan = new SqlConnection(adres);
            try
            {
                baglan.Open();
            }
            catch (Exception hata)
            {
                throw new Exception("SQL Bağlantı Hatası: " + hata.Message);
            }
            return baglan;
        }
    }
}
