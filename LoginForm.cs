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

            if (cmbGirisTuru.Items.Count > 0)
            {
                cmbGirisTuru.SelectedIndex = 1; // 0: Yönetici, 1: Satış Uzmanı
            }
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
            string girisTuru = cmbGirisTuru.Text;

            // --- YÖNETİCİ GİRİŞİ ---
            if (girisTuru == "Yönetici")
            {
                if (kullaniciAdi == "admin" && sifre == "1234")
                {
                    GirisBasarili("Yönetici");
                }
                else
                {
                    HataVer("Hatalı Yönetici bilgileri! Lütfen kontrol ediniz.");
                }
            }
            // --- SATIŞ UZMANI GİRİŞİ ---
            else if (girisTuru == "Satış Uzmanı")
            {
                if (kullaniciAdi == "satis" && sifre == "1234")
                {
                    GirisBasarili("Satış Uzmanı");
                }
                else
                {
                    HataVer("Hatalı Satış Personeli bilgileri!");
                }
            }
            else
            {
                HataVer("Lütfen bir giriş türü seçiniz.");
            }
        }
    }
}