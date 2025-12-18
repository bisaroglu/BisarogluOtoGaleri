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
        // Sadece connection string'i döndüren bir özellik veya metot
        // Bağlantıyı burada AÇMIYORUZ.
        public static string Adres = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DbGaleriOtomasyonu;Integrated Security=True";
    }   
}

