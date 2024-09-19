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
                new Gorev("Müdür", Guid.Parse("0C30E774-4B13-4EC4-B354-157728FFB11C")),
                new Gorev("Müdür Yardımcısı", Guid.Parse("3B4DCBEF-C723-40BE-B73E-19CD09604C59")),
                new Gorev("Öğretmen", Guid.Parse("35084397-55C0-47BB-B1FE-17F02FF27601")),
                new Gorev("Uzman Öğretmen", Guid.Parse("9B12FF59-0858-4FA2-9C20-F1ECD1C60098")),
                new Gorev("Baş Öğretmen", Guid.Parse("AC86700E-3F47-4B67-B0CD-06C038065CA7"))


                );

        }
    }
}
