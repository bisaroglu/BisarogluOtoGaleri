using System;
using System.Windows.Forms;

namespace BisarogluOtoGaleri
{
    public partial class LoginForm : Form
    {
        private object cmbGirisTuru;

        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

            if (cmbGirisTürü.Properties.Items.Count > 0)
            {
                cmbGirisTürü.SelectedIndex = 0; // Varsayılan olarak ilkini seç (Yönetici)
            }

            // EKSTRA GÜVENLİK (Tech Lead Dokunuşu):
            // Kullanıcının klavyeden "Müdür", "Patron" gibi kafasına göre şeyler yazmasını engeller.
            cmbGirisTürü.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }
        private void GirisBasarili(string rol)
        {

            this.Hide();


            FrmAnaSayfa anaForm = new FrmAnaSayfa(rol);


            anaForm.FormClosed += (s, args) => this.Close();

            anaForm.Show();


        }

        private void HataVer(string mesaj)
        {
            MessageBox.Show(mesaj, "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string girisTuru = cmbGirisTürü.Text; // DevExpress ComboBoxEdit'te de Text özelliği geçerlidir.

            // 2. Erken Validasyonlar (Boş Geçilemez Kontrolleri)
            if (string.IsNullOrEmpty(girisTuru))
            {
                HataVer("Lütfen giriş türünü seçiniz!");
                return; // İşlemi durdur
            }

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                HataVer("Kullanıcı adı ve şifre boş bırakılamaz.");
                return;
            }

            // 3. Giriş Mantığı
            if (girisTuru == "Yönetici")
            {
                // Sunum için hardcoded şifre: admin / 1234
                // NOT: Boş şifre ile giriş sunumda risklidir, basit de olsa bir şifre koyduk.
                if (kullaniciAdi == "admin" && sifre == "1234")
                {
                    GirisBasarili("Yönetici");
                }
                else
                {
                    HataVer("Hatalı Yönetici bilgileri! (Demo: admin/1234)");
                }
            }
            else if (girisTuru == "Satış Uzmanı")
            {
                // DİKKAT: Eski kodunda burada şifre sormadan giriş yapıyordu. DÜZELTİLDİ.
                if (kullaniciAdi == "satis" && sifre == "1234")
                {
                    GirisBasarili("Satış Uzmanı");
                }
                else
                {
                    HataVer("Hatalı Satış Personeli bilgileri! (Demo: satis/1234)");
                }
            }
        }

        private void cmbGirisTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}