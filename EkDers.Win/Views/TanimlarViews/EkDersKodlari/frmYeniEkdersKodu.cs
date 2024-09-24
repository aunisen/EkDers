using DevExpress.XtraEditors;
using EkDers.Data.Repositories.Concrete;
using EkDers.Data.UnitOfWork;
using EkDers.Entity.DbEntity;
using EkDers.Win.Controllers.Mesaj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkDers.Win.Views.TanimlarViews.EkDersKodlari
{
    public partial class frmYeniEkdersKodu : DevExpress.XtraEditors.XtraForm
    {
        private readonly UnitOfWork unitOfWork;
        private RepositoryAsnync<EkdersKodu> repository;
        public frmYeniEkdersKodu()
        {
            InitializeComponent();
            unitOfWork = new();
            SetSettings();
        }
        private async Task SetSettings()
        {
            repository=await unitOfWork.GetRepository<EkdersKodu>();    
        }

        private async Task Kaydet()
        {
            string kod = textEditKod.Text;
            string kodad = textEditKodAd.Text;
            string aciklama=memoEditAciklama.Text;

            if (string.IsNullOrEmpty(kod) || string.IsNullOrEmpty(kodad))
            {
                MesajController.UyariMesajiver("Kod veya Kod Adı alanları boş geçilemez","Zorunlu Alanlar");
                return;
            } 
            if(await repository.Any(c=>c.Kodu.ToLower()==kod.ToLower()))
            {
                MesajController.HataMesajiver($"{kod} zaten kayıtlı.", "Kayıt Hatası");
                return;
            }
            else
            {
               await repository.AddAsync(new EkdersKodu { KodAd = kodad, Kodu=kod, Aciklama=aciklama });
               await unitOfWork.SaveAsync();
            }

        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
    }
}