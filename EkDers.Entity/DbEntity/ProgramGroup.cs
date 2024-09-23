﻿using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class ProgramGroup:DbEntityBase
    {
        public string GroupAd { get; set; }
        public string Aciklama { get; set; }
        public DateOnly BaslangicTarihi { get; set; }
        public ICollection<OgretmenProgram> OgretmenPrograms { get; set; }
    }
}
