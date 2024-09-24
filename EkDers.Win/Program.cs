 
using System;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using EkDers.Win.Views.GirisViews.OgretmenIslemleriViews;
using EkDers.Win.Views.GirisViews;
using DevExpress.XtraEditors;
using EkDers.Win.Views.GirisViews.DonemIslemleri;


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
 
             SkinManager.EnableFormSkins();
            Application.EnableVisualStyles(); 
            BonusSkins.Register();
           // UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXICompact);
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI);
            Application.EnableVisualStyles();


            Application.SetCompatibleTextRenderingDefault(false);
            WindowsFormsSettings.EnableMdiFormSkins();

            var frm =new  frmMain();
            Application.Run(frm);
        }
    }
}
