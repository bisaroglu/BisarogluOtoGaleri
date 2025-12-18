using System;
using System.Windows.Forms;

namespace BisarogluOtoGaleri
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();


            timer1.Interval = 1000;


            timer1.Enabled = true;
            timer1.Start();
        }

        // Timer dolunca burası çalışacak
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        
    }
}
