using EkDers.Win.Controllers.Mesaj;
using EkDers.Win.Views.GirisViews;
using EkDers.Win.Views.GirisViews.DonemIslemleri;
using EkDers.Win.Views.GirisViews.OgretmenIslemleriViews;
using EkDers.Win.Views.TanimlarViews.BransIslemleriViews;
using EkDers.Win.Views.TanimlarViews.EkDersKodlari;
using EkDers.Win.Views.TanimlarViews.GorevIslemleriViews;
using EkDers.Win.Views.TanimlarViews.IzinTatilIslemleri;
using System;

namespace EkDers.Win
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void barButtonItemYeniGorev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYeniGorev gorev = new();
            gorev.ShowDialog();
        }

        private void barButtonItemGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGorevListesi grmgorevlistesi = new frmGorevListesi();
            grmgorevlistesi.MdiParent = this;
            grmgorevlistesi.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYeniBrans frm = new();
            frm.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBransListesi frm = new();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYeniEkdersKodu frm = new();
            frm.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEkdersKodListesi frm = new();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYeniIzin frm = new();
            frm.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmIzinTuruListesi frm = new();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYeniTatil frm = new();
            frm.ShowDialog();

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTatillerListesi frm = new();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYeniOgretmen frm = new();
            frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOgretmenListesi frm = new();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYeniDonem frm = new();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
