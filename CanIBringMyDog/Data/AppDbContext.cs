using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    //Inom krokodilen anges vilken datatyp som används(Model) därefter namn på tabellen
    public DbSet<DogFriendlyPlace> DogFriendlyPlaces { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure additional properties of DogFriendlyPlace if needed
    }
}
