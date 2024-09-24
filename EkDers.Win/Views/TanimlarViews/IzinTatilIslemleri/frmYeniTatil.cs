﻿using EkDers.Data.Repositories.Concrete;
using EkDers.Entity.DbEntity;
using EkDers.Win.Controllers.Mesaj;
using System;

namespace EkDers.Win.Views.TanimlarViews.IzinTatilIslemleri
{
    public partial class frmYeniTatil : DevExpress.XtraEditors.XtraForm
    {
        
        private TatilRepository repository;
        public frmYeniTatil()
        {
            InitializeComponent();
           repository = new TatilRepository();
            SetSettings();
        }

        private void SetSettings()
        {
            comboBoxEditTur.Properties.Items.Add("Resmi Tatil");
            comboBoxEditTur.Properties.Items.Add("Dini Bayram"); 
            comboBoxEditTur.Properties.Items.Add("İdari İzinli"); 
            comboBoxEditTur.Properties.Items.Add("Kar Tatili"); 

             
            textEditAd.Focus();
            checkEditYarimgun_CheckedChanged(null, null);
            checkEditEkdersKesilirmi_CheckedChanged(null, null);
        }

       private void Kaydet()
        {
            var tatilad = textEditAd.Text;
            var gunsayis = spinEditGunSayisi.Value;
            if (string.IsNullOrEmpty(tatilad) || gunsayis == 0)
            {
                MesajController.UyariMesajiver("Zorunlu Alanlar", "Tatil Adı, Gün Sayısı, Başlangıç Tarihi zorunlu alanlardır.");
                return;
            }
            if(repository.Any(c => c.TatilAd.ToLower() == tatilad.ToLower()))
            {
                MesajController.HataMesajiver("Kayıt Hatası", $"{tatilad} zaten kayıtlıdır.");
            }
            else
            {
                 repository.Add(new Tatil {EkDersKesilirmi=checkEditEkdersKesilirmi.Checked, 
                    BaslangicTarihi=new DateOnly(dateEditBaslangicTarihi.DateTime.Date.Year,
                    dateEditBaslangicTarihi.DateTime.Date.Month, 
                    dateEditBaslangicTarihi.DateTime.Date.Day),
                    GunSayisi=(int)spinEditGunSayisi.Value, 
                   RaporKodu=textEditKod.Text.Trim().ToUpper(), 
                    TatilTuru=comboBoxEditTur.SelectedItem.ToString(), 
                    Yarimgunvarmi=checkEditYarimgun.Checked, 
                    TatilAd=tatilad.ToUpper()  });
                
                
            }
            this.Close();
        }

        private void checkEditYarimgun_CheckedChanged(object sender, EventArgs e)
        {
            checkEditYarimgun.Text = checkEditYarimgun.Checked ? "Yarım gün ödenecek" : "Tam gün kesilecek";
        }

        private void checkEditEkdersKesilirmi_CheckedChanged(object sender, EventArgs e)
        {
            checkEditEkdersKesilirmi.Text = checkEditEkdersKesilirmi.Checked ? "Kesilecek" : "Kesilmeyecek";
        }

        public void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        
        }
    }
}