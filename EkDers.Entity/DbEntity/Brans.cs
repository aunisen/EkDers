﻿using EkDers.Core.Entity;
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
        public string BransAd { get; set; }
        public ICollection<Ogretmen> Ogretmens { get; set; }

        public Brans()
        {

        }
        public Brans(string bransadi)
        {
            this.BransAd = bransadi;
        }
    }
}
