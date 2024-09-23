using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class OgretmenProgram:DbEntityBase
    {
        public Guid ProgramGroupId { get; set; }
        public ProgramGroup ProgramGroup { get; set; }

        public Guid OgretmenId { get; set; }
        public Ogretmen Ogretmen { get; set; }

        public Guid EkdersKoduId { get; set; }
        public EkdersKodu EkdersKodu { get; set; } 

        public int PazartesiDersSaati { get; set; }
        public int SaliDersSaati { get; set; }
        public int CarsambaDersSaati { get; set; }
        public int PersembeDersSaati { get; set; }
        public int CumaDersSaati { get; set; }
        public int CumartesiDersSaati { get; set; }
        public int PazarDersSaati { get; set; }
        public int PazartesiEkdersSaati { get; set; }
        public int SaliEkdersSaati { get; set; }
        public int CarsambaEkdersSaati { get; set; }
        public int PersembeEkdersSaati { get; set; }
        public int CumaEkdersSaati { get; set; }
        public int CumartesiEkdersSaati { get; set; }
        public int PazarEkdersSaati { get; set; }
        public int DerseHazrilikEkdersSaati { get; set; }
        public int NobetGunIndex { get; set; }
        public int NobetEkdersSaati { get; set; }
        public bool NobetTutuyormu { get; set; }
        public int SinifOgremenligiKlupDersSaati { get; set; }
        public bool SinifOgremenligiKlupGoreviVarmi { get; set; }

        public int PazartesiYazilacakEkdersSaati { get; set; }
        public int SaliYazilacakEkdersSaati { get; set; }
        public int CarsambaYazilacakEkdersSaati { get; set; }
        public int PersembeYazilacakEkdersSaati { get; set; }
        public int CumaYazilacakEkdersSaati { get; set; }
        public int CumartesiYazilacakEkdersSaati { get; set; }
        public int PazarYazilacakEkdersSaati { get; set; }




    }
}
