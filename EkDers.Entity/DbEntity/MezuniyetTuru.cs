﻿using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class MezuniyetTuru:DbEntityBase
    {
        public string MezuniyetTurAd { get; set; }
        public string OdemeKodu { get; set; }
        public virtual ICollection<Ogretmen> Ogretmens { get; set; }
        public override string ToString()
        {
            return MezuniyetTurAd;
        }
    }
}
