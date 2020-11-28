using FootballSchoolMS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Configuration
{
   public class StadiumConfiguration : BaseEntityConfiguration<Stadium>
    {
        public override void Configure(EntityTypeBuilder<Stadium> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Name).IsRequired();
            builder.Property(b => b.Address).IsRequired();
            builder.Property(b => b.Telephone).IsRequired();
            builder.Property(b => b.Capacity).IsRequired();

            builder.HasData(new List<Stadium> {
                new Stadium{ 
                Id = 1,
                Name = "Stadium1",
                Address ="Address1",
                Telephone = 11231232,
                Capacity = 20000,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "hmuftic",
                },
                new Stadium{ 
                Id = 2,
                Name = "Stadium2",
                Address ="Address2",
                Telephone = 11231232,
                Capacity = 20000,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "hmuftic",
                },  
                new Stadium{ 
                Id = 3,
                Name = "Stadium2",
                Address ="Address3",
                Telephone = 11231232,
                Capacity = 20000,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "hmuftic",
                },

                });
                }
    }
}
