using EkDers.Data.Repositories.Concrete;
using EkDers.Entity.DbEntity;
using EkDers.Win.Controllers.Mesaj;
using System;
using System.Threading.Tasks;

namespace EkDers.Win.Views.TanimlarViews.GorevIslemleriViews
{
    public partial class frmGorevListesi : DevExpress.XtraEditors.XtraForm
    {
         
        private readonly  GorevRepository gorevRepo;
        public frmGorevListesi()
        {
            InitializeComponent(); 
           gorevRepo = new GorevRepository();   
            ListAll();
        }
        


        public void ListAll()
        {

            gridControl1.DataSource = gorevRepo.GetAll(); ;
        }
       

        private void Kaydet()
        {

            string gorevad = textEdit1.Text.Trim();

           
            if (!gorevRepo.Any(c => c.GorevAd.ToLower() == gorevad.Trim().ToLower()))
            {
                  gorevRepo.Add(new Gorev { GorevAd = gorevad.Trim().ToUpper(), IsDeleted = false });
                   
               ListAll();
            }
            else
            {
                
                MesajController.UyariMesajiver("Kayıt Başarısız", $"{gorevad} zaten kayılı.");
            }
          


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

    }
}