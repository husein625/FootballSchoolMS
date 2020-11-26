using FootballSchoolMS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Configuration
{
   public class CompetitionConfiguration : BaseEntityConfiguration<Competition>
    {
        public override void Configure(EntityTypeBuilder<Competition> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Name).IsRequired();
            builder.Property(b => b.IsActive).IsRequired();
            builder.HasOne(b => b.CompetitionType).WithMany(b => b.Competitions).HasForeignKey(builder => builder.CompetitionTypeID);
            builder.HasOne(b => b.Season).WithMany(b => b.Competitions).HasForeignKey(builder => builder.SeasonID);

            builder.HasData(new List<Competition>
            {
                new Competition
                {
                    Id = 1,
                    Name = "Competition1",
                    IsActive = true,
                    CompetitionTypeID = 1,
                    SeasonID = 1,
                },
                new Competition
                {
                    Id = 2,
                    Name = "Competition2",
                    IsActive = true,
                    CompetitionTypeID = 2,
                    SeasonID = 2,
                }, 
                new Competition
                {
                    Id = 3,
                    Name = "Competition3",
                    IsActive = true,
                    CompetitionTypeID = 3,
                    SeasonID = 3,
                },
            });
        }
    }
}
