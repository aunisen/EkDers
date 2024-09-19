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
    public class KurumBilgiMap : IEntityTypeConfiguration<KurumBilgi>
    {
        public void Configure(EntityTypeBuilder<KurumBilgi> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Etiket).HasMaxLength(200); 
            builder.Property(x=>x.Deger).HasMaxLength(500); 

        }
    }
}
