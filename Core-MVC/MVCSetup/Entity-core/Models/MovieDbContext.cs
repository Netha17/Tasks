using Microsoft.EntityFrameworkCore;
namespace Entity_core.Models
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get;set; }

        
    }
}
