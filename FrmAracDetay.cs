using BisarogluOtoGaleri.Business;
using BisarogluOtoGaleri.DataAccess;
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
    public partial class FrmAracDetay : Form
    {
        ArabaManager _manager;
        string _secilenKaynakDosyaYolu = "";
        public FrmAracDetay()
        {
            InitializeComponent();
            _manager = new ArabaManager();
        }

        private void FrmAracDetay_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Formdaki verileri Araba nesnesine doldur
                Araba yeniAraba = new Araba();

                // Sayısal değerleri çevirirken (Convert) hata olmaması için basit önlem:
                yeniAraba.MarkaID = int.Parse(txtMarka.Text);
                yeniAraba.ModelID = int.Parse(txtModel.Text);
                yeniAraba.Yil = int.Parse(txtYil.Text);
                yeniAraba.Kilometre = int.Parse(txtKilometre.Text);

                // Fiyat boş bırakılırsa veya 0 girilirse Backend'deki AI/Hesaplayıcı devreye girecek!
                decimal fiyat;
                decimal.TryParse(txtFiyat.Text, out fiyat);
                yeniAraba.Fiyat = fiyat;

                yeniAraba.VitesTipi = cmbVites.Text;
                yeniAraba.YakitTuru = cmbYakit.Text;
                yeniAraba.AgirHasarKayitliMi = chkAgirHasar.Checked;
                string kaydedilenResimAdi = _manager.ResimDosyasiniYonet(_secilenKaynakDosyaYolu);

                // Sabit değerler (Şimdilik)
                yeniAraba.ResimYolu = kaydedilenResimAdi;
                yeniAraba.Durum = "Satılık";
                yeniAraba.DegisenParcaSayisi = 0;
                yeniAraba.BoyaliParcaSayisi = 0;

                // 2. Manager'a gönder
                _manager.ArabaEkle(yeniAraba);

                MessageBox.Show("Araba ve resmi başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Araç Resmini Seçin";

            // Diyalog açıldı ve kullanıcı bir dosya seçip OK dedi mi?
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 1. Seçilen dosyanın tam yolunu al
                _secilenKaynakDosyaYolu = openFileDialog1.FileName;

                // 2. Resmi PictureBox'ta göster (Önizleme)
                pbxAracResim.ImageLocation = _secilenKaynakDosyaYolu;
            }
        }
    }
}
