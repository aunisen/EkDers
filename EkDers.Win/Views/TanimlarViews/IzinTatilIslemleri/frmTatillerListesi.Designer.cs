namespace EkDers.Win.Views.TanimlarViews.IzinTatilIslemleri
{
    partial class frmTatillerListesi
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
            colTatilAd = new DevExpress.XtraGrid.Columns.GridColumn();
            colTatilTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            colBaslangicTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            colGunSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            colKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            spinEditGunSayisi = new DevExpress.XtraEditors.SpinEdit();
            checkEditEkdersKesilirmi = new DevExpress.XtraEditors.CheckEdit();
            checkEditYarimgun = new DevExpress.XtraEditors.CheckEdit();
            dateEditBaslangicTarihi = new DevExpress.XtraEditors.DateEdit();
            comboBoxEditTur = new DevExpress.XtraEditors.ComboBoxEdit();
            simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textEditKod = new DevExpress.XtraEditors.TextEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEditAd = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spinEditGunSayisi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkEditEkdersKesilirmi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkEditYarimgun.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditBaslangicTarihi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditBaslangicTarihi.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEditTur.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditKod.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditAd.Properties).BeginInit();
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
            gridControl1.Size = new System.Drawing.Size(844, 549);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colTatilAd, colTatilTuru, colBaslangicTarihi, colGunSayisi, colKodu });
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
            // colTatilAd
            // 
            colTatilAd.Caption = "Tatilin Adı";
            colTatilAd.FieldName = "TatilAd";
            colTatilAd.MinWidth = 150;
            colTatilAd.Name = "colTatilAd";
            colTatilAd.Visible = true;
            colTatilAd.VisibleIndex = 0;
            colTatilAd.Width = 150;
            // 
            // colTatilTuru
            // 
            colTatilTuru.Caption = "Türü";
            colTatilTuru.FieldName = "TatilTuru";
            colTatilTuru.MinWidth = 100;
            colTatilTuru.Name = "colTatilTuru";
            colTatilTuru.Visible = true;
            colTatilTuru.VisibleIndex = 1;
            colTatilTuru.Width = 112;
            // 
            // colBaslangicTarihi
            // 
            colBaslangicTarihi.Caption = "Başlangıç Tarihi";
            colBaslangicTarihi.FieldName = "BaslangicTarihi";
            colBaslangicTarihi.MinWidth = 30;
            colBaslangicTarihi.Name = "colBaslangicTarihi";
            colBaslangicTarihi.Visible = true;
            colBaslangicTarihi.VisibleIndex = 2;
            colBaslangicTarihi.Width = 112;
            // 
            // colGunSayisi
            // 
            colGunSayisi.Caption = "Gün Sayısı";
            colGunSayisi.FieldName = "GunSayisi";
            colGunSayisi.MinWidth = 80;
            colGunSayisi.Name = "colGunSayisi";
            colGunSayisi.Visible = true;
            colGunSayisi.VisibleIndex = 3;
            colGunSayisi.Width = 112;
            // 
            // colKodu
            // 
            colKodu.Caption = "Kodu";
            colKodu.FieldName = "RaporKodu";
            colKodu.MinWidth = 60;
            colKodu.Name = "colKodu";
            colKodu.Visible = true;
            colKodu.VisibleIndex = 4;
            colKodu.Width = 112;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(spinEditGunSayisi);
            panelControl1.Controls.Add(checkEditEkdersKesilirmi);
            panelControl1.Controls.Add(checkEditYarimgun);
            panelControl1.Controls.Add(dateEditBaslangicTarihi);
            panelControl1.Controls.Add(comboBoxEditTur);
            panelControl1.Controls.Add(simpleButtonKaydet);
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Controls.Add(textEditKod);
            panelControl1.Controls.Add(labelControl6);
            panelControl1.Controls.Add(labelControl5);
            panelControl1.Controls.Add(labelControl7);
            panelControl1.Controls.Add(labelControl4);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(textEditAd);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(350, 553);
            panelControl1.TabIndex = 3;
            // 
            // spinEditGunSayisi
            // 
            spinEditGunSayisi.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEditGunSayisi.Location = new System.Drawing.Point(20, 251);
            spinEditGunSayisi.Name = "spinEditGunSayisi";
            spinEditGunSayisi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEditGunSayisi.Size = new System.Drawing.Size(300, 28);
            spinEditGunSayisi.TabIndex = 3;
            // 
            // checkEditEkdersKesilirmi
            // 
            checkEditEkdersKesilirmi.EditValue = true;
            checkEditEkdersKesilirmi.Location = new System.Drawing.Point(54, 448);
            checkEditEkdersKesilirmi.Name = "checkEditEkdersKesilirmi";
            checkEditEkdersKesilirmi.Properties.Caption = "Ek ders kesilir mi?";
            checkEditEkdersKesilirmi.Size = new System.Drawing.Size(168, 27);
            checkEditEkdersKesilirmi.TabIndex = 6;
            checkEditEkdersKesilirmi.CheckedChanged += checkEditEkdersKesilirmi_CheckedChanged;
            // 
            // checkEditYarimgun
            // 
            checkEditYarimgun.Location = new System.Drawing.Point(54, 387);
            checkEditYarimgun.Name = "checkEditYarimgun";
            checkEditYarimgun.Properties.Caption = "Yarım gün";
            checkEditYarimgun.Size = new System.Drawing.Size(168, 27);
            checkEditYarimgun.TabIndex = 5;
            checkEditYarimgun.CheckedChanged += checkEditYarimgun_CheckedChanged;
            // 
            // dateEditBaslangicTarihi
            // 
            dateEditBaslangicTarihi.EditValue = null;
            dateEditBaslangicTarihi.Location = new System.Drawing.Point(20, 189);
            dateEditBaslangicTarihi.Name = "dateEditBaslangicTarihi";
            dateEditBaslangicTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditBaslangicTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditBaslangicTarihi.Size = new System.Drawing.Size(300, 26);
            dateEditBaslangicTarihi.TabIndex = 2;
            // 
            // comboBoxEditTur
            // 
            comboBoxEditTur.Location = new System.Drawing.Point(20, 125);
            comboBoxEditTur.Name = "comboBoxEditTur";
            comboBoxEditTur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEditTur.Size = new System.Drawing.Size(300, 26);
            comboBoxEditTur.TabIndex = 1;
            // 
            // simpleButtonKaydet
            // 
            simpleButtonKaydet.Location = new System.Drawing.Point(220, 481);
            simpleButtonKaydet.Name = "simpleButtonKaydet";
            simpleButtonKaydet.Size = new System.Drawing.Size(100, 50);
            simpleButtonKaydet.TabIndex = 7;
            simpleButtonKaydet.Text = "Kaydet";
            simpleButtonKaydet.Click += simpleButtonKaydet_Click;
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(20, 100);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(45, 19);
            labelControl3.TabIndex = 19;
            labelControl3.Text = "Türü :";
            // 
            // textEditKod
            // 
            textEditKod.Location = new System.Drawing.Point(20, 317);
            textEditKod.Name = "textEditKod";
            textEditKod.Size = new System.Drawing.Size(300, 26);
            textEditKod.TabIndex = 4;
            // 
            // labelControl6
            // 
            labelControl6.Location = new System.Drawing.Point(20, 423);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(143, 19);
            labelControl6.TabIndex = 20;
            labelControl6.Text = "Ek Ders Kesilir mi? :";
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(20, 362);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(143, 19);
            labelControl5.TabIndex = 21;
            labelControl5.Text = "Yarım gün var mı? :";
            // 
            // labelControl7
            // 
            labelControl7.Location = new System.Drawing.Point(20, 227);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(81, 19);
            labelControl7.TabIndex = 22;
            labelControl7.Text = "Gün Saysı :";
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(20, 294);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(52, 19);
            labelControl4.TabIndex = 23;
            labelControl4.Text = "Kodu : ";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(20, 164);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(127, 19);
            labelControl2.TabIndex = 24;
            labelControl2.Text = "Başlangıç Tarihi : ";
            // 
            // textEditAd
            // 
            textEditAd.Location = new System.Drawing.Point(20, 65);
            textEditAd.Name = "textEditAd";
            textEditAd.Size = new System.Drawing.Size(300, 26);
            textEditAd.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(20, 40);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(84, 19);
            labelControl1.TabIndex = 25;
            labelControl1.Text = "Tatilin Adı :";
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(gridControl1);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl2.Location = new System.Drawing.Point(350, 0);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(848, 553);
            panelControl2.TabIndex = 4;
            // 
            // frmTatillerListesi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1198, 553);
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmTatillerListesi";
            Text = "Tatiller Listesi";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spinEditGunSayisi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkEditEkdersKesilirmi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkEditYarimgun.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditBaslangicTarihi.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditBaslangicTarihi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEditTur.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditKod.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTatilAd;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SpinEdit spinEditGunSayisi;
        private DevExpress.XtraEditors.CheckEdit checkEditEkdersKesilirmi;
        private DevExpress.XtraEditors.CheckEdit checkEditYarimgun;
        private DevExpress.XtraEditors.DateEdit dateEditBaslangicTarihi;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditTur;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditKod;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colTatilTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBaslangicTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colGunSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colKodu;
    }
}