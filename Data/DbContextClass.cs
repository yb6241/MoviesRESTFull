using Microsoft.EntityFrameworkCore;
using MoviesRESTFull.Models;

namespace MoviesRESTFull.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
