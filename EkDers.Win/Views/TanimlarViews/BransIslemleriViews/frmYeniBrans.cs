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
    public partial class frmYeniBrans : DevExpress.XtraEditors.XtraForm
    {
        private readonly UnitOfWork unitOfWork;
        private Repository<Brans> repository;
        public frmYeniBrans()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }


        private async Task kaydet()
        {
            repository = await unitOfWork.GetRepository<Brans>();
            string brans = textEditGorevAd.Text;
            if(!await repository.Any(c=>c.BransAd.ToLower()==brans.ToLower()))
            {
                
                await repository.AddAsync(new Brans { BransAd = textEditGorevAd.Text.Trim().ToUpper(), IsDeleted = false });
                await unitOfWork.SaveAsync();
                
            }
            else
            {
                this.Hide();
                MesajController.HataMesajiver("Kayıt Hatası", $"{brans} zaten kayıtlı.");
            }
            this.Close();
        }


    }
}