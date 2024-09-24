using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkDers.Win.Views.GirisViews.DonemIslemleri
{
    public partial class frmYeniDonem : DevExpress.XtraEditors.XtraForm
    {
        public frmYeniDonem()
        {
            InitializeComponent();
        }

        private void tabNavigationPage3_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void officeNavigationBar1_SelectedItemChanged(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e)
        {
            if (e.Item == officeNavigationBar1.Items[0])
            {
                tabPane1.SelectedPage = tabNavigationPage1;
            }
            else if (e.Item == officeNavigationBar1.Items[1]) 
            {
                tabPane1.SelectedPage = tabNavigationPage2;
            }
            else if (e.Item == officeNavigationBar1.Items[2])
            {
                tabPane1.SelectedPage = tabNavigationPage3;
            }
            else if (e.Item == officeNavigationBar1.Items[3])
            {
                tabPane1.SelectedPage = tabNavigationPage4;
            } 
        }
    }
}