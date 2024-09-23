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
        public Gorev()
        {
            
        }
        public Gorev(string gorevad, Guid Id)
        {
            this.GorevAd = gorevad;
            this.Id = Id;   
        }
        public string GorevAd { get; set; }

        public ICollection<Ogretmen> Personels { get; set; }
    }
}
