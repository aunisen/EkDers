using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class KurumBilgi:DbEntityBase
    {
        public string  Etiket { get; set; }
        public string  Deger { get; set; }
      
    }
}
