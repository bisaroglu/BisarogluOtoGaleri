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
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();

                // Sıralamayı isme göre yapalım
                string sorgu = "SELECT * FROM Tbl_Musteriler ORDER BY Ad ASC";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            liste.Add(new Musteri
                            {
                                MusteriID = Convert.ToInt32(dr["MusteriID"]),
                                Ad = dr["Ad"].ToString(),
                                Soyad = dr["Soyad"].ToString(),

                                // KRİTİK NOKTA: Veritabanındaki sütun adını buraya yazdık
                                TCKimlik = dr["TCKimlik"].ToString(),

                                Telefon = dr["Telefon"].ToString(),
                                Mail = dr["Mail"].ToString(),
                                Adres = dr["Adres"].ToString()
                            });
                        }
                    }
                }
            }
            return liste;
        }
        public void MusteriEkle(Musteri m)
        {
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();

                // Insert sorgusunda sütun adlarını senin tablona göre yazdım
                string sorgu = "INSERT INTO Tbl_Musteriler (Ad, Soyad, TCKimlik, Telefon, Mail, Adres) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", m.Ad);
                    komut.Parameters.AddWithValue("@p2", m.Soyad);

                    // Entity'deki TCKimlik özelliğini gönderiyoruz
                    komut.Parameters.AddWithValue("@p3", m.TCKimlik);

                    komut.Parameters.AddWithValue("@p4", m.Telefon);
                    komut.Parameters.AddWithValue("@p5", m.Mail);
                    komut.Parameters.AddWithValue("@p6", m.Adres);

                    komut.ExecuteNonQuery();
                }
            }
        }
    }
}
