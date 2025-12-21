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
        public int ArabaEkle(Araba araba)
        {

            // Bağlantı yönetimi için 'using' bloğu kullanıyoruz (Memory Leak önlemi)
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();

                // Sorgunun sonuna noktalı virgül koyup SELECT SCOPE_IDENTITY() ekledik.
                // Bu komut, "Kaydı yap ve bana verdiğin ID'yi geri getir" demektir.
                string sorgu = "INSERT INTO Tbl_Arabalar " +
                               "(MarkaID, ModelID, Yil, Kilometre, Fiyat, Durum, AgirHasarKayitliMi, ResimYolu) " +
                               "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8); " +
                               "SELECT SCOPE_IDENTITY();";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", araba.MarkaID);
                    komut.Parameters.AddWithValue("@p2", araba.ModelID);
                    komut.Parameters.AddWithValue("@p3", araba.Yil);
                    komut.Parameters.AddWithValue("@p4", araba.Kilometre);
                    komut.Parameters.AddWithValue("@p5", araba.Fiyat);
                    komut.Parameters.AddWithValue("@p6", araba.Durum);
                    komut.Parameters.AddWithValue("@p7", araba.AgirHasarKayitliMi);

                    // Kapak resmi kontrolü
                    if (string.IsNullOrEmpty(araba.ResimYolu))
                        komut.Parameters.AddWithValue("@p8", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@p8", araba.ResimYolu);

                    // ExecuteNonQuery yerine ExecuteScalar kullanıyoruz (Tek bir değer/ID döneceği için)
                    object sonuc = komut.ExecuteScalar();

                    return Convert.ToInt32(sonuc); // Yeni oluşan ArabaID'yi döndür!
                }
            }
        }
        public Araba ArabaGetir(int id)
        {
            Araba araba = null; // Başlangıçta boş

            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();

                string sorgu = "SELECT * FROM Tbl_Arabalar WHERE ArabaID = @p1";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", id);

                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        if (dr.Read()) // Kayıt bulunduysa
                        {
                            araba = new Araba();
                            araba.ArabaID = Convert.ToInt32(dr["ArabaID"]);
                            araba.MarkaID = Convert.ToInt32(dr["MarkaID"]);
                            araba.ModelID = Convert.ToInt32(dr["ModelID"]);
                            araba.Yil = Convert.ToInt32(dr["Yil"]);
                            araba.Kilometre = Convert.ToInt32(dr["Kilometre"]);
                            araba.Fiyat = Convert.ToDecimal(dr["Fiyat"]);
                            araba.Durum = dr["Durum"].ToString();
                            araba.AgirHasarKayitliMi = Convert.ToBoolean(dr["AgirHasarKayitliMi"]);
                            // ResimYolu'nu zaten alıyorduk ama buraya da ekleyebilirsin
                            araba.ResimYolu = dr["ResimYolu"] != DBNull.Value ? dr["ResimYolu"].ToString() : "";
                        }
                    }
                }
            }
            return araba;
        }
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

                // Sadece o arabaya ait resimleri istiyoruz
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
        public void ArabaGuncelle(Araba araba)
        {
            using (SqlConnection baglanti = new SqlConnection(Baglanti.Adres))
            {
                if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();

                // NOT: ResimYolu'nu burada güncelliyoruz ama eğer boş geldiyse (kullanıcı resim seçmediyse)
                // SQL tarafında eski değeri korumak için küçük bir trick (COALESCE veya C# tarafında kontrol) yapacağız.
                // Şimdilik C# tarafında yönetmek daha güvenli, o yüzden sorguya direkt yazıyoruz.

                string sorgu = "UPDATE Tbl_Arabalar SET " +
               "MarkaID=@p1, ModelID=@p2, Yil=@p3, Kilometre=@p4, " +
               "Fiyat=@p5, Durum=@p6, AgirHasarKayitliMi=@p7, " +
               "ResimYolu = COALESCE(@p8, ResimYolu) " + // SİHİRLİ DOKUNUŞ BURADA!
               "WHERE ArabaID=@ID"; // Kilit Nokta: WHERE şartı!

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", araba.MarkaID);
                    komut.Parameters.AddWithValue("@p2", araba.ModelID);
                    komut.Parameters.AddWithValue("@p3", araba.Yil);
                    komut.Parameters.AddWithValue("@p4", araba.Kilometre);
                    komut.Parameters.AddWithValue("@p5", araba.Fiyat);
                    komut.Parameters.AddWithValue("@p6", araba.Durum);
                    komut.Parameters.AddWithValue("@p7", araba.AgirHasarKayitliMi);

                    // Resim kontrolü:
                    if (string.IsNullOrEmpty(araba.ResimYolu))
                        komut.Parameters.AddWithValue("@p8", DBNull.Value);
                    else
                        komut.Parameters.AddWithValue("@p8", araba.ResimYolu);

                    // GÜNCELLENECEK ID:
                    komut.Parameters.AddWithValue("@ID", araba.ArabaID);

                    komut.ExecuteNonQuery();
                }
            }
        }
    }
}