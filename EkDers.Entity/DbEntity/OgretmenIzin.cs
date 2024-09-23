using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class OgretmenIzin:DbEntityBase
    {

     
        public DateOnly BaslagicTarihi { get; set; }
        public int GunSayisi { get; set; }
        public string Aciklama { get; set; }
        public int OdenecekEkdersSaati { get; set; } 


        public Guid IzinTuruId { get; set; }
        public IzinTuru IzinTuru { get; set; }

        public Guid OgretmenId { get; set; } 
        public Ogretmen Ogretmen { get; set; }
         
    }
}
