using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class Donem:DbEntityBase
    {
        
        public string  DonemAd { get; set; }
        
        public DateOnly DonemBaslangicTarihi { get; set; }
        public DateOnly DonemBitisTarihi { get; set; }
        public int DonemYil { get; set; } 
        public int DonemAy { get; set; }
       

        public ICollection<RaporItem> EkdersResults { get; set; }

        public override string ToString()
        {
            return DonemAd;
        }


    }
}
