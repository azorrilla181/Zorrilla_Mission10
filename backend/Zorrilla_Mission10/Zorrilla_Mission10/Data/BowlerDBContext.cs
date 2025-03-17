using Microsoft.EntityFrameworkCore;

namespace Zorrilla_Mission10.Data
{
    public class BowlerDBContext : DbContext
    {
        public BowlerDBContext(DbContextOptions<BowlerDBContext> options) : base(options)
        {   
        }
        public DbSet<BowlerCLass> Bowlers { get; set; }
        public DbSet<TeamsClass> Teams { get; set; }


    }
}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TeamsClass>().HasData(
        //    new TeamsClass { TeamID = 1, TeamName = "Marlins" },
        //    new TeamsClass { TeamID = 2, TeamName = "Sharks" },
        //    new TeamsClass { TeamID = 3, TeamName = "Terrapins" },
        //    new TeamsClass { TeamID = 4, TeamName = "Barracudas" },
        //    new TeamsClass { TeamID = 5, TeamName = "Dolphins" },
        //    new TeamsClass { TeamID = 6, TeamName = "Orcas" },
        //    new TeamsClass { TeamID = 7, TeamName = "Manatees" },
        //    new TeamsClass { TeamID = 8, TeamName = "Swordfish" },
        //    new TeamsClass { TeamID = 9, TeamName = "Huckleberrys" },
        //    new TeamsClass { TeamID = 10, TeamName = "MintJuleps" }
        //        );
        //}
