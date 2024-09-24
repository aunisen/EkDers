namespace EkDers.Win.Views.GirisViews.OgretmenIslemleriViews
{
    partial class frmOgretmenListesi
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
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colBransId = new DevExpress.XtraGrid.Columns.GridColumn();
            colGorevId = new DevExpress.XtraGrid.Columns.GridColumn();
            colKariyerBasamakId = new DevExpress.XtraGrid.Columns.GridColumn();
            colMezuniyetTuruId = new DevExpress.XtraGrid.Columns.GridColumn();
            colTckn = new DevExpress.XtraGrid.Columns.GridColumn();
            colAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            colGorevAd = new DevExpress.XtraGrid.Columns.GridColumn();
            colKariyerBasamak = new DevExpress.XtraGrid.Columns.GridColumn();
            colBransAd = new DevExpress.XtraGrid.Columns.GridColumn();
            colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            colMezuniyetAd = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(2, 2);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1194, 708);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colBransId, colGorevId, colKariyerBasamakId, colMezuniyetTuruId, colTckn, colAdSoyad, colGorevAd, colKariyerBasamak, colBransAd, colTelefon, colMezuniyetAd });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.AutoPopulateColumns = false;
            gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            gridView1.OptionsBehavior.AutoUpdateTotalSummary = false;
            gridView1.OptionsBehavior.Editable = false;
            // 
            // colId
            // 
            colId.Caption = "gridColumn1";
            colId.FieldName = "Id";
            colId.MinWidth = 30;
            colId.Name = "colId";
            colId.Width = 112;
            // 
            // colBransId
            // 
            colBransId.Caption = "Kod Adı";
            colBransId.FieldName = "BransId";
            colBransId.MaxWidth = 300;
            colBransId.MinWidth = 150;
            colBransId.Name = "colBransId";
            colBransId.Width = 150;
            // 
            // colGorevId
            // 
            colGorevId.Caption = "GorevId";
            colGorevId.FieldName = "GorevId";
            colGorevId.MaxWidth = 80;
            colGorevId.MinWidth = 80;
            colGorevId.Name = "colGorevId";
            colGorevId.Width = 80;
            // 
            // colKariyerBasamakId
            // 
            colKariyerBasamakId.Caption = "KariyerBasamakId";
            colKariyerBasamakId.FieldName = "KariyerBasamakId";
            colKariyerBasamakId.MinWidth = 30;
            colKariyerBasamakId.Name = "colKariyerBasamakId";
            colKariyerBasamakId.Width = 112;
            // 
            // colMezuniyetTuruId
            // 
            colMezuniyetTuruId.Caption = "MezuniyetTuruId";
            colMezuniyetTuruId.FieldName = "MezuniyetTuruId";
            colMezuniyetTuruId.MinWidth = 30;
            colMezuniyetTuruId.Name = "colMezuniyetTuruId";
            colMezuniyetTuruId.Width = 112;
            // 
            // colTckn
            // 
            colTckn.Caption = "TCKN";
            colTckn.FieldName = "Tckn";
            colTckn.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            colTckn.MaxWidth = 140;
            colTckn.MinWidth = 140;
            colTckn.Name = "colTckn";
            colTckn.Visible = true;
            colTckn.VisibleIndex = 0;
            colTckn.Width = 140;
            // 
            // colAdSoyad
            // 
            colAdSoyad.Caption = "Ad Soyad";
            colAdSoyad.FieldName = "AdSoyad";
            colAdSoyad.MinWidth = 30;
            colAdSoyad.Name = "colAdSoyad";
            colAdSoyad.OptionsColumn.AllowEdit = false;
            colAdSoyad.Visible = true;
            colAdSoyad.VisibleIndex = 1;
            colAdSoyad.Width = 176;
            // 
            // colGorevAd
            // 
            colGorevAd.Caption = "Görev";
            colGorevAd.FieldName = "GorevAd";
            colGorevAd.MaxWidth = 150;
            colGorevAd.MinWidth = 150;
            colGorevAd.Name = "colGorevAd";
            colGorevAd.Visible = true;
            colGorevAd.VisibleIndex = 4;
            colGorevAd.Width = 150;
            // 
            // colKariyerBasamak
            // 
            colKariyerBasamak.Caption = "Kariyer";
            colKariyerBasamak.FieldName = "KariyerBasamakAd";
            colKariyerBasamak.MaxWidth = 150;
            colKariyerBasamak.MinWidth = 150;
            colKariyerBasamak.Name = "colKariyerBasamak";
            colKariyerBasamak.Visible = true;
            colKariyerBasamak.VisibleIndex = 5;
            colKariyerBasamak.Width = 150;
            // 
            // colBransAd
            // 
            colBransAd.Caption = "Branş";
            colBransAd.FieldName = "BransAd";
            colBransAd.MaxWidth = 150;
            colBransAd.MinWidth = 150;
            colBransAd.Name = "colBransAd";
            colBransAd.Visible = true;
            colBransAd.VisibleIndex = 3;
            colBransAd.Width = 150;
            // 
            // colTelefon
            // 
            colTelefon.Caption = "Telefon";
            colTelefon.FieldName = "Telefon";
            colTelefon.MaxWidth = 150;
            colTelefon.MinWidth = 150;
            colTelefon.Name = "colTelefon";
            colTelefon.Visible = true;
            colTelefon.VisibleIndex = 2;
            colTelefon.Width = 150;
            // 
            // colMezuniyetAd
            // 
            colMezuniyetAd.Caption = "Mezuniyet";
            colMezuniyetAd.FieldName = "MezuniyetAd";
            colMezuniyetAd.MaxWidth = 150;
            colMezuniyetAd.MinWidth = 150;
            colMezuniyetAd.Name = "colMezuniyetAd";
            colMezuniyetAd.Visible = true;
            colMezuniyetAd.VisibleIndex = 6;
            colMezuniyetAd.Width = 150;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(gridControl1);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl2.Location = new System.Drawing.Point(0, 0);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(1198, 712);
            panelControl2.TabIndex = 6;
            // 
            // frmOgretmenListesi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1198, 712);
            Controls.Add(panelControl2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmOgretmenListesi";
            Text = "Öğretmenler Listesi";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colBransId;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevId;
        private DevExpress.XtraGrid.Columns.GridColumn colKariyerBasamakId;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colMezuniyetTuruId;
        private DevExpress.XtraGrid.Columns.GridColumn colTckn;
        private DevExpress.XtraGrid.Columns.GridColumn colAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colBransAd;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevAd;
        private DevExpress.XtraGrid.Columns.GridColumn colKariyerBasamak;
        private DevExpress.XtraGrid.Columns.GridColumn colMezuniyetAd;
    }
}