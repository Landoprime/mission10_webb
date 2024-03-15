using Microsoft.EntityFrameworkCore;

namespace mission10_backend.Data
{
    public class Mission10_Context : DbContext
    {
        public Mission10_Context(DbContextOptions<Mission10_Context> options) : base(options) { }

        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
    