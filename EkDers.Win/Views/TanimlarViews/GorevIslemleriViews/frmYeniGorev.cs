using DevExpress.XtraEditors;
using EkDers.Entity.DbEntity;
using EkDers.Service.Abstraction;
using EkDers.Service.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkDers.Win.Views.TanimlarViews.GorevIslemleriViews
{
    public partial class frmYeniGorev : DevExpress.XtraEditors.XtraForm
    {
        private  IGenericServices<Gorev> gorevManager;
        public frmYeniGorev(IGenericServices<Gorev> gorevservice)
        {
            InitializeComponent();
            gorevManager = gorevservice;

        }
        public frmYeniGorev( )
        {
            InitializeComponent(); 

        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            gorevManager.AddAsync(new Gorev { GorevAd = textEditGorevAd.Text.Trim().ToUpper(), IsDeleted = false });
            this.Close();
        }
    }
}