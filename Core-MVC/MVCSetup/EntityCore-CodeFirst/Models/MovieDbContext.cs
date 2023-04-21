using Microsoft.EntityFrameworkCore;
namespace EntityCore_CodeFirst.Models

{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
    : base(options)
        { }
        public DbSet<Movie> Movies { get;set; }
    }
}
