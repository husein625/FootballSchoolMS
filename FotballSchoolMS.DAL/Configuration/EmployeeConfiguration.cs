using FootballSchoolMS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Configuration
{
   public class EmployeeConfiguration : BaseEntityConfiguration<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Name).IsRequired();
            builder.Property(b => b.LastName).IsRequired();
            builder.Property(b => b.Telephone).HasMaxLength(50);
            builder.Property(b => b.Email).IsRequired();

            builder.HasOne(b => b.EmployeePosition).WithMany(b => b.Employees).HasForeignKey(builder => builder.EmployeePositionID);
            builder.HasMany(b => b.Groups1).WithOne(b => b.Employee1).HasForeignKey(builder => builder.CoachID);
            builder.HasMany(b => b.Groups2).WithOne(b => b.Employee2).HasForeignKey(builder => builder.AssistantCoach1ID);
            builder.HasMany(b => b.Groups3).WithOne(b => b.Employee3).HasForeignKey(builder => builder.AssistantCoach2ID);

            builder.HasData(new List<Employee> {
            new Employee
            {
                Id = 1,
                Name = "Husein",
                LastName = "muftic",
                Telephone = 387435655,
                Email = "hmuftic@hotmail.com",
                EmployeePositionID = 1,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "hmuftic"
            },
            new Employee
            {
                Id = 2,
                Name = "Adin",
                LastName = "Saric",
                Telephone = 387435655,
                Email = "asaric@hotmail.com",
                EmployeePositionID = 2,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "hmuftic"
            }, 
            new Employee
            {
                Id = 3,
                Name = "Edin",
                LastName = "Halilovic",
                Telephone = 387435655,
                Email = "ehalilovic@hotmail.com",
                EmployeePositionID = 3,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "hmuftic"
            }
            });
        }
    }
}
