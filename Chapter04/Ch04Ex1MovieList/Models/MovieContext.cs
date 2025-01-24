//Adds Entity Framework Core to the class to inherit the DbContext class to communicate with the database
using Microsoft.EntityFrameworkCore;

namespace Ch04Ex1MovieList.Models
{
    public class MovieContext : DbContext
    {
        // The DbContextOptions class provides configuration information to the DbContext class
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        // EF Core uses DbSet properties like this one to generate database tables with the specified names.
        public DbSet<Movie> Movies { get; set; } = null!;

        public override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                    new Movie
                    {
                        MovieId = 1,
                        Name = "Casablanca",
                        Year = 1942,
                        Rating = 5
                    },

                    new Movie
                    {
                        MovieId = 2,
                        Name = "Wonder Woman",
                        Year = 2017,
                        Rating = 3
                    },

                    new Movie
                    {
                        MovieId = 3,
                        Name = "Moonstruck",
                        Year = 1988,
                        Rating = 4
                    }
                );
        }
    }
}
