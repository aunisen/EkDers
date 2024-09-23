using EkDers.Entity.DbEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Data.Mappings
{
    public class MezuniyetTuruMap : IEntityTypeConfiguration<MezuniyetTuru>
    {
        public void Configure(EntityTypeBuilder<MezuniyetTuru> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.MezuniyetTurAd).HasMaxLength(100);
            
        }
    }
}
