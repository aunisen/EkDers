using EkDers.Data.Repositories.Concrete;
using EkDers.Entity.DbEntity;
using EkDers.Win.Controllers.Mesaj;
using System;

namespace EkDers.Win.Views.TanimlarViews.EkDersKodlari
{
    public partial class frmYeniEkdersKodu : DevExpress.XtraEditors.XtraForm
    {
        
        private readonly EkderKoduRepository repository;
        public frmYeniEkdersKodu()
        {
            InitializeComponent();
           repository = new EkderKoduRepository();  
            
        }
        

        private void Kaydet()
        {
            string kod = textEditKod.Text;
            string kodad = textEditKodAd.Text;
            string aciklama=memoEditAciklama.Text;

            if (string.IsNullOrEmpty(kod) || string.IsNullOrEmpty(kodad))
            {
                MesajController.UyariMesajiver("Kod veya Kod Adı alanları boş geçilemez","Zorunlu Alanlar");
                return;
            } 
            if(  repository.Any(c=>c.Kodu.ToLower()==kod.ToLower()))
            {
                MesajController.HataMesajiver($"{kod} zaten kayıtlı.", "Kayıt Hatası");
                return;
            }
            else
            {
                 repository.Add(new EkdersKodu { KodAd = kodad, Kodu=kod, Aciklama=aciklama });
                
            }

        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
    }
}