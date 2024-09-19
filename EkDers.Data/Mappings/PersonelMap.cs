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
    public class PersonelMap : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Ad).HasMaxLength(50); 
            builder.Property(x=>x.Soyad).HasMaxLength(50); 
            builder.Property(x=>x.TCKN).HasMaxLength(50); 
            builder.Property(x=>x.Telefon).HasMaxLength(500); 

        }
    }
}
