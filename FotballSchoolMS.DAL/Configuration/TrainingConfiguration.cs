using FootballSchoolMS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Configuration
{
   public class TrainingConfiguration : BaseEntityConfiguration<Training>
    {
        public override void Configure(EntityTypeBuilder<Training> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Name).IsRequired();
            builder.HasOne(b => b.Group).WithMany(b => b.Trainings).HasForeignKey(builder => builder.GroupID);
            builder.HasOne(b => b.TrainingType).WithMany(b => b.Trainings).HasForeignKey(b => b.TrainingTypeID);

            builder.HasData(new List<Training> {
                new Training {
                    Id = 1,
                    Name = "Training1",
                    GroupID = 1,
                    TrainingTypeID = 1,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
                new Training {
                    Id = 2,
                    Name = "Training2",
                    GroupID = 2,
                    TrainingTypeID = 2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                }, 
                new Training {
                    Id = 3,
                    Name = "Training3",
                    GroupID = 2,
                    TrainingTypeID = 2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
                new Training {
                    Id = 4,
                    Name = "Training4",
                    GroupID = 2,
                    TrainingTypeID = 1,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                }
            });
        }
    }
}
