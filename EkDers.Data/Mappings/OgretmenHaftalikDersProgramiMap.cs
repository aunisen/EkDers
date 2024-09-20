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
    public class OgretmenHaftalikDersProgramiMap : IEntityTypeConfiguration<OgretmenHaftalikDersProgrami>
    {
        public void Configure(EntityTypeBuilder<OgretmenHaftalikDersProgrami> builder)
        {
            builder.ToTable("OgretmenHaftalikDersProgrami");
            
        }
    }
}
