using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class ProgramGroup:DbEntityBase
    {
        public string GroupAd { get; set; }
        public string Aciklama { get; set; }
        public DateOnly BaslangicTarihi { get; set; }
        public string ProgramKodu { get; set; }
        public bool AktifProgramMi { get; set; }
        public virtual ICollection<OgretmenProgram> OgretmenPrograms { get; set; }

        public override string ToString()
        {
            return $"{ProgramKodu} ({GroupAd})";
        }
    }
}
