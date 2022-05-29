using Microsoft.EntityFrameworkCore;
using petrol_pricer_server.Models;

namespace petrol_pricer_server.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Station> Stations { get; set; }
        public DbSet<Prices> Prices { get; set; }
        public DbSet<Coords> Coords { get; set; }

        #pragma warning disable CS8618
        public DatabaseContext(DbContextOptions contextOptions) : base(contextOptions) 
        {
            
        }
        #pragma warning restore CS8618
    }
}
