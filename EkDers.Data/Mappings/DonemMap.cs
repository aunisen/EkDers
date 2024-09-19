using EkDers.Entity.DbEntity;
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
    public class DonemMap : IEntityTypeConfiguration<Donem>
    {
        public void Configure(EntityTypeBuilder<Donem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.DonemAdi).HasMaxLength(100);  
        }
    }
}
