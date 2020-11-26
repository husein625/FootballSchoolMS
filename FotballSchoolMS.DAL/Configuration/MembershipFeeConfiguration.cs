using FootballSchoolMS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Configuration
{
   public class MembershipFeeConfiguration : BaseEntityConfiguration<MembershipFee>
    {
        public override void Configure(EntityTypeBuilder<MembershipFee> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Name).IsRequired();
            builder.Property(b => b.Amount).IsRequired();

            builder.HasData(new List<MembershipFee> {
                new MembershipFee
                {
                    Id = 1,
                    Name = "MembershipFee1",
                    Amount = 50,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
                new MembershipFee
                {
                    Id = 2,
                    Name = "MembershipFee2",
                    Amount = 60,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
                new MembershipFee
                {
                    Id = 3,
                    Name = "MembershipFee2",
                    Amount = 40,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                }
            });
        }
    }
}
