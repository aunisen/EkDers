using DevExpress.Xpo;
using EkDers.Data.Repositories.Concrete;
using Dat=EkDers.Data.UnitOfWork;
using EkDers.Entity.DbEntity;
using System;
using System.Threading.Tasks; 
using EkDers.Win.Controllers.Mesaj;

namespace EkDers.Win.Views.TanimlarViews.GorevIslemleriViews
{
    public partial class frmYeniGorev : DevExpress.XtraEditors.XtraForm
    {
       private readonly Dat.UnitOfWork unitofwork;
        private   Repository<Gorev> repository;
        public    frmYeniGorev()
        {
            InitializeComponent();
            unitofwork = new Dat.UnitOfWork();
            textEditGorevAd.Focus();
             
        }
        

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }


        private async Task kaydet()
        {
            string gorevad = textEditGorevAd.Text.Trim();

            repository = await unitofwork.GetRepository<Gorev>();
            if (!await repository.Any(c => c.GorevAd.ToLower() == gorevad.Trim().ToLower()))
            {
                await repository.AddAsync(new Gorev { GorevAd = gorevad.Trim().ToUpper(), IsDeleted = false });
                await unitofwork.SaveAsync();
                textEditGorevAd.Clear();
                textEditGorevAd.Focus();
            }
            else
            {
                this.Hide();
                MesajController.UyariMesajiver("Kayıt Başarısız",$"{gorevad} zaten kayılı."  );
            }
            this.Close();
        }
    }
}