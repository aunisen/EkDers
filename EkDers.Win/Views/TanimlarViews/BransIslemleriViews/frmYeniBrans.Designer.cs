namespace EkDers.Win.Views.TanimlarViews.BransIslemleriViews
{
    partial class frmYeniBrans
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
            textEditGorevAd = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)textEditGorevAd.Properties).BeginInit();
            SuspendLayout();
            // 
            // simpleButtonKaydet
            // 
            simpleButtonKaydet.Location = new System.Drawing.Point(349, 57);
            simpleButtonKaydet.Name = "simpleButtonKaydet";
            simpleButtonKaydet.Size = new System.Drawing.Size(120, 50);
            simpleButtonKaydet.TabIndex = 5;
            simpleButtonKaydet.Text = "Kaydet";
            simpleButtonKaydet.Click += simpleButtonKaydet_Click;
            // 
            // textEditGorevAd
            // 
            textEditGorevAd.Location = new System.Drawing.Point(99, 12);
            textEditGorevAd.Name = "textEditGorevAd";
            textEditGorevAd.Size = new System.Drawing.Size(370, 26);
            textEditGorevAd.TabIndex = 4;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(11, 15);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(79, 19);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "Branş Adı :";
            // 
            // frmYeniBrans
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(498, 133);
            Controls.Add(simpleButtonKaydet);
            Controls.Add(textEditGorevAd);
            Controls.Add(labelControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "frmYeniBrans";
            Text = "Yeni Branş";
            ((System.ComponentModel.ISupportInitialize)textEditGorevAd.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
        private DevExpress.XtraEditors.TextEdit textEditGorevAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}