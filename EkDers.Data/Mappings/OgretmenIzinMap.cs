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
    public class OgretmenIzinMap : IEntityTypeConfiguration<OgretmenIzin>
    {
        public void Configure(EntityTypeBuilder<OgretmenIzin> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Aciklama).HasMaxLength(500); 
           

        }
    }
}
