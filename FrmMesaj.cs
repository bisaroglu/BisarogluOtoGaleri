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
    public partial class FrmMesaj : Form
    {
        // Formu sürüklemek için değişkenler
        private bool surukleniyor = false;
        private Point baslangicNoktasi = new Point(0, 0);

        public FrmMesaj()
        {
            InitializeComponent();
            // Sürükleme olaylarını bağla
            this.MouseDown += FrmMesaj_MouseDown;
            this.MouseUp += FrmMesaj_MouseUp;
            this.MouseMove += FrmMesaj_MouseMove;

            // Etiketlere tıklayınca da form sürüklensin
            lblBaslik.MouseDown += FrmMesaj_MouseDown;
            lblBaslik.MouseUp += FrmMesaj_MouseUp;
            lblBaslik.MouseMove += FrmMesaj_MouseMove;
        }

        // --- ALTIN ÇERÇEVE ÇİZİMİ (Login Formundaki Gibi) ---
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Color cerceveRengi = Color.Black;
            int kalinlik = 3;
            using (Pen kalem = new Pen(cerceveRengi, kalinlik))
            {
                kalem.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                e.Graphics.DrawRectangle(kalem, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        // --- FORM SÜRÜKLEME KODLARI ---
        private void FrmMesaj_MouseDown(object sender, MouseEventArgs e)
        {
            surukleniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }
        private void FrmMesaj_MouseUp(object sender, MouseEventArgs e)
        {
            surukleniyor = false;
        }
        private void FrmMesaj_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukleniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - baslangicNoktasi.X, p.Y - baslangicNoktasi.Y);
            }
        }

        // Butona basınca kapat
        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMesaj_Click(object sender, EventArgs e)
        {

        }
    }
}
