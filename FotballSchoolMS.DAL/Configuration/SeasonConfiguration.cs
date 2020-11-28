using FootballSchoolMS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Configuration
{
  public  class SeasonConfiguration : BaseEntityConfiguration<Season>
    {
        public override void Configure(EntityTypeBuilder<Season> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Name).IsRequired();
            builder.HasMany(b => b.Competitions).WithOne(b => b.Season).HasForeignKey(builder => builder.SeasonID);

            builder.HasData(new List<Season> {
                new Season{ 
                Id = 1,
                Name = "Season1",
                CreatedAt =  DateTime.UtcNow,
                CreatedBy = "hmuftic"
                },
                new Season{ 
                Id = 2,
                Name = "Season2",
                CreatedAt =  DateTime.UtcNow,
                CreatedBy = "hmuftic"
                },
                new Season{ 
                Id = 3,
                Name = "Season2",
                CreatedAt =  DateTime.UtcNow,
                CreatedBy = "hmuftic"
                },
                });
        }
    }
}
