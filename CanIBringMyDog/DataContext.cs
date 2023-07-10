using CanIBringMyDog.Models;
using Microsoft.EntityFrameworkCore;

namespace CanIBringMyDog
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        //Inom krokodilen anges vilken datatyp som används(Model) därefter namn på tabellen
        public DbSet<DogFriendlyPlace> DogFriendlyPlaces { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure additional properties of DogFriendlyPlace if needed
        }
    }
}