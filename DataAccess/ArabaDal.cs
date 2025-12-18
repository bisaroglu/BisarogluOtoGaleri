using BisarogluOtoGaleri.DataAccess;
using BisarogluOtoGaleri.Entity;
using System;
using System.Data.SqlClient;

namespace BisarogluOtoGaleri.DataAccess
{
    public class ArabaDal
    {
        public List<Araba> TumArabalariGetir()
        {
            List<Araba> arabalar = new List<Araba>();

            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                    baglanti.Open();

                // Arabaları ve Marka/Model isimlerini getiren sorgu
                // Şimdilik basitçe tabloyu çekiyoruz, ileride JOIN işlemi ile marka adını alırız.
                string sorgu = "SELECT * FROM Tbl_Arabalar";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Araba araba = new Araba();
                            araba.ArabaID = Convert.ToInt32(dr["ArabaID"]);
                            araba.MarkaID = Convert.ToInt32(dr["MarkaID"]);
                            araba.ModelID = Convert.ToInt32(dr["ModelID"]);
                            araba.Yil = Convert.ToInt32(dr["Yil"]);
                            araba.Fiyat = Convert.ToDecimal(dr["Fiyat"]);
                            araba.Durum = dr["Durum"].ToString();
                            // Diğer alanları da ihtiyaca göre buraya eklersin (Km, Yakıt vs.)

                            arabalar.Add(araba);
                        }
                    }
                }
            }
            return arabalar;
        }
        public void ArabaEkle(Araba araba)
        {

            // Bağlantı yönetimi için 'using' bloğu kullanıyoruz (Memory Leak önlemi)
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "INSERT INTO Tbl_Arabalar (MarkaID, ModelID, Yil, Kilometre, Fiyat, Durum, AgirHasarKayitliMi, ResimYolu) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    if (string.IsNullOrEmpty(araba.ResimYolu))
                    {
                        komut.Parameters.AddWithValue("@p8", DBNull.Value);
                    }
                    else
                    {
                        komut.Parameters.AddWithValue("@p8", araba.ResimYolu);
                    }

                    komut.ExecuteNonQuery();
                    komut.Parameters.AddWithValue("@p1", araba.MarkaID);
                    komut.Parameters.AddWithValue("@p2", araba.ModelID);
                    komut.Parameters.AddWithValue("@p3", araba.Yil);
                    komut.Parameters.AddWithValue("@p4", araba.Kilometre);
                    komut.Parameters.AddWithValue("@p5", araba.Fiyat);
                    komut.Parameters.AddWithValue("@p6", araba.Durum);
                    komut.Parameters.AddWithValue("@p7", araba.AgirHasarKayitliMi); // Ekleme işlemi gerçekleşir
                }
            }
        }
    }
}