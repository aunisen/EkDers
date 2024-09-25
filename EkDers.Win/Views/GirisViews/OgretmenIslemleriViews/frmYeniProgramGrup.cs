using DevExpress.XtraEditors;
using EkDers.Data.Repositories.Concrete;
using EkDers.Entity.DbEntity;
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
    public partial class frmYeniProgramGrup : DevExpress.XtraEditors.XtraForm
    {
        private readonly ProgramGroupRepository repository;
        public frmYeniProgramGrup()
        {
            InitializeComponent();
            repository = new ProgramGroupRepository();
            Listele();
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            ProgramGroup pg = new();
            pg.Aciklama = memoEditAciklama.Text.Trim();
            pg.ProgramKodu=textEditKod.Text.Trim();
            pg.AktifProgramMi = true;
            pg.GroupAd=textEditGrupAd.Text.Trim();
            pg.BaslangicTarihi = new DateOnly(dateEditBaslamaTarihi.DateTime.Year, dateEditBaslamaTarihi.DateTime.Month, dateEditBaslamaTarihi.DateTime.Day); 
            repository.Add(pg);
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = repository.GetAll();
        }
    }
}