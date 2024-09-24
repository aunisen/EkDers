using EkDers.Data.Repositories.Concrete;
using EkDers.Entity.DbEntity;
using EkDers.Win.Controllers.Mesaj;
using System;

namespace EkDers.Win.Views.TanimlarViews.BransIslemleriViews
{
    public partial class frmBransListesi : DevExpress.XtraEditors.XtraForm
    {
        
        private readonly BransRepository repository;
        public frmBransListesi()
        {
            InitializeComponent();
            repository = new BransRepository(); 
            ListAll();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            kaydet();
        }
       

        public void ListAll()
        { 
            gridControl1.DataSource = repository.GetAll();
            textEdit1.Clear();
            textEdit1.Focus();  
        }
        public void ListAll2()
        { 
            gridControl1.DataSource = repository.GetAll();
            textEdit1.Clear();
            textEdit1.Focus();
        }

        private void kaydet()
        {

            string bransad = textEdit1.Text.Trim();

           
            if (! repository.Any(c => c.BransAd.ToLower() == bransad.Trim().ToLower()))
            {
                repository.Add(new Brans { BransAd = bransad.Trim().ToUpper(), IsDeleted = false });
                ListAll2();
            }
            else
            {
                 
                MesajController.UyariMesajiver("Kayıt Başarısız", $"{bransad} zaten kayılı.");
            }
            


        }

    }
}