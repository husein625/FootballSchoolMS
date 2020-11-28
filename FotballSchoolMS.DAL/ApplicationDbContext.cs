using FootballSchoolMS.Models;
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

        public DbSet<Competition> Competitions { get; set; }
        public DbSet<CompetitionType> CompetitionTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeePosition> EmployeePositions { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<MembershipFee> MembershipFees { get; set; }
        public DbSet<Opponent> Opponents { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerMembershipFee> PlayerMembershipFees { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<TrainingsPresence> TrainingsPresences { get; set; }
        public DbSet<TrainingType> TrainingTypes { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new CompetitionTypeConfiguration());
            builder.ApplyConfiguration(new CompetitionConfiguration());
            builder.ApplyConfiguration(new EmployeeConfiguration());
            builder.ApplyConfiguration(new EmployeePositionConfiguration());
            builder.ApplyConfiguration(new GroupConfiguration());
            builder.ApplyConfiguration(new MembershipFeeConfiguration());
            builder.ApplyConfiguration(new PlayerConfiguration());
            builder.ApplyConfiguration(new PlayerMembershipFeeConfiguration());
            builder.ApplyConfiguration(new SeasonConfiguration());
            builder.ApplyConfiguration(new StadiumConfiguration());
            builder.ApplyConfiguration(new TrainingConfiguration());
            builder.ApplyConfiguration(new TrainingsPresenceConfiguration());
            builder.ApplyConfiguration(new TrainingTypeConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
