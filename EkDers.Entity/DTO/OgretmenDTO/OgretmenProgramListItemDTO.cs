using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DTO.OgretmenDTO
{
    public class OgretmenProgramListItemDTO
    {
        public Guid Id { get; set; }
        public Guid OgretmenId { get; set; }
        public Guid ProgramGroubuId { get; set; }
        public Guid EkdersKoduId { get; set; }

        public string OgretmenAd { get; set; } 
        public string EkDersKodAd { get; set; } 
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
