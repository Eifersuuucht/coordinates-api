using CoordinatesApi.Data.Entities;
using CoordinatesApi.Data.Helpers;
using Microsoft.EntityFrameworkCore;

namespace CoordinatesApi.Data.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Rectangle> Rectangles => Set<Rectangle>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {   
        modelBuilder.Entity<Rectangle>()
            .HasKey(r => r.Id);

        modelBuilder.Entity<Rectangle>()
            .Property(r => r.Id)
            .ValueGeneratedOnAdd();
        
        modelBuilder.Entity<Rectangle>().HasData(SeedHelper.GetSeededRectangles());
    }
}