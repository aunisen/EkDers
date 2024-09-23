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
    public class KariyerBasamagiMap : IEntityTypeConfiguration<KariyerBasamagi>
    {
        public void Configure(EntityTypeBuilder<KariyerBasamagi> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Ad).HasMaxLength(200); 
            builder.Property(x=>x.Aciklama).HasMaxLength(500); 

        }
    }
}
