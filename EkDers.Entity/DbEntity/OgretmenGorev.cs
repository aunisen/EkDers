using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class OgretmenGorev:DbEntityBase
    {
        public Guid OgretmenId { get; set; }
        public virtual Ogretmen Ogretmen { get; set; }
        public string SinifOgretmeniOlduguSinif { get; set; }
        public string DanismaniOlduguKulup{ get; set; }
        public bool NobetGoreviVarmi { get; set; }
        public bool SinifOgretmenligiVarmi { get; set; } 
        public bool KulupOgretmenligiVarmi { get; set; } 
    }
}
