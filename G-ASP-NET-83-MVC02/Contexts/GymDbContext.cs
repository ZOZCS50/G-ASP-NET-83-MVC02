using GymManagementSystemG02.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GymManagementSystemG02.Contexts
{
    public class GymDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = G_ASP_NET_83_MVC02; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Membership> Memberships { get; set; }
    }
}
