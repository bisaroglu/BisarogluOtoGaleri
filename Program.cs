using System;
using System.Windows.Forms;

namespace BisarogluOtoGaleri
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SplashScreen splash = new SplashScreen();

            splash.ShowDialog();

            Application.Run(new LoginForm());
        }
    }
}