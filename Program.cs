using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Windows.Forms;
using DevExpress.Utils.Svg;

namespace BisarogluOtoGaleri
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");
            SplashScreen splash = new SplashScreen();
            splash.ShowDialog();

            // Login formu da aynı temayla açılacak.
            Application.Run(new LoginForm());
        }
    }
}