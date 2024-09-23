namespace EkDers.Win.Views.TanimlarViews.IzinTatilIslemleri
{
    partial class frmYeniIzin
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
            textEditIzinTuru = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)textEditIzinTuru.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // simpleButtonKaydet
            // 
            simpleButtonKaydet.Location = new System.Drawing.Point(352, 125);
            simpleButtonKaydet.Name = "simpleButtonKaydet";
            simpleButtonKaydet.Size = new System.Drawing.Size(120, 50);
            simpleButtonKaydet.TabIndex = 8;
            simpleButtonKaydet.Text = "Kaydet";
            simpleButtonKaydet.Click += simpleButtonKaydet_Click;
            // 
            // textEditIzinTuru
            // 
            textEditIzinTuru.Location = new System.Drawing.Point(21, 26);
            textEditIzinTuru.Name = "textEditIzinTuru";
            textEditIzinTuru.Size = new System.Drawing.Size(451, 26);
            textEditIzinTuru.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(21, 1);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(76, 19);
            labelControl1.TabIndex = 6;
            labelControl1.Text = "İzin Türü :";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(21, 58);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(36, 19);
            labelControl2.TabIndex = 6;
            labelControl2.Text = "Kodu";
            // 
            // textEdit1
            // 
            textEdit1.Location = new System.Drawing.Point(21, 83);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new System.Drawing.Size(451, 26);
            textEdit1.TabIndex = 1;
            // 
            // frmYeniIzin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(498, 187);
            Controls.Add(simpleButtonKaydet);
            Controls.Add(textEdit1);
            Controls.Add(labelControl2);
            Controls.Add(textEditIzinTuru);
            Controls.Add(labelControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmYeniIzin";
            Text = "Yeni İzin Türü";
            ((System.ComponentModel.ISupportInitialize)textEditIzinTuru.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
        private DevExpress.XtraEditors.TextEdit textEditIzinTuru;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}