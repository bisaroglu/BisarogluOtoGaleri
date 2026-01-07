using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BisarogluOtoGaleri.Entity;

namespace BisarogluOtoGaleri.DataAccess
{
    public class SatisDal
    {
        public void SatisiOnayla(Satis satis)
        {
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();

                // 1. Satışı kaydet
                string sorguSatis = "INSERT INTO Tbl_Satislar (ArabaID, MusteriID, GercekSatisFiyati, SatisTarihi) VALUES (@p1, @p2, @p3, @p4)";
                using (SqlCommand komut = new SqlCommand(sorguSatis, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", satis.ArabaID);
                    komut.Parameters.AddWithValue("@p2", satis.MusteriID);
                    komut.Parameters.AddWithValue("@p3", satis.GercekSatisFiyati);
                    komut.Parameters.AddWithValue("@p4", satis.SatisTarihi);
                    komut.ExecuteNonQuery();
                }

                // 2. Arabanın durumunu 'Satıldı' yap
                // DİKKAT: Önceki kodunda WHERE şartı yoktu, tüm arabaları satıldı yapıyordu! Bunu düzelttim.
                string sorguDurum = "UPDATE Tbl_Arabalar SET Durum='Satıldı' WHERE ArabaID=@id";
                using (SqlCommand komut2 = new SqlCommand(sorguDurum, baglanti))
                {
                    komut2.Parameters.AddWithValue("@id", satis.ArabaID);
                    komut2.ExecuteNonQuery();
                }
            }
        }

        // ===================================================================
        // KRİTİK DÜZELTME BURADA: SatislariGetir METODU
        // ===================================================================
        public List<Satis> SatislariGetir()
        {
            List<Satis> listem = new List<Satis>();

            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();

                // YENİ SQL SORGUSU:
                // Artık 4 tabloyu birleştiriyoruz (Satışlar, Arabalar, Markalar, Modeller, Müşteriler)
                // Böylece Marka ve Model adlarını alabiliyoruz. Plaka kaldırıldı.
                string sorgu = @"
                    SELECT 
                        S.SatisID, 
                        S.ArabaID, 
                        S.MusteriID, 
                        S.GercekSatisFiyati, 
                        S.SatisTarihi,
                        -- Marka Adı ve Model Adını ilgili tablolardan çekip birleştiriyoruz:
                        Mrk.MarkaAdi + ' ' + Mdl.ModelAdi AS AracBilgi,
                        M.Ad + ' ' + M.Soyad AS MusteriAdSoyad
                    FROM Tbl_Satislar S
                    -- Arabayı bağla
                    INNER JOIN Tbl_Arabalar A ON S.ArabaID = A.ArabaID
                    -- Müşteriyi bağla
                    INNER JOIN Tbl_Musteriler M ON S.MusteriID = M.MusteriID
                    -- YENİ: Marka adını almak için Markalar tablosunu bağla
                    INNER JOIN Tbl_Markalar Mrk ON A.MarkaID = Mrk.MarkaID
                    -- YENİ: Model adını almak için Modeller tablosunu bağla
                    INNER JOIN Tbl_Modeller Mdl ON A.ModelID = Mdl.ModelID
                    ORDER BY S.SatisTarihi DESC";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Satis s = new Satis();
                            s.SatisID = Convert.ToInt32(dr["SatisID"]);
                            s.ArabaID = Convert.ToInt32(dr["ArabaID"]);
                            s.MusteriID = Convert.ToInt32(dr["MusteriID"]);
                            s.GercekSatisFiyati = Convert.ToDecimal(dr["GercekSatisFiyati"]);
                            s.SatisTarihi = Convert.ToDateTime(dr["SatisTarihi"]);

                            // Sanal (NotMapped) alanlar
                            s.AracBilgi = dr["AracBilgi"].ToString();
                            s.MusteriAdSoyad = dr["MusteriAdSoyad"].ToString();

                            listem.Add(s);
                        }
                    }
                }
            }
            return listem;
        }
    }
}