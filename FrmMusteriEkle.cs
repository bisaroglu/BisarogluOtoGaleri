using BisarogluOtoGaleri.Business;
using BisarogluOtoGaleri.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisarogluOtoGaleri
{
    public partial class FrmMusteriEkle : Form
    {
        MusteriManager _manager = new MusteriManager();

        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        
        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {


        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
// 1. BASİT VALİDASYON (Boş alan kontrolü)
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad ve Soyad alanlarını doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!mskTC.MaskCompleted) // TC 11 hane dolmadıysa
            {
                MessageBox.Show("Lütfen 11 haneli TC Kimlik numarasını eksiksiz giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. NESNE OLUŞTURMA
            Musteri musteri = new Musteri();
            musteri.Ad = txtAd.Text.Trim(); // Trim() baştaki sondaki boşlukları siler
            musteri.Soyad = txtSoyad.Text.Trim();
            musteri.TCKimlik = mskTC.Text; // Entity'de TCKimlik yapmıştık
            musteri.Telefon = mskTelefon.Text;
            musteri.Mail = txtMail.Text;
            musteri.Adres = txtAdres.Text;

            // 3. KAYIT VE HATA YAKALAMA (Try-Catch)
            try
            {
                _manager.MusteriEkle(musteri);

                MessageBox.Show("Müşteri başarıyla sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // İş bitince formu kapat
            }
            catch (Exception ex)
            {
                // SQL'den gelen hatayı yakalıyoruz
                // Eğer hata mesajında "Unique" veya "IX_Musteri_TC" geçiyorsa anlarız ki aynı TC var.
                if (ex.Message.Contains("IX_Musteri_TC") || ex.Message.Contains("UNIQUE"))
                {
                    MessageBox.Show("Bu TC Kimlik numarası ile kayıtlı bir müşteri zaten var!", "Mükerrer Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
