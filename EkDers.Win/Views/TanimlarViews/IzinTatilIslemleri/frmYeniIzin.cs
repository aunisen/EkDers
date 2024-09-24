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

namespace EkDers.Win.Views.TanimlarViews.IzinTatilIslemleri
{
    public partial class frmYeniIzin : DevExpress.XtraEditors.XtraForm
    {
        private readonly UnitOfWork unitOfWork;
        private RepositoryAsnync<IzinTuru> repository;
        public frmYeniIzin()
        {
            InitializeComponent();
            unitOfWork = new();
            SetSettings();
        }

        private async Task SetSettings()
        {
            repository=await unitOfWork.GetRepository<IzinTuru>();
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
          Kaydet();
        }

        private async Task Kaydet()
        {
            string izintur=textEditIzinTuru.Text.Trim();
            string kod = textEdit1.Text.Trim();
            if(string.IsNullOrEmpty(izintur) || string.IsNullOrEmpty(kod))  {
                MesajController.UyariMesajiver("Zorunlu Alanlar", "Izin Turu alanı boş geçilemez");
                textEditIzinTuru.Focus(); 
                return; 
            }
            if (await repository.Any(c => c.TurAdi.ToLower() == izintur.ToLower())) {
                this.Hide();
                MesajController.HataMesajiver("Kayıt Hatası", $"{izintur} zaten kayıtlı");
                
            }
            else
            {
               await repository.AddAsync(new IzinTuru { TurAdi= izintur, RaporKodu=kod });
                await unitOfWork.SaveAsync();
            }
            this.Close();
        }
    }
}