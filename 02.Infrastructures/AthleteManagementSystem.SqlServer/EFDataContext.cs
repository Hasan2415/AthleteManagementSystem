using AthleteManagementSystem.Domain.Athletes.Entities;
using Microsoft.EntityFrameworkCore;

namespace AthleteManagementSystem.SqlServer
{
    public class EFDataContext : DbContext
    {
        public EFDataContext(
            DbContextOptions<EFDataContext> options) : base(options)
        {

        }

        public DbSet<Athlete> Athletes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EFDataContext).Assembly);
        }
    }
}
