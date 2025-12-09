using DevExpress.XtraEditors;
using BisarogluOtoGaleri.Business;
using BisarogluOtoGaleri.Entity;

namespace BisarogluOtoGaleri
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MusteriManager yonetici = new MusteriManager();
                List<Musteri> veriler = yonetici.TumMusterileriGetir();
                dataGridView1.DataSource = veriler;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
            }
        }
    }    
}
""