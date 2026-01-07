using BisarogluOtoGaleri.DataAccess;
using BisarogluOtoGaleri.Entity;
using System;
using System.Collections.Generic; // List<> için gerekli
using System.Data.SqlClient;

namespace BisarogluOtoGaleri.DataAccess
{
    public class ArabaDal
    {
        // --- (Bu metotta bir değişiklik yok, sadece liste getirdiği için ekliyorum) ---
        public List<Araba> TumArabalariGetir()
        {
            List<Araba> arabalar = new List<Araba>();
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();
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
                            // Diğer alanları (Km, Yakıt vb.) ihtiyaç oldukça buraya eklersin.
                            arabalar.Add(araba);
                        }
                    }
                }
            }
            return arabalar;
        }

        // ===================================================================
        // KRİTİK GÜNCELLEME: ArabaEkle METODU
        // ===================================================================
        // Değişen Parça, Boyalı Parça ve Durum alanları SQL'den silindiği için
        // (Durum'a varsayılan atandığı için) buradan da ÇIKARILDI.
        public int ArabaEkle(Araba araba)
        {
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();

                // SQL Sorgusu SADELEŞTİRİLDİ:
                string sorgu = "INSERT INTO Tbl_Arabalar " +
                               "(MarkaID, ModelID, Yil, Kilometre, Fiyat, YakitTuru, VitesTipi, AgirHasarKayitliMi, ResimYolu) " +
                               "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9); " +
                               "SELECT SCOPE_IDENTITY();";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", araba.MarkaID);
                    komut.Parameters.AddWithValue("@p2", araba.ModelID);
                    komut.Parameters.AddWithValue("@p3", araba.Yil);
                    komut.Parameters.AddWithValue("@p4", araba.Kilometre);
                    komut.Parameters.AddWithValue("@p5", araba.Fiyat);

                    // --- DİKKAT: YakitTipi değil YakitTuru ---
                    komut.Parameters.AddWithValue("@p6", araba.YakitTuru);
                    komut.Parameters.AddWithValue("@p7", araba.VitesTipi);

                    komut.Parameters.AddWithValue("@p8", araba.AgirHasarKayitliMi);

                    // Resim Yolu Kontrolü (Boşsa NULL gönder)
                    if (string.IsNullOrEmpty(araba.ResimYolu))
                        komut.Parameters.AddWithValue("@p9", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@p9", araba.ResimYolu);

                    // --- ÇIKARILAN PARAMETRELER (Artık yoklar) ---
                    // komut.Parameters.AddWithValue("@p...", araba.Durum);
                    // komut.Parameters.AddWithValue("@p...", araba.DegisenParcaSayisi);

                    object sonuc = komut.ExecuteScalar();
                    return Convert.ToInt32(sonuc); // Yeni ID'yi döndür
                }
            }
        }

        // ===================================================================
        // GÜNCELLEME: ArabaGetir METODU (Verileri eksiksiz çekmek için)
        // ===================================================================
        public Araba ArabaGetir(int id)
        {
            Araba araba = null;
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();

                string sorgu = "SELECT * FROM Tbl_Arabalar WHERE ArabaID = @p1";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", id);
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            araba = new Araba();
                            araba.ArabaID = Convert.ToInt32(dr["ArabaID"]);
                            araba.MarkaID = Convert.ToInt32(dr["MarkaID"]);
                            araba.ModelID = Convert.ToInt32(dr["ModelID"]);
                            araba.Yil = Convert.ToInt32(dr["Yil"]);
                            araba.Kilometre = Convert.ToInt32(dr["Kilometre"]);
                            araba.Fiyat = Convert.ToDecimal(dr["Fiyat"]);

                            // --- EKLENEN OKUMA İŞLEMLERİ ---
                            // Veritabanından gelen verileri string'e çeviriyoruz.
                            // NULL gelme ihtimaline karşı ToString() güvenlidir.
                            araba.YakitTuru = dr["YakitTuru"].ToString();
                            araba.VitesTipi = dr["VitesTipi"].ToString();
                            araba.Durum = dr["Durum"].ToString(); // Varsayılan 'Satılık' gelecektir.
                            // -------------------------------

                            araba.AgirHasarKayitliMi = Convert.ToBoolean(dr["AgirHasarKayitliMi"]);
                            araba.ResimYolu = dr["ResimYolu"] != DBNull.Value ? dr["ResimYolu"].ToString() : "";
                        }
                    }
                }
            }
            return araba;
        }

        // ===================================================================
        // KRİTİK GÜNCELLEME: ArabaGuncelle METODU
        // ===================================================================
        // Ekleme metodundaki gibi, gereksiz alanlar buradan da çıkarıldı.
        public void ArabaGuncelle(Araba araba)
        {
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();

                // SQL Sorgusu SADELEŞTİRİLDİ:
                string sorgu = "UPDATE Tbl_Arabalar SET " +
                               "MarkaID=@p1, ModelID=@p2, Yil=@p3, Kilometre=@p4, " +
                               "Fiyat=@p5, YakitTuru=@p6, VitesTipi=@p7, AgirHasarKayitliMi=@p8, " +
                               "ResimYolu = COALESCE(@p9, ResimYolu) " + // Resim seçilmediyse eskisini koru
                               "WHERE ArabaID=@ID";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", araba.MarkaID);
                    komut.Parameters.AddWithValue("@p2", araba.ModelID);
                    komut.Parameters.AddWithValue("@p3", araba.Yil);
                    komut.Parameters.AddWithValue("@p4", araba.Kilometre);
                    komut.Parameters.AddWithValue("@p5", araba.Fiyat);

                    // --- DİKKAT: YakitTipi değil YakitTuru ---
                    komut.Parameters.AddWithValue("@p6", araba.YakitTuru);
                    komut.Parameters.AddWithValue("@p7", araba.VitesTipi);

                    komut.Parameters.AddWithValue("@p8", araba.AgirHasarKayitliMi);

                    // Resim kontrolü:
                    if (string.IsNullOrEmpty(araba.ResimYolu))
                        komut.Parameters.AddWithValue("@p9", DBNull.Value); // COALESCE bunu yakalar, eskiyi yazar.
                    else
                        komut.Parameters.AddWithValue("@p9", araba.ResimYolu);

                    komut.Parameters.AddWithValue("@ID", araba.ArabaID);

                    komut.ExecuteNonQuery();
                }
            }
        }

        // --- (ResimEkle, ResimleriGetir, MarkalariGetir, ModelleriGetir metotlarında bir değişiklik yok) ---
        public void ResimEkle(AracResim resim)
        {
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();
                string sorgu = "INSERT INTO Tbl_AracResimleri (ArabaID, ResimYolu) VALUES (@p1, @p2)";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", resim.ArabaID);
                    komut.Parameters.AddWithValue("@p2", resim.ResimYolu);
                    komut.ExecuteNonQuery();
                }
            }
        }

        public List<string> ResimleriGetir(int arabaID)
        {
            List<string> resimler = new List<string>();
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();
                string sorgu = "SELECT ResimYolu FROM Tbl_AracResimleri WHERE ArabaID = @p1";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", arabaID);
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            resimler.Add(dr["ResimYolu"].ToString());
                        }
                    }
                }
            }
            return resimler;
        }

        public List<Marka> MarkalariGetir()
        {
            List<Marka> liste = new List<Marka>();
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();
                string sorgu = "SELECT * FROM Tbl_Markalar";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            liste.Add(new Marka
                            {
                                MarkaID = Convert.ToInt32(dr["MarkaID"]),
                                MarkaAdi = dr["MarkaAdi"].ToString()
                            });
                        }
                    }
                }
            }
            return liste;
        }

        public List<Model> ModelleriGetir(int markaID)
        {
            List<Model> liste = new List<Model>();
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();
                string sorgu = "SELECT * FROM Tbl_Modeller WHERE MarkaID = @p1";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", markaID);
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            liste.Add(new Model
                            {
                                ModelID = Convert.ToInt32(dr["ModelID"]),
                                MarkaID = Convert.ToInt32(dr["MarkaID"]),
                                ModelAdi = dr["ModelAdi"].ToString()
                            });
                        }
                    }
                }
            }
            return liste;
        }
    }
}