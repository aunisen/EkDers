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

namespace EkDers.Win.Views.TanimlarViews.IzinTatilIslemleri
{
    public partial class frmTatillerListesi : DevExpress.XtraEditors.XtraForm
    {
        private readonly UnitOfWork unitOfWork;
        private Repository<Tatil> repository;
        public frmTatillerListesi()
        {
            InitializeComponent();
            unitOfWork = new();
            SetSettings();
        }

        private void checkEditYarimgun_CheckedChanged(object sender, EventArgs e)
        {
            checkEditYarimgun.Text = checkEditYarimgun.Checked ? "Yarım gün kesilecek" : "Tam gün kesilecek";
        }

        private void checkEditEkdersKesilirmi_CheckedChanged(object sender, EventArgs e)
        {
            checkEditEkdersKesilirmi.Text = checkEditEkdersKesilirmi.Checked ? "Kesilecek" : "Kesilmeyeck";
        }


        private async Task Listele()
        {
            var liste =await repository.GetAllAsync();
            gridControl1.DataSource = liste;
            textEditAd.Clear();
            textEditAd.Focus();
            textEditKod.Clear();
            comboBoxEditTur.SelectedItem = null;
            spinEditGunSayisi.Value = 0;
            checkEditEkdersKesilirmi.Checked = false;
            checkEditYarimgun.Checked = false;
            dateEditBaslangicTarihi.Clear();

        }






        private async Task SetSettings()
        {
            comboBoxEditTur.Properties.Items.Add("Resmi Tatil");
            comboBoxEditTur.Properties.Items.Add("Dini Bayram");
            comboBoxEditTur.Properties.Items.Add("İdari İzinli");
            comboBoxEditTur.Properties.Items.Add("Kar Tatili");

            repository = await unitOfWork.GetRepository<Tatil>();
            await Listele();
            
            checkEditYarimgun_CheckedChanged(null, null);
            checkEditEkdersKesilirmi_CheckedChanged(null, null);
        }

        private async Task Kaydet()
        {
            var tatilad = textEditAd.Text;
            var gunsayis = spinEditGunSayisi.Value;
            if (string.IsNullOrEmpty(tatilad) || gunsayis == 0)
            {
                MesajController.UyariMesajiver("Zorunlu Alanlar", "Tatil Adı, Gün Sayısı, Başlangıç Tarihi zorunlu alanlardır.");
                return;
            }
            if (await repository.Any(c => c.TatilAd.ToLower() == tatilad.ToLower()))
            {
                MesajController.HataMesajiver("Kayıt Hatası", $"{tatilad} zaten kayıtlıdır.");
            }
            else
            {
                await repository.AddAsync(new Tatil
                {
                    EkDersKesilirmi = checkEditEkdersKesilirmi.Checked,
                    BaslangicTarihi = new DateOnly(dateEditBaslangicTarihi.DateTime.Date.Year,
                     dateEditBaslangicTarihi.DateTime.Date.Month,
                     dateEditBaslangicTarihi.DateTime.Date.Day),
                    GunSayisi = (int)spinEditGunSayisi.Value,
                    RaporKodu = textEditKod.Text.Trim().ToUpper(),
                    TatilTuru = comboBoxEditTur.SelectedItem.ToString(),
                    Yarimgunvarmi = checkEditYarimgun.Checked,
                    TatilAd = tatilad.ToUpper()
                });
                await unitOfWork.SaveAsync();
                await Listele();

            }
           
        }

        
        public void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            Kaydet(); 

        }
    }
}