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
    public class EkdersKoduMap : IEntityTypeConfiguration<EkdersKodu>
    {
        public void Configure(EntityTypeBuilder<EkdersKodu> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Aciklama).HasMaxLength(500); 
            builder.Property(x=>x.Kodu).HasMaxLength(100); 
            builder.Property(x=>x.KodAd).HasMaxLength(100); 

        }
    }
}
