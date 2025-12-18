using BisarogluOtoGaleri.DataAccess;
using BisarogluOtoGaleri.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BisarogluOtoGaleri.DataAccess
{
    public class MusteriDal
    {
        public List<Musteri> TumMusterileriGetir()
        {
            List<Musteri> liste = new List<Musteri>();

            // 'using' bloğu, süslü parantez bittiği an bağlantıyı otomatik kapatır ve belleği temizler (Dispose).
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                using (SqlCommand komut = new SqlCommand("Select * From Tbl_Musteriler", baglanti))
                {
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Musteri m = new Musteri();
                            // DBNull kontrolü yapmak profesyonelliktir (Boş veri gelirse patlamasın diye)
                            m.MusteriID = Convert.ToInt32(dr["MusteriID"]);
                            m.Ad = dr["Ad"] != DBNull.Value ? dr["Ad"].ToString() : "";
                            m.Soyad = dr["Soyad"] != DBNull.Value ? dr["Soyad"].ToString() : "";
                            m.TCKimlik = dr["TCKimlik"] != DBNull.Value ? dr["TCKimlik"].ToString() : "";
                            m.Telefon = dr["Telefon"] != DBNull.Value ? dr["Telefon"].ToString() : "";
                            m.Mail = dr["Mail"] != DBNull.Value ? dr["Mail"].ToString() : "";
                            m.Adres = dr["Adres"] != DBNull.Value ? dr["Adres"].ToString() : "";

                            liste.Add(m);
                        }
                    } // Reader burada kapanır
                } // Command burada yok edilir
            } // Bağlantı burada OTOMATİK kapanır.

            return liste;
        }
    }
}
