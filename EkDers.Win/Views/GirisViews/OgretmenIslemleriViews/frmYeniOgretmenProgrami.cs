using DevExpress.Dialogs.Core;
using DevExpress.XtraEditors;
using EkDers.Data.Repositories.Concrete;
using EkDers.Entity.DbEntity;
using EkDers.Win.Controllers.Mesaj;
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
    public partial class frmYeniOgretmenProgrami : DevExpress.XtraEditors.XtraForm
    {
        private readonly OgretmenRepository ogretmenRepo;
        private readonly EkderKoduRepository ekdersRepo;
        private readonly ProgramGroupRepository programGroupRepo;
        private readonly OgretmenProgramRepository programRepo;
        public frmYeniOgretmenProgrami()
        {
            InitializeComponent();
            ogretmenRepo = new();
            ekdersRepo = new();
            programGroupRepo = new();
            programRepo = new();
            SetSettings();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = programRepo.GetOgretmenProgarms(null);

        }
        private void ClearAll()
        {
            textEditPazartesi.Clear();
            textEditPazartesiEkders.Clear();
            textEditSali.Clear();
            textEditSaliEkders.Clear();
            textEditCarsamba.Clear();
            textEditCarsambaEkders.Clear();
            textEditPersembe.Clear();
            textEditPersembeEkders.Clear();
            textEditCuma.Clear();
            textEditCumaEkders.Clear();
            textEditCumartesi.Reset();
            textEditCumartesiEkders.Clear();
            textEditPazartesi.Clear();
            textEditPazarEkders.Clear();
            comboBoxEditEkderKod.Clear();
            comboBoxEditOgretmen.Clear();
            comboBoxEditProgramGroup.Clear();
        }

        private void SetSettings()
        {
            comboBoxEditOgretmen.Properties.Items.AddRange(ogretmenRepo.GetAll().ToList());
            comboBoxEditEkderKod.Properties.Items.AddRange(ekdersRepo.GetAll().ToList());
            comboBoxEditProgramGroup.Properties.Items.AddRange(programGroupRepo.GetAll().ToList());
        }

        private void simpleButtonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var ogretmen = (comboBoxEditOgretmen.SelectedItem as Ogretmen);
                var kod = (comboBoxEditEkderKod.SelectedItem as EkdersKodu);
                var programGrup = (comboBoxEditProgramGroup.SelectedItem as ProgramGroup);


                 

                OgretmenProgram program = new();
                program.PazartesiDersSaati = int.Parse(textEditPazartesi.Text.Trim());
                program.PazartesiEkDersSaati = int.Parse(textEditPazartesiEkders.Text.Trim());
                program.SaliDersSaati = int.Parse(textEditSali.Text.Trim());
                program.SaliEkDersSaati = int.Parse(textEditSaliEkders.Text.Trim());
                program.CarsambaDersSaati = int.Parse(textEditCarsamba.Text.Trim());
                program.CarsambaEkDersSaati = int.Parse(textEditCarsambaEkders.Text.Trim());
                program.PersembeDersSaati = int.Parse(textEditPersembe.Text.Trim());
                program.PersembeEkDersSaati = int.Parse(textEditPersembeEkders.Text.Trim());
                program.CumaDersSaati = int.Parse(textEditCuma.Text.Trim());
                program.CumaEkDersSaati = int.Parse(textEditCumaEkders.Text.Trim());
                program.CumartesiDersSaati = int.Parse(textEditCumartesi.Text.Trim());
                program.CumartesiEkDersSaati = int.Parse(textEditCumartesiEkders.Text.Trim());
                program.PazarDersSaati = int.Parse(textEditPazar.Text.Trim());
                program.PazarEkDersSaati = int.Parse(textEditPazarEkders.Text.Trim());
                program.EkdersKoduId = kod.Id;
                //  program = int.Parse(textEditCarsamba.Text.Trim());
                program.OgretmenId = ogretmen.Id;
                program.ProgramGroupId = programGrup.Id;

                programRepo.Add(program);

               

                Listele();
                ClearAll();

            }
            catch (Exception ex)
            {

                MesajController.HataMesajiver("Hata Oluştu", ex.Message);
            }
        }

        private void comboBoxEditOgretmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ogretmen = (comboBoxEditOgretmen.SelectedItem as Ogretmen);
            if (ogretmen == null) return;
            var programlistesi= programRepo.GetOgretmenProgarms(ogretmen.Id);
            gridControl1.DataSource = programlistesi;
            gridControl1.RefreshDataSource();
        }
    }
}