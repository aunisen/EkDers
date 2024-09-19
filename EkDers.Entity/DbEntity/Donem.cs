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
        public Donem()
        {
            
        }
        public Donem(DateOnly baslangic, DateOnly bitis, int yil, int ay)
        {
            this.DonemBaslangicTarihi = baslangic;
            this.DonemBitisTarihi = bitis;
            this.DonemYil = yil;
            this.DonemAy = ay;  
        }
        public string  DonemAdi { get; set; }
        
        public DateOnly DonemBaslangicTarihi { get; set; }
        public DateOnly DonemBitisTarihi { get; set; }
        public int DonemYil { get; set; } 
        public int DonemAy { get; set; }
       

        public ICollection<EkdersResult> EkdersResults { get; set; }
       
    }
}
