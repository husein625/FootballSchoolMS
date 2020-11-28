using FootballSchoolMS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Configuration
{
   public class TrainingsPresenceConfiguration : BaseEntityConfiguration<TrainingsPresence>
    {
        public override void Configure(EntityTypeBuilder<TrainingsPresence> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.IsActive).IsRequired();
            builder.HasOne(b => b.Player).WithMany(b => b.TrainingsPresences).HasForeignKey(builder => builder.PlayerID);
            builder.HasOne(b => b.Training).WithMany(builder => builder.TrainingsPresences).HasForeignKey(builder => builder.TrainingID);


            builder.HasData(new List<TrainingsPresence> {
                new TrainingsPresence{
                    Id = 1,
                    IsActive = true,
                    PlayerID = 1,
                    TrainingID = 2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy ="hmuftic",
                },
                new TrainingsPresence{
                    Id = 2,
                    IsActive = true,
                    PlayerID = 2,
                    TrainingID = 2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy ="hmuftic",
                },
                new TrainingsPresence{
                    Id = 3,
                    IsActive = true,
                    PlayerID = 2,
                    TrainingID = 2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy ="hmuftic",
                },
                
                });
        }
    }
}
