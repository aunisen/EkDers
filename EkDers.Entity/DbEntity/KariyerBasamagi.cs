using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class KariyerBasamagi:DbEntityBase
    {
        public string Ad { get; set; }
        public string Aciklama { get; set; }

        public ICollection<Ogretmen> Ogretmens { get; set; }
    }
}
