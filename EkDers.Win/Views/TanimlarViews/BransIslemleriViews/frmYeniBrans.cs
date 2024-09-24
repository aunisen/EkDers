using EkDers.Data.Repositories.Concrete;
using EkDers.Entity.DbEntity;
using EkDers.Win.Controllers.Mesaj;
using System; 

namespace EkDers.Win.Views.TanimlarViews.BransIslemleriViews
{
    public partial class frmYeniBrans : DevExpress.XtraEditors.XtraForm
    {
       
        private readonly BransRepository repository;
        public frmYeniBrans()
        {
            InitializeComponent();
           repository = new BransRepository();
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }


        private void Kaydet()
        {
            
            string brans = textEditGorevAd.Text;
            if(!repository.Any(c=>c.BransAd.ToLower()==brans.ToLower()))
            {  
                repository.Add(new Brans { BransAd = textEditGorevAd.Text.Trim().ToUpper(), IsDeleted = false });  
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