using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class IzinTuru:DbEntityBase
    {
        public string TurAdi { get; set; }
        public string RaporKodu { get; set; }
        

        public ICollection<OgretmenIzin> Izins { get; set; }

        public override string ToString()
        {
            return $"{TurAdi}";
        }
    }
}
