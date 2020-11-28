using FootballSchoolMS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Configuration
{
  public  class PlayerConfiguration : BaseEntityConfiguration<Player>
    {
        public override void Configure(EntityTypeBuilder<Player> builder)
        {
            base.Configure(builder);
            builder.Property(b => b.Name).IsRequired();
            builder.Property(b => b.LastName).IsRequired();
            builder.Property(b => b.UniqueId).IsRequired().HasMaxLength(4);
            builder.Property(b => b.BirthDate).IsRequired();
            builder.Property(b => b.Telephone).IsRequired();
            builder.Property(b => b.Email).IsRequired();

            builder.HasOne(b => b.Group).WithMany(b => b.Players).HasForeignKey(builder => builder.GroupID);


            builder.HasData(new List<Player> {
                new Player
                {
                    Id = 1,
                    Name = "Husein",
                    LastName = "Muftic",
                    UniqueId = 0000,
                    BirthDate = new DateTime(1998,10,27),
                    Telephone = 123123123,
                    Email = "hmuftic@hotmail.com",
                    GroupID = 1,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
                new Player
                {
                    Id = 2,
                    Name = "Edin",
                    LastName = "Muftic",
                    UniqueId = 0000,
                    BirthDate = new DateTime(1978,10,27),
                    Telephone = 123123123,
                    Email = "hmuftic@hotmail.com",
                    GroupID = 2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
                new Player
                {
                    Id = 3,
                    Name = "Adin",
                    LastName = "Halilovic",
                    UniqueId = 0000,
                    BirthDate = new DateTime(1978,10,27),
                    Telephone = 123123123,
                    Email = "hmuftic@hotmail.com",
                    GroupID = 3,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                }, 
                new Player
                {
                    Id = 4,
                    Name = "Adi",
                    LastName = "Halilovic",
                    UniqueId = 0000,
                    BirthDate = new DateTime(1978,10,27),
                    Telephone = 123123123,
                    Email = "hmuftic@hotmail.com",
                    GroupID = 2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "hmuftic"
                },
            });
        }
    }
}
