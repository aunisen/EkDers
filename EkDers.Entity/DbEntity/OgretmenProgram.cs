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
        public virtual ProgramGroup ProgramGroup { get; set; }

        public Guid OgretmenId { get; set; }
        public virtual Ogretmen Ogretmen { get; set; }

        public Guid EkdersKoduId { get; set; }
        public virtual EkdersKodu EkdersKodu { get; set; } 

        public int PazartesiDersSaati { get; set; }
        public int SaliDersSaati { get; set; }
        public int CarsambaDersSaati { get; set; }
        public int PersembeDersSaati { get; set; }
        public int CumaDersSaati { get; set; }
        public int CumartesiDersSaati { get; set; }
        public int PazarDersSaati { get; set; }

        public int PazartesiEkDersSaati { get; set; }
        public int SaliEkDersSaati { get; set; }
        public int CarsambaEkDersSaati { get; set; }
        public int PersembeEkDersSaati { get; set; }
        public int CumaEkDersSaati { get; set; }
        public int CumartesiEkDersSaati { get; set; }
        public int PazarEkDersSaati { get; set; }





    }
}
