namespace EkDers.Win
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItemYeniGorev = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemGorevListesi = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemPersonelGorevListesi = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(45, 44, 45, 44);
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, ribbonControl1.SearchEditItem, barButtonItemYeniGorev, barButtonItemGorevListesi, barButtonItemPersonelGorevListesi });
            ribbonControl1.Location = new System.Drawing.Point(0, 0);
            ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            ribbonControl1.MaxItemId = 4;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.OptionsMenuMinWidth = 495;
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2, ribbonPage3, ribbonPage4, ribbonPage5 });
            ribbonControl1.Size = new System.Drawing.Size(1455, 231);
            // 
            // barButtonItemYeniGorev
            // 
            barButtonItemYeniGorev.Caption = "Yeni Görev Tanımı";
            barButtonItemYeniGorev.Id = 1;
            barButtonItemYeniGorev.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItemYeniGorev.ImageOptions.Image");
            barButtonItemYeniGorev.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItemYeniGorev.ImageOptions.LargeImage");
            barButtonItemYeniGorev.Name = "barButtonItemYeniGorev";
            barButtonItemYeniGorev.ItemClick += barButtonItemYeniGorev_ItemClick;
            // 
            // barButtonItemGorevListesi
            // 
            barButtonItemGorevListesi.Caption = "Görev Listesi";
            barButtonItemGorevListesi.Id = 2;
            barButtonItemGorevListesi.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItemGorevListesi.ImageOptions.Image");
            barButtonItemGorevListesi.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItemGorevListesi.ImageOptions.LargeImage");
            barButtonItemGorevListesi.Name = "barButtonItemGorevListesi";
            barButtonItemGorevListesi.ItemClick += barButtonItemGorevListesi_ItemClick;
            // 
            // barButtonItemPersonelGorevListesi
            // 
            barButtonItemPersonelGorevListesi.Caption = "Personel Görevleri";
            barButtonItemPersonelGorevListesi.Id = 3;
            barButtonItemPersonelGorevListesi.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItemPersonelGorevListesi.ImageOptions.Image");
            barButtonItemPersonelGorevListesi.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItemPersonelGorevListesi.ImageOptions.LargeImage");
            barButtonItemPersonelGorevListesi.Name = "barButtonItemPersonelGorevListesi";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "GİRİŞ";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "GÖRÜNÜM";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3, ribbonPageGroup6 });
            ribbonPage3.Name = "ribbonPage3";
            ribbonPage3.Text = "TANIMLAR";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(barButtonItemYeniGorev);
            ribbonPageGroup3.ItemLinks.Add(barButtonItemGorevListesi);
            ribbonPageGroup3.ItemLinks.Add(barButtonItemPersonelGorevListesi);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "Görev İşlemleri";
            // 
            // ribbonPageGroup6
            // 
            ribbonPageGroup6.Name = "ribbonPageGroup6";
            ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPage4
            // 
            ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup4 });
            ribbonPage4.Name = "ribbonPage4";
            ribbonPage4.Text = "AYARLAR";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPage5
            // 
            ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup5 });
            ribbonPage5.Name = "ribbonPage5";
            ribbonPage5.Text = "RAPORLAR";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            xtraTabbedMdiManager1.CloseTabOnMiddleClick = DevExpress.XtraTabbedMdi.CloseTabOnMiddleClick.Never;
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1455, 756);
            Controls.Add(ribbonControl1);
            IsMdiContainer = true;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "frmMain";
            Ribbon = ribbonControl1;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemYeniGorev;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGorevListesi;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPersonelGorevListesi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

