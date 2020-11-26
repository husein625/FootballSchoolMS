using FootballSchoolMS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Configuration
{
   public class EmployeePositionConfiguration : BaseEntityConfiguration<EmployeePosition>
    {
        public override void Configure(EntityTypeBuilder<EmployeePosition> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Name).IsRequired();
            builder.HasData(new List<EmployeePosition>
            {
                new EmployeePosition
                {
                    Id = 1,
                    Name = "Coach",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
                new EmployeePosition
                {
                    Id = 2,
                    Name = "Assistant-Coach",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
                new EmployeePosition
                {
                    Id = 3,
                    Name = "Goalkeeper-Coach",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
                new EmployeePosition
                {
                    Id = 4,
                    Name = "Economist",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },

            }) ;
        }
    }
}
