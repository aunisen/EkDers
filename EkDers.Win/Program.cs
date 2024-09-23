 
using System;
using System.Windows.Forms;

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
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinName:"WXI Compact");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
