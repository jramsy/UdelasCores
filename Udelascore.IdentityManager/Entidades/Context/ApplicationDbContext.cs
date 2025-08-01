using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Udelascore.IdentityManager.Entidades.Mapping;

namespace Udelascore.IdentityManager.Entidades.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<AspNetApplication> AspNetApplications { get; set; }
        public DbSet<AspNetMembership> AspNetMemberships { get; set; }
        public DbSet<AspNetProfile> AspNetProfiles { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AspNetApplicationMap());
            builder.ApplyConfiguration(new AspNetMembershipMap());
            builder.ApplyConfiguration(new AspNetProfileMap());
            base.OnModelCreating(builder);
        }

    }
}
