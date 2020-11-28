using FootballSchoolMS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Configuration
{
   public class PlayerMembershipFeeConfiguration : BaseEntityConfiguration<PlayerMembershipFee>
    {
        public override void Configure(EntityTypeBuilder<PlayerMembershipFee> builder)
        {
            base.Configure(builder);
            builder.HasOne(b => b.Player).WithMany(b => b.PlayerMembershipFees).HasForeignKey(builder => builder.PlayerID);
            builder.HasOne(b => b.MembershipFee).WithMany(b => b.PlayerMembershipFees).HasForeignKey(builder => builder.MembershipFeeID);


            builder.HasData(new List<PlayerMembershipFee> {
                new PlayerMembershipFee
                {
                    Id = 1,
                    CreatedAt = DateTime.UtcNow,
                    PlayerID = 1,
                    MembershipFeeID = 2,
                    CreatedBy = "hmuftic"
                }, 
                new PlayerMembershipFee
                {
                    Id = 2,
                    CreatedAt = DateTime.UtcNow,
                    PlayerID = 3,
                    MembershipFeeID = 1,
                    CreatedBy = "hmuftic"
                },
                new PlayerMembershipFee
                {
                    Id = 3,
                    CreatedAt = DateTime.UtcNow,
                    PlayerID = 4,
                    MembershipFeeID = 1,
                    CreatedBy = "hmuftic"
                }, new PlayerMembershipFee
                {
                    Id = 4,
                    CreatedAt = DateTime.UtcNow,
                    PlayerID = 2,
                    MembershipFeeID = 1,
                    CreatedBy = "hmuftic"
                },
            });
        }
    }
}
