using fiorelloMVC.Modals;
using Microsoft.EntityFrameworkCore;

namespace fiorelloMVC.DataContext;

public class FiorellaDbContext : DbContext
{
    public FiorellaDbContext(DbContextOptions<FiorellaDbContext> options) : base(options)
    { 
    
    }
    public DbSet<Catagory> Catagories { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Image> Images { get; set; }
}
