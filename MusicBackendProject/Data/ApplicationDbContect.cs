using Microsoft.EntityFrameworkCore;
using MusicBackendProject.Model;

namespace MusicBackendProject.Data
{
    public class ApplicationDbContect
    {
        public class ApplicationDbContext : DbContext
        {
            public DbSet<Song> Songs { get; set; }
            public ApplicationDbContext(DbContextOptions options) : base(options)
            {

            }
        }
    }
}
