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
            SqlConnection baglanti = Baglanti.BaglantiGetir();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Musteriler", baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            List<Musteri> liste = new List<Musteri>();

            while (dr.Read())
            {
                Musteri m = new Musteri();
                m.MusteriID = Convert.ToInt32(dr["MusteriID"]);
                m.Ad = dr["Ad"].ToString();
                m.Soyad = dr["Soyad"].ToString();
                m.TCKimlik = dr["TCKimlik"].ToString();
                m.Telefon = dr["Telefon"].ToString();
                m.Mail = dr["Mail"].ToString();
                m.Adres = dr["Adres"].ToString();
                liste.Add(m);
            }
            dr.Close();
            baglanti.Close();
            return liste;
        }
    }
}
