using DevExpress.Xpo;
using EkDers.Data.Repositories.Concrete;
using Dat=EkDers.Data.UnitOfWork;
using EkDers.Entity.DbEntity;
using System;
using System.Threading.Tasks;

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
             
        }
        

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }


        private async Task kaydet()
        {
            repository = await unitofwork.GetRepository<Gorev>();
            await repository.AddAsync(new Gorev { GorevAd = textEditGorevAd.Text.Trim().ToUpper(), IsDeleted = false });
            await unitofwork.SaveAsync();
            this.Close();
        }
    }
}