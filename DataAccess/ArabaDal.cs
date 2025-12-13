using BisarogluOtoGaleri.DataAccess.BisarogluOtoGaleri.DataAccess;
using BisarogluOtoGaleri.Entity;
using System;
using System.Data.SqlClient;

namespace BisarogluOtoGaleri.DataAccess
{
    public class ArabaDal
    {
        public void ArabaEkle(Araba araba)
        {
            // Bağlantı yönetimi için 'using' bloğu kullanıyoruz (Memory Leak önlemi)
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = @"INSERT INTO Tbl_Arabalar 
                                (MarkaID, ModelID, Yil, Kilometre, YakitTuru, VitesTipi, 
                                 DegisenParcaSayisi, BoyaliParcaSayisi, AgirHasarKayitliMi, Fiyat, Durum) 
                                VALUES 
                                (@marka, @model, @yil, @km, @yakit, @vites, 
                                 @degisen, @boyali, @agirHasar, @fiyat, @durum)";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    // Parametreleri güvenli şekilde ekliyoruz
                    komut.Parameters.AddWithValue("@marka", araba.MarkaID);
                    komut.Parameters.AddWithValue("@model", araba.ModelID);
                    komut.Parameters.AddWithValue("@yil", araba.Yil);
                    komut.Parameters.AddWithValue("@km", araba.Kilometre);
                    komut.Parameters.AddWithValue("@yakit", araba.YakitTuru);
                    komut.Parameters.AddWithValue("@vites", araba.VitesTipi);
                    komut.Parameters.AddWithValue("@degisen", araba.DegisenParcaSayisi);
                    komut.Parameters.AddWithValue("@boyali", araba.BoyaliParcaSayisi);
                    komut.Parameters.AddWithValue("@agirHasar", araba.AgirHasarKayitliMi);
                    komut.Parameters.AddWithValue("@fiyat", araba.Fiyat);
                    komut.Parameters.AddWithValue("@durum", "Satılık"); // Varsayılan olarak Satılık ekliyoruz

                    komut.ExecuteNonQuery(); // Ekleme işlemi gerçekleşir
                }
            }
        }
    }
}