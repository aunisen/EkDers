using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class EkdersKodu:DbEntityBase
    {
       
        public string KodAd { get; set; }
        public string Kodu { get; set; } 
        public string Aciklama { get; set; } 

        public ICollection<OgretmenProgram> OgretmenPrograms { get; set; }

    }
}
