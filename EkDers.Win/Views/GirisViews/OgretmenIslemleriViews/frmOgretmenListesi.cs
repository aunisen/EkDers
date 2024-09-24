using DevExpress.XtraEditors;
using EkDers.Data.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkDers.Win.Views.GirisViews.OgretmenIslemleriViews
{
    public partial class frmOgretmenListesi : DevExpress.XtraEditors.XtraForm
    {
        public readonly OgretmenRepository ogrRepos;
        public frmOgretmenListesi()
        {
            InitializeComponent();
            ogrRepos = new OgretmenRepository();
            Listele();
        }

        public void Listele()
        {
            gridControl1.DataSource= ogrRepos.Ogretmenlistesi();
        }
    }
}