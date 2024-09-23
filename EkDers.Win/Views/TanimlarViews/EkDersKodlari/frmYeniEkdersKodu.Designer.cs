namespace EkDers.Win.Views.TanimlarViews.EkDersKodlari
{
    partial class frmYeniEkdersKodu
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
            simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            textEditKod = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEditKodAd = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            memoEditAciklama = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)textEditKod.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditKodAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoEditAciklama.Properties).BeginInit();
            SuspendLayout();
            // 
            // simpleButtonKaydet
            // 
            simpleButtonKaydet.Location = new System.Drawing.Point(353, 170);
            simpleButtonKaydet.Name = "simpleButtonKaydet";
            simpleButtonKaydet.Size = new System.Drawing.Size(120, 50);
            simpleButtonKaydet.TabIndex = 3;
            simpleButtonKaydet.Text = "Kaydet";
            simpleButtonKaydet.Click += simpleButtonKaydet_Click;
            // 
            // textEditKod
            // 
            textEditKod.Location = new System.Drawing.Point(103, 5);
            textEditKod.Name = "textEditKod";
            textEditKod.Size = new System.Drawing.Size(370, 26);
            textEditKod.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(15, 8);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(38, 19);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "Kod :";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(15, 40);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(67, 19);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "Kod Adı :";
            // 
            // textEditKodAd
            // 
            textEditKodAd.Location = new System.Drawing.Point(103, 37);
            textEditKodAd.Name = "textEditKodAd";
            textEditKodAd.Size = new System.Drawing.Size(370, 26);
            textEditKodAd.TabIndex = 1;
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(15, 72);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(75, 19);
            labelControl3.TabIndex = 3;
            labelControl3.Text = "Acıklama :";
            // 
            // memoEditAciklama
            // 
            memoEditAciklama.Location = new System.Drawing.Point(103, 69);
            memoEditAciklama.Name = "memoEditAciklama";
            memoEditAciklama.Size = new System.Drawing.Size(370, 92);
            memoEditAciklama.TabIndex = 2;
            // 
            // frmYeniEkdersKodu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(498, 243);
            Controls.Add(memoEditAciklama);
            Controls.Add(simpleButtonKaydet);
            Controls.Add(labelControl3);
            Controls.Add(textEditKodAd);
            Controls.Add(labelControl2);
            Controls.Add(textEditKod);
            Controls.Add(labelControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmYeniEkdersKodu";
            Text = "Yeni Ek Ders Kodu";
            ((System.ComponentModel.ISupportInitialize)textEditKod.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditKodAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoEditAciklama.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
        private DevExpress.XtraEditors.TextEdit textEditKod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditKodAd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit memoEditAciklama;
    }
}