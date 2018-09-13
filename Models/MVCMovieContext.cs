using Microsoft.EntityFrameworkCore;

namespace MVCMovie.Models
{
    public class MVCMovieContext : DbContext
    {
        public MVCMovieContext(DbContextOptions<MVCMovieContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
