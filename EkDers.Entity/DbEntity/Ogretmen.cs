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
        public bool SinifOgretmenligiVarmi { get; set; } = false;
        public bool KulubuVarmi { get; set; } = true;
        public Guid GorevId { get; set; }
        public virtual Gorev Gorev { get; set; }
        public Guid BransId { get; set; }
        public virtual Brans Brans { get; set; }
        public Guid MezuniyetTuruId { get; set; }
        public virtual MezuniyetTuru MezuniyetTuru { get; set; }

        public Guid KariyerBasamagiId { get; set; }
        public virtual KariyerBasamagi KariyerBasamagi { get; set; }

        public virtual ICollection<OgretmenProgram> Programs { get; set; }
        public virtual ICollection<OgretmenIzin> OgretmenIzins { get; set; }
        public virtual ICollection<RaporItem> EkdersResults { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad} ({Brans.BransAd})";
        }
    }
}
