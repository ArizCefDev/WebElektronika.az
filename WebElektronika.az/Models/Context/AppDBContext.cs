using Microsoft.EntityFrameworkCore;

namespace WebElektronika.az.Models.Context
{
    public class AppDBContext:DbContext
    {
        public DbSet<Technology> Technologies { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            :base(options)
        {
           
        }
    }
}
