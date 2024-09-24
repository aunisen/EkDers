using EkDers.Data.Repositories.Concrete;
using EkDers.Entity.DbEntity;
using EkDers.Win.Controllers.Mesaj;
using System;
using System.Threading.Tasks;

namespace EkDers.Win.Views.TanimlarViews.EkDersKodlari
{
    public partial class frmEkdersKodListesi : DevExpress.XtraEditors.XtraForm
    {
        
        private readonly EkderKoduRepository repository;
        public frmEkdersKodListesi()
        {
            InitializeComponent();
            repository = new EkderKoduRepository(); 
            Listele();
        }
       

        private void Kaydet()
        {
            string kod = textEditKod.Text;
            string kodad = textEditKodAd.Text;
            string aciklama = memoEditAciklama.Text;

            if (string.IsNullOrEmpty(kod) || string.IsNullOrEmpty(kodad))
            {
                MesajController.UyariMesajiver("Kod veya Kod Adı alanları boş geçilemez", "Zorunlu Alanlar");
                return;
            }
            if (repository.Any(c => c.Kodu.ToLower() == kod.ToLower()))
            {
                MesajController.HataMesajiver($"{kod} zaten kayıtlı.", "Kayıt Hatası");
                return;
            }
            else
            {
               repository.Add(new EkdersKodu { KodAd = kodad, Kodu = kod, Aciklama = aciklama });
                 Listele();
            }

        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
          
        }

        private void Listele()
        {
           
            gridControl1.DataSource = repository.GetAll();
            textEditKod.Clear();
            textEditKodAd.Clear();
            memoEditAciklama.Clear();
            textEditKod.Focus();
        }
    }
}

