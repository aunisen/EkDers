
using DevExpress.XtraBars.ToastNotifications;
using System.Windows.Forms;

namespace EkDers.Win.Controllers.Mesaj
{
    public   class MesajController
    {
        public static ToastNotification GetToastNotification(string title, string message)
        {
            var toast=new ToastNotification();
            toast.Duration = ToastNotificationDuration.Default;
            toast.Body = message;   
            toast.Header= title;    
           
            return toast;   
        }
        public static DialogResult  HataMesajiver(string baslik, string Metin) 
        {
            return  MessageBox.Show(Metin, baslik, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult UyariMesajiver(string baslik, string Metin)
        {
            return MessageBox.Show(Metin, baslik, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult BilgiMesajiver(string baslik, string Metin)
        {
            return MessageBox.Show(Metin, baslik, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
