using FootballSchoolMS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Configuration
{
   public class TrainingTypeConfiguration : BaseEntityConfiguration<TrainingType>
    {
        public override void Configure(EntityTypeBuilder<TrainingType> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Name).IsRequired();
            builder.HasMany(b => b.Trainings).WithOne(b => b.TrainingType).HasForeignKey(builder => builder.TrainingTypeID);

            builder.HasData(new List<TrainingType> {

                new TrainingType { 
                    Id = 1,
                    Name = "TrainingType1",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                
                },
                new TrainingType { 
                    Id = 2,
                    Name = "TrainingType2",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                
                },
                new TrainingType { 
                    Id = 3,
                    Name = "TrainingType3",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                
                },
            });

        }
    }
}
