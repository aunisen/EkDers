 
using System;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;


namespace EkDers.Win
{
    internal static class Program
    {

         
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXICompact);
             

            Application.SetCompatibleTextRenderingDefault(false); 
            Application.Run(new frmMain());
        }
    }
}
