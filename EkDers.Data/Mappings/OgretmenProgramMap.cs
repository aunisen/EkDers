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
    public class OgretmenProgramMap : IEntityTypeConfiguration<OgretmenProgram>
    {
        public void Configure(EntityTypeBuilder<OgretmenProgram> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}
