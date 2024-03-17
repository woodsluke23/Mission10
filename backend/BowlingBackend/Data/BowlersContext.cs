using Microsoft.EntityFrameworkCore;

namespace BowlingBackend.Data
{
    public class BowlersContext : DbContext 
    {
        public BowlersContext(DbContextOptions<BowlersContext> options) : base(options) { }

        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
