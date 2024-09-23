namespace EkDers.Win.Views.TanimlarViews.GorevIslemleriViews
{
    partial class frmYeniGorev
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
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textEditGorevAd = new DevExpress.XtraEditors.TextEdit();
            simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)textEditGorevAd.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(12, 21);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(82, 19);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Görev Adı :";
            // 
            // textEditGorevAd
            // 
            textEditGorevAd.Location = new System.Drawing.Point(100, 18);
            textEditGorevAd.Name = "textEditGorevAd";
            textEditGorevAd.Size = new System.Drawing.Size(370, 26);
            textEditGorevAd.TabIndex = 1;
            // 
            // simpleButtonKaydet
            // 
            simpleButtonKaydet.Location = new System.Drawing.Point(350, 63);
            simpleButtonKaydet.Name = "simpleButtonKaydet";
            simpleButtonKaydet.Size = new System.Drawing.Size(120, 50);
            simpleButtonKaydet.TabIndex = 2;
            simpleButtonKaydet.Text = "Kaydet";
            simpleButtonKaydet.Click += simpleButtonKaydet_Click;
            // 
            // frmYeniGorev
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(498, 141);
            Controls.Add(simpleButtonKaydet);
            Controls.Add(textEditGorevAd);
            Controls.Add(labelControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmYeniGorev";
            Text = "Yeni Görev";
            ((System.ComponentModel.ISupportInitialize)textEditGorevAd.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditGorevAd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
    }
}