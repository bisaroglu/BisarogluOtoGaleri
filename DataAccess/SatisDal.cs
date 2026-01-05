using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                string sorguSatis = "INSERT INTO Tbl_Satislar (ArabaID, MusteriID, GercekSatisFiyati, SatisTarihi) VALUES (@p1, @p2, @p3, @p4)";

                using (SqlCommand komut = new SqlCommand(sorguSatis, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", satis.ArabaID);
                    komut.Parameters.AddWithValue("@p2", satis.MusteriID);
                    komut.Parameters.AddWithValue("@p3", satis.GercekSatisFiyati);
                    komut.Parameters.AddWithValue("@p4", satis.SatisTarihi);
                    komut.ExecuteNonQuery();
                }

                // Arabanın durumunu güncelle
                string sorguDurum = "UPDATE Tbl_Arabalar SET Durum='Satıldı' WHERE ArabaID=@id";
                using (SqlCommand komut2 = new SqlCommand(sorguDurum, baglanti))
                {
                    komut2.Parameters.AddWithValue("@id", satis.ArabaID);
                    komut2.ExecuteNonQuery();
                }
            }
        }

        // 2. METOT: Satışları Listeleme (Hata aldığın yer burasıydı)
        public List<Satis> SatislariGetir()
        {
            // List<Satis> C#'ın kendi özelliğidir.
            // Yukarıdaki "using System.Collections.Generic;" sayesinde çalışır.
            List<Satis> listem = new List<Satis>();

            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();

                string sorgu = @"
                    SELECT 
                        S.SatisID, 
                        S.ArabaID, 
                        S.MusteriID, 
                        S.GercekSatisFiyati, 
                        S.SatisTarihi,
                        A.Marka + ' ' + A.Model + ' - ' + A.Plaka AS AracBilgi,
                        M.Ad + ' ' + M.Soyad AS MusteriAdSoyad
                    FROM Tbl_Satislar S
                    INNER JOIN Tbl_Arabalar A ON S.ArabaID = A.ArabaID
                    INNER JOIN Tbl_Musteriler M ON S.MusteriID = M.MusteriID
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

                            // NotMapped alanlar
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
