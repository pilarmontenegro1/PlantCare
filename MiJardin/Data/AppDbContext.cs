using Microsoft.EntityFrameworkCore;

namespace MiJardin.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<MiJardin.Models.Plant> Plant{ get; set; }
}


}

