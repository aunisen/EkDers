using EkDers.Data.Repositories.Concrete;
using EkDers.Entity.DbEntity;
using EkDers.Win.Controllers.Mesaj;
using System; 

namespace EkDers.Win.Views.TanimlarViews.IzinTatilIslemleri
{
    public partial class frmYeniIzin : DevExpress.XtraEditors.XtraForm
    {
       
        private readonly IzinTuruRepository repository;
        public frmYeniIzin()
        {
            InitializeComponent(); 
        }

       

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
          Kaydet();
        }

        private void Kaydet()
        {
            string izintur=textEditIzinTuru.Text.Trim();
            string kod = textEdit1.Text.Trim();
            if(string.IsNullOrEmpty(izintur) || string.IsNullOrEmpty(kod))  {
                MesajController.UyariMesajiver("Zorunlu Alanlar", "Izin Turu alanı boş geçilemez");
                textEditIzinTuru.Focus(); 
                return; 
            }
            if (repository.Any(c => c.TurAdi.ToLower() == izintur.ToLower())) {
                this.Hide();
                MesajController.HataMesajiver("Kayıt Hatası", $"{izintur} zaten kayıtlı");
                
            }
            else
            {
                 repository.Add(new IzinTuru { TurAdi= izintur, RaporKodu=kod });
                  
            }
            this.Close();
        }
    }
}