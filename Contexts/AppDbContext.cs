using Microsoft.EntityFrameworkCore;
using MoviesApi.Models.Movies.Entities;

namespace MoviesApi.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}
