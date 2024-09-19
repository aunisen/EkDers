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
    public class IzinTuruMap : IEntityTypeConfiguration<IzinTuru>
    {
        public void Configure(EntityTypeBuilder<IzinTuru> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.TurAdi).HasMaxLength(500); 

        }
    }
}
