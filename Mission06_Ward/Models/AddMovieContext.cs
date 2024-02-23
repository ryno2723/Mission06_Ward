using Microsoft.EntityFrameworkCore;

namespace Mission06_Ward.Models
{
    public class AddMovieContext : DbContext
    {
        public AddMovieContext(DbContextOptions<AddMovieContext> options) : base (options) //Constructor
        { 
        }

        public DbSet<Application> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
