﻿using EkDers.Entity.DbEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Data.Mappings
{
    public class RaporItemMap : IEntityTypeConfiguration<RaporItem>
    {
        public void Configure(EntityTypeBuilder<RaporItem> builder)
        {
            builder.HasKey(x => x.Id); 

        }
    }
}
