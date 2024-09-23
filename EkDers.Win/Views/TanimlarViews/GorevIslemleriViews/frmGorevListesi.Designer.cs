namespace EkDers.Win.Views.TanimlarViews.GorevIslemleriViews
{
    partial class frmGorevListesi
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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colGorevAd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(simpleButton1);
            panelControl1.Controls.Add(textEdit1);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(350, 553);
            panelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new System.Drawing.Point(220, 106);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(100, 50);
            simpleButton1.TabIndex = 2;
            simpleButton1.Text = "Kaydet";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // textEdit1
            // 
            textEdit1.Location = new System.Drawing.Point(20, 65);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new System.Drawing.Size(300, 26);
            textEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(20, 40);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(42, 19);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Görev";
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(gridControl1);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl2.Location = new System.Drawing.Point(350, 0);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(848, 553);
            panelControl2.TabIndex = 0;
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
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colGorevAd });
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
            // colGorevAd
            // 
            colGorevAd.Caption = "Görev";
            colGorevAd.FieldName = "GorevAd";
            colGorevAd.MinWidth = 30;
            colGorevAd.Name = "colGorevAd";
            colGorevAd.Visible = true;
            colGorevAd.VisibleIndex = 0;
            colGorevAd.Width = 112;
            // 
            // frmGorevListesi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1198, 553);
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            Name = "frmGorevListesi";
            Text = "Kayıtlı Görevler";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevAd;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}