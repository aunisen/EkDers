using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class Gorev:DbEntityBase
    {
      
        public string GorevAd { get; set; }

        public ICollection<Ogretmen> Personels { get; set; }
    }
}
