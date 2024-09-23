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
    public class GorevMap : IEntityTypeConfiguration<Gorev>
    {
        public void Configure(EntityTypeBuilder<Gorev> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.GorevAd).HasMaxLength(500);
            builder.HasData(
                new Gorev { GorevAd= "Müdür",Id= Guid.Parse("0C30E774-4B13-4EC4-B354-157728FFB11C") },
                new Gorev { GorevAd = "Müdür Yardımcısı", Id = Guid.Parse("3B4DCBEF-C723-40BE-B73E-19CD09604C59") },
                new Gorev { GorevAd = "Öğretmen", Id = Guid.Parse("35084397-55C0-47BB-B1FE-17F02FF27601") } 


                );

        }
    }
}
