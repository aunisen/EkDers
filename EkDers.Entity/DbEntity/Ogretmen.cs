using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace EkDers.Entity.DbEntity
{
    public class Ogretmen:DbEntityBase
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public Guid GorevId { get; set; }
        public Gorev Gorev { get; set; }
        public Guid BransId { get; set; }
        public Brans Brans { get; set; }
        public Guid MezuniyetTuruId { get; set; }
        public MezuniyetTuru MezuniyetTuru { get; set; }

        public Guid KariyerBasamagiId { get; set; }
        public KariyerBasamagi KariyerBasamagi { get; set; }

        public ICollection<OgretmenProgram> Programs { get; set; }
        public ICollection<OgretmenIzin> OgretmenIzins { get; set; }
        public ICollection<RaporItem> EkdersResults { get; set; }
    }
}
