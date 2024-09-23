 
using DevExpress.XtraEditors;
using EkDers.Data.Repositories.Abstract;
using EkDers.Data.Repositories.Concrete;
using EkDers.Data.UnitOfWork;
using EkDers.Entity.DbEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkDers.Win.Views.TanimlarViews.GorevIslemleriViews
{
    public partial class frmGorevListesi : DevExpress.XtraEditors.XtraForm
    {
        private readonly UnitOfWork unitOfWork;
        private   Repository<Gorev> gorevRepo;
        public frmGorevListesi()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork(); 
           
            ListAll();
        }
        public async Task SetupSettings()
        {
            gorevRepo = await unitOfWork.GetRepository<Gorev>();
        }


        public async Task ListAll()
        {
            await SetupSettings();
            var liste = await gorevRepo.GetAllAsync();
            gridControl1.DataSource = liste;
        }
        public async Task ListAll2()
        {
           
            var liste = await gorevRepo.GetAllAsync();
            gridControl1.DataSource = liste;
        }

        private async Task kaydet()
        { 
            await gorevRepo.AddAsync(new Gorev { GorevAd = textEdit1.Text.Trim().ToUpper(), IsDeleted = false });
            await unitOfWork.SaveAsync();
            await ListAll2();   
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            kaydet();
        }

    }
}