using EkDers.Data.Repositories.Concrete;
using EkDers.Entity.DbEntity;
using EkDers.Win.Controllers.Mesaj;
using System;
using System.Linq;

namespace EkDers.Win.Views.GirisViews.OgretmenIslemleriViews
{
    public partial class frmYeniOgretmen : DevExpress.XtraEditors.XtraForm
    {
         
        private readonly MezuniyetTuruRepository repoMezuniyet;
        private readonly KariyerBasamagiRepository repoKariyer;
        private readonly BransRepository repoBrans;
        private readonly GorevRepository repoGorev;
        private readonly OgretmenRepository repoOgretmen;
        public frmYeniOgretmen()
        {
            InitializeComponent();
           repoBrans = new BransRepository();
            repoGorev = new GorevRepository();
            repoKariyer=new KariyerBasamagiRepository();
            repoMezuniyet=new MezuniyetTuruRepository();    
            repoOgretmen=new OgretmenRepository();
            SetSettings();
        }
        private void SetSettings()
        {
            
            var listegorev =   repoGorev.GetAll();
            var listemezuniyet =   repoMezuniyet.GetAll();
            var listekariyer =   repoKariyer.GetAll();
            var listebrans =   repoBrans.GetAll();


            comboBoxEditGorev.Properties.Items.AddRange(listegorev.ToList());
            comboBoxEditBrans.Properties.Items.AddRange(listebrans.ToList());
            comboBoxEditKariyer.Properties.Items.AddRange(listekariyer.ToList());
            comboBoxEditMezuniyet.Properties.Items.AddRange(listemezuniyet.ToList());

            //await repoKariyer.AddAsync(new KariyerBasamagi { Ad="Öğretmen",Aciklama="Kadrolu öğretmenler"});
            // await repoKariyer.AddAsync(new KariyerBasamagi { Ad="Aday Öğretmen",Aciklama="Kadrolu öğretmenler"});
            // await repoKariyer.AddAsync(new KariyerBasamagi { Ad="Uzman Öğretmen",Aciklama="Kadrolu öğretmenler"});
            // await repoKariyer.AddAsync(new KariyerBasamagi { Ad="Baş Öğretmen",Aciklama="Kadrolu öğretmenler"});

            //await repoMezuniyet.AddAsync(new MezuniyetTuru { MezuniyetTurAd = "Fakülte/Üniversite", OdemeKodu="" });
            //await repoMezuniyet.AddAsync(new MezuniyetTuru { MezuniyetTurAd = "Yüksek Lisans/Üniversite", OdemeKodu = "" });
            //await repoMezuniyet.AddAsync(new MezuniyetTuru { MezuniyetTurAd = "Doktora/Üniversite" , OdemeKodu = "" });
            //await repoMezuniyet.AddAsync(new MezuniyetTuru { MezuniyetTurAd = "Yüksek Okul/Üniversite", OdemeKodu = "" });

            //await unitOfWork.SaveAsync();

        }

        private void frmYeniOgretmen_Load(object sender, EventArgs e)
        {

        }

      
        private void Kaydet()
        {
            if (string.IsNullOrEmpty(textEditAd.Text)) { textEditAd.Focus(); return; }
            if (string.IsNullOrEmpty(textEditSoyad.Text)) { textEditSoyad.Focus(); return; }
            if (string.IsNullOrEmpty(textEditTckn.Text)) { textEditTckn.Focus(); return; }
            if (string.IsNullOrEmpty(textEditTelefon.Text)) { textEditTelefon.Focus(); return; }
            else
            {

                var mezuniyetId = (comboBoxEditMezuniyet.SelectedItem as MezuniyetTuru).Id;
                var kariyerId = (comboBoxEditKariyer.SelectedItem as KariyerBasamagi).Id;
                var bransId = (comboBoxEditBrans.SelectedItem as Brans).Id;
                var gorevId = (comboBoxEditGorev.SelectedItem as Gorev).Id;

                Ogretmen ogr = new();
                ogr.Ad = textEditAd.Text.Trim();
                ogr.Soyad = textEditSoyad.Text.Trim();
                ogr.TCKN = textEditTckn.Text.Trim();
                ogr.Telefon = textEditTelefon.Text.Trim();
                ogr.Email = textEditEmail.Text.Trim();

                ogr.MezuniyetTuruId = mezuniyetId;
                ogr.KariyerBasamagiId = kariyerId;
               ogr.BransId = bransId;
                ogr.GorevId = gorevId;

               if( repoOgretmen.Any(c => c.TCKN == ogr.TCKN))
                {
                    MesajController.BilgiMesajiver("Kayıtlı Öğretmen", "Öğretmen zaten kayıtlı");
                }
                else
                {
                    var result=  repoOgretmen.Add(ogr); 
                }
                Temizle();

            }
        }

        private void Temizle()
        {
            textEditAd.Clear();
            textEditEmail.Clear();
            textEditSoyad.Clear();
            textEditTckn.Clear();
            textEditTelefon.Clear();
            comboBoxEditBrans.Clear();
            comboBoxEditGorev.Clear();  
            comboBoxEditKariyer.Clear();
            comboBoxEditMezuniyet.Clear();
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
    }
}