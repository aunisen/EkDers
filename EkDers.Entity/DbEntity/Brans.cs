using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class Brans : DbEntityBase
    {
        public string BransAdi { get; set; }
        public ICollection<Personel> Personels { get; set; }

        public Brans()
        {

        }
        public Brans(string bransadi)
        {
            this.BransAdi = bransadi;
        }
    }
}
