using Microsoft.EntityFrameworkCore;

namespace Review.Models;

// context file is the liaison to the database
public class MusicDbContext : DbContext
{
    // constructor, called one time when the class is instantiated
    public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options) // inherit from base(options)
    {
        
    }
    
    public DbSet<Artist> Artists { get; set; } // Name of the table in the database
    public DbSet<Album> Albums { get; set; }
}