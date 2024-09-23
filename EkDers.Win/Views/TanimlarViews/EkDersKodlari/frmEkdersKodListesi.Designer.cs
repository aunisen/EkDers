namespace EkDers.Win.Views.TanimlarViews.EkDersKodlari
{
    partial class frmEkdersKodListesi
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
            colKodAd = new DevExpress.XtraGrid.Columns.GridColumn();
            colKod = new DevExpress.XtraGrid.Columns.GridColumn();
            colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            memoEditAciklama = new DevExpress.XtraEditors.MemoEdit();
            simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textEditKodAd = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEditKod = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memoEditAciklama.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditKodAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditKod.Properties).BeginInit();
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
            gridControl1.Size = new System.Drawing.Size(877, 781);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colKodAd, colKod, colAciklama });
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
            // colKodAd
            // 
            colKodAd.Caption = "Kod Adı";
            colKodAd.FieldName = "KodAd";
            colKodAd.MaxWidth = 300;
            colKodAd.MinWidth = 150;
            colKodAd.Name = "colKodAd";
            colKodAd.Visible = true;
            colKodAd.VisibleIndex = 0;
            colKodAd.Width = 150;
            // 
            // colKod
            // 
            colKod.Caption = "Kod";
            colKod.FieldName = "Kodu";
            colKod.MaxWidth = 80;
            colKod.MinWidth = 80;
            colKod.Name = "colKod";
            colKod.Visible = true;
            colKod.VisibleIndex = 1;
            colKod.Width = 80;
            // 
            // colAciklama
            // 
            colAciklama.Caption = "Açıklama";
            colAciklama.FieldName = "Aciklama";
            colAciklama.MinWidth = 30;
            colAciklama.Name = "colAciklama";
            colAciklama.Visible = true;
            colAciklama.VisibleIndex = 2;
            colAciklama.Width = 112;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(memoEditAciklama);
            panelControl1.Controls.Add(simpleButtonKaydet);
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Controls.Add(textEditKodAd);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(textEditKod);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(350, 785);
            panelControl1.TabIndex = 3;
            // 
            // memoEditAciklama
            // 
            memoEditAciklama.Location = new System.Drawing.Point(20, 201);
            memoEditAciklama.Name = "memoEditAciklama";
            memoEditAciklama.Size = new System.Drawing.Size(300, 92);
            memoEditAciklama.TabIndex = 2;
            // 
            // simpleButtonKaydet
            // 
            simpleButtonKaydet.Location = new System.Drawing.Point(203, 304);
            simpleButtonKaydet.Name = "simpleButtonKaydet";
            simpleButtonKaydet.Size = new System.Drawing.Size(100, 50);
            simpleButtonKaydet.TabIndex = 3;
            simpleButtonKaydet.Text = "Kaydet";
            simpleButtonKaydet.Click += simpleButtonKaydet_Click;
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(20, 176);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(75, 19);
            labelControl3.TabIndex = 7;
            labelControl3.Text = "Acıklama :";
            // 
            // textEditKodAd
            // 
            textEditKodAd.Location = new System.Drawing.Point(20, 134);
            textEditKodAd.Name = "textEditKodAd";
            textEditKodAd.Size = new System.Drawing.Size(300, 26);
            textEditKodAd.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(20, 109);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(67, 19);
            labelControl2.TabIndex = 8;
            labelControl2.Text = "Kod Adı :";
            // 
            // textEditKod
            // 
            textEditKod.Location = new System.Drawing.Point(20, 65);
            textEditKod.Name = "textEditKod";
            textEditKod.Size = new System.Drawing.Size(300, 26);
            textEditKod.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(20, 40);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(38, 19);
            labelControl1.TabIndex = 9;
            labelControl1.Text = "Kod :";
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(gridControl1);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl2.Location = new System.Drawing.Point(350, 0);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(881, 785);
            panelControl2.TabIndex = 4;
            // 
            // frmEkdersKodListesi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1231, 785);
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmEkdersKodListesi";
            Text = "Ek Ders Kod Listesi";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memoEditAciklama.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditKodAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditKod.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKodAd;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.MemoEdit memoEditAciklama;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditKodAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditKod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colKod;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
    }
}