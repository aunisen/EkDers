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

namespace EkDers.Win.Views.TanimlarViews.BransIslemleriViews
{
    public partial class frmBransListesi : DevExpress.XtraEditors.XtraForm
    {
        private readonly UnitOfWork unitOfWork;
        private Repository<Brans> repository;
        public frmBransListesi()
        {
            InitializeComponent();
            unitOfWork = new();
            ListAll();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            kaydet();
        }
        public async Task SetupSettings()
        {
            
            repository = await unitOfWork.GetRepository<Brans>();
        }

        public async Task ListAll()
        {
            await SetupSettings();
            var liste = await repository.GetAllAsync();
            gridControl1.DataSource = liste;
            textEdit1.Clear();
            textEdit1.Focus();  
        }
        public async Task ListAll2()
        {

            var liste = await repository.GetAllAsync();
            gridControl1.DataSource = liste;
            textEdit1.Clear();
            textEdit1.Focus();
        }

        private async Task kaydet()
        {

            string bransad = textEdit1.Text.Trim();

            repository = await unitOfWork.GetRepository<Brans>();
            if (!await repository.Any(c => c.BransAd.ToLower() == bransad.Trim().ToLower()))
            {
                await repository.AddAsync(new Brans { BransAd = bransad.Trim().ToUpper(), IsDeleted = false });
                await unitOfWork.SaveAsync();
                await ListAll2();
            }
            else
            {
                 
                MesajController.UyariMesajiver("Kayıt Başarısız", $"{bransad} zaten kayılı.");
            }
            


        }

    }
}