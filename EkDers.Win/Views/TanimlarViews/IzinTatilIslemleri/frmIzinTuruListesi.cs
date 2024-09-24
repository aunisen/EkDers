using EkDers.Data.Repositories.Concrete;
using EkDers.Entity.DbEntity;
using EkDers.Win.Controllers.Mesaj;
using System;

namespace EkDers.Win.Views.TanimlarViews.IzinTatilIslemleri
{
    public partial class frmIzinTuruListesi : DevExpress.XtraEditors.XtraForm
    {
         
        private IzinTuruRepository repository;
        public frmIzinTuruListesi()
        {
            InitializeComponent();
            Listele();
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

 
 

        private void Listele()
        {
            textEditIzinTuru.Clear();
            textEdit1.Clear();
            textEditIzinTuru.Focus();
            
            gridControl1.DataSource= repository.GetAll(); 
        }

        

        private void Kaydet()
        {
            string izintur = textEditIzinTuru.Text;
            if (string.IsNullOrEmpty(izintur))
            {
                MesajController.UyariMesajiver("Zorunlu Alanlar", "Izin Turu alanı boş geçilemez");
                textEditIzinTuru.Focus();
                return;
            }
            if (repository.Any(c => c.TurAdi.ToLower() == izintur.ToLower()))
            {
                 
                MesajController.HataMesajiver("Kayıt Hatası", $"{izintur} zaten kayıtlı");

            }
            else
            {
                repository.Add(new IzinTuru { TurAdi = izintur, RaporKodu="" });
             
            }
           Listele();
        }
    }
}