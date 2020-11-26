using FootballSchoolMS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Configuration
{
   public class GroupConfiguration : BaseEntityConfiguration<Group>
    {
        public override void Configure(EntityTypeBuilder<Group> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Name).IsRequired();
            builder.Property(b => b.Age).IsRequired();
            builder.Property(b => b.NumberOfPlayers).IsRequired();
            builder.HasOne(b => b.Employee1).WithMany(b => b.Groups1).HasForeignKey(builder => builder.CoachID);
            builder.HasOne(b => b.Employee2).WithMany(b => b.Groups2).HasForeignKey(builder => builder.AssistantCoach1ID);
            builder.HasOne(b => b.Employee3).WithMany(b => b.Groups3).HasForeignKey(builder => builder.AssistantCoach2ID);

            builder.HasData(new List<Group> {
                new Group
                {
                    Id = 1,
                    Name = "Group1",
                    Age = 18,
                    NumberOfPlayers = 25,
                    CoachID = 1,
                    AssistantCoach1ID = 2,
                    AssistantCoach2ID = 3,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
                new Group
                {
                    Id = 2,
                    Name = "Group2",
                    Age = 15,
                    NumberOfPlayers = 22,
                    CoachID = 2,
                    AssistantCoach1ID = 1,
                    AssistantCoach2ID = 3,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
                new Group
                {
                    Id = 3,
                    Name = "Group3",
                    Age = 25,
                    NumberOfPlayers = 26,
                    CoachID = 2,
                    AssistantCoach1ID = 3,
                    AssistantCoach2ID = 1,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                }
            });
        }
    }
}
