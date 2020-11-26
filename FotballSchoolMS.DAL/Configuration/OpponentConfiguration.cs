using FootballSchoolMS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Configuration
{
   public class OpponentConfiguration : BaseEntityConfiguration<Opponent>
    {
        public override void Configure(EntityTypeBuilder<Opponent> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Name).IsRequired();
            builder.Property(b => b.IsActive).IsRequired();

            builder.HasData(new List<Opponent> {
                new Opponent
                {
                    Id = 1,
                    Name = "Opponent1",
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                }, 
                new Opponent
                {
                    Id = 2,
                    Name = "Opponent2",
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
                new Opponent
                {
                    Id = 3,
                    Name = "Opponent3",
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },  
                new Opponent
                {
                    Id = 4,
                    Name = "Opponent4",
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
            });
        }
    }
}
