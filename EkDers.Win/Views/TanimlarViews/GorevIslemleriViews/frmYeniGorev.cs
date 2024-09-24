using EkDers.Data.Repositories.Concrete;
using EkDers.Entity.DbEntity;
using EkDers.Win.Controllers.Mesaj;
using System;
using System.Threading.Tasks; 

namespace EkDers.Win.Views.TanimlarViews.GorevIslemleriViews
{
    public partial class frmYeniGorev : DevExpress.XtraEditors.XtraForm
    {
       
        private   GorevRepository repository;
        public    frmYeniGorev()
        {
            InitializeComponent(); 
            repository = new GorevRepository(); 
            textEditGorevAd.Focus();
             
        }
        

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }


        private void Kaydet()
        {
            string gorevad = textEditGorevAd.Text.Trim();

          
            if (!repository.Any(c => c.GorevAd.ToLower() == gorevad.Trim().ToLower()))
            {
                repository.Add(new Gorev { GorevAd = gorevad.Trim().ToUpper(), IsDeleted = false });
              
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