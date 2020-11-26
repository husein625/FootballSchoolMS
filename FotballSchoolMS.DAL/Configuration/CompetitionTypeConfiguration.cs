using FootballSchoolMS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Configuration
{
   public  class CompetitionTypeConfiguration : BaseEntityConfiguration<CompetitionType>
    {
        public override void Configure(EntityTypeBuilder<CompetitionType> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Name).IsRequired();
            builder.HasMany(b => b.Competitions).WithOne(b => b.CompetitionType).HasForeignKey(builder => builder.CompetitionTypeID);

            builder.HasData(new List<CompetitionType>
            {
                new CompetitionType
                {
                    Id = 1,
                    Name = "CompetitionType1",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic",
                },
                new CompetitionType
                {
                    Id = 2,
                    Name = "CompetitionType2",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic",
                },
                new CompetitionType
                {
                    Id = 3,
                    Name = "CompetitionType3",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic",
                },
            });
        }
    }
}
