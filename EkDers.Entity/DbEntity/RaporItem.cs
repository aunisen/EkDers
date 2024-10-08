﻿using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class RaporItem:DbEntityBase
    {
        public Guid OgretmenId { get; set; }
        public virtual Ogretmen Ogretmen { get; set; }

        public Guid KodId { get; set; }
        public virtual EkdersKodu Kod { get; set; }


        public Guid DonemId { get; set; }
        public virtual Donem Donem { get; set; }

       
        public int GunSayisi { get; set; } 
        public byte[] Data { get; set; } 
        public int Toplam { get; set; }  

    }
}
