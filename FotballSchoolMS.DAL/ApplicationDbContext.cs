using FotballSchoolMS.DAL.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace FotballSchoolMS.DAL
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }




        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new CompetitionTypeConfiguration());
            builder.ApplyConfiguration(new CompetitionConfiguration());
            builder.ApplyConfiguration(new EmployeeConfiguration());
            builder.ApplyConfiguration(new EmployeePositionConfiguration());
            builder.ApplyConfiguration(new GroupConfiguration());
            builder.ApplyConfiguration(new MembershipFeeConfiguration());




            base.OnModelCreating(builder);
        }
    }
}
