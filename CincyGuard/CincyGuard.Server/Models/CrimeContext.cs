using Microsoft.EntityFrameworkCore;

namespace CincyGuard.Server.Models
{
    public class CrimeContext : DbContext
    {
        public CrimeContext(DbContextOptions<CrimeContext> options) : base(options) { }

        public DbSet<CrimeIncident> Crimes {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
