using System;
using System.Windows.Forms;

namespace BisarogluOtoGaleri
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

            if (cmbGiris.Properties.Items.Count > 0)
            {
                cmbGiris.SelectedIndex = 0; // Varsayılan olarak ilkini seç (Yönetici)
            }

            // EKSTRA GÜVENLİK (Tech Lead Dokunuşu):
            // Kullanıcının klavyeden "Müdür", "Patron" gibi kafasına göre şeyler yazmasını engeller.
            cmbGiris.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }
        private void GirisBasarili(string rol)
        {

            this.Hide();


            FrmAnaSayfa anaForm = new FrmAnaSayfa(rol);


            anaForm.FormClosed += (s, args) => this.Close();

            anaForm.Show();


        }


        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
       
        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            string girisTuru = cmbGiris.EditValue != null ? cmbGiris.EditValue.ToString() : "";
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            // 2. Validasyonlar
            if (string.IsNullOrEmpty(girisTuru))
            {
                BisarogluMsg.Goster("Lütfen giriş türünü seçiniz!", "UYARI");
                return;
            }

            // 3. Giriş Kontrolü
            bool girisBasarili = false; // Bayrak değişkeni

            if (girisTuru == "Yönetici" && kullaniciAdi == "admin" && sifre == "1234")
            {
                girisBasarili = true;
            }
            else if (girisTuru == "Satış Uzmanı" && kullaniciAdi == "satis" && sifre == "1234")
            {
                girisBasarili = true;
            }

            // 4. Sonuç ve Yönlendirme
            if (girisBasarili)
            {
                // HATA BURADAYDI: Parantez içi boştu.
                // DÜZELTME: 'girisTuru' değişkenini (Yönetici veya Satış Uzmanı) içeri gönderiyoruz.

                FrmAnaSayfa anaForm = new FrmAnaSayfa(girisTuru);

                anaForm.Show();
                this.Hide();
            }
            else
            {
                BisarogluMsg.Goster("Kullanıcı adı veya şifre hatalı!", "HATA");
            }
        }





        private void cmbGiris_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}