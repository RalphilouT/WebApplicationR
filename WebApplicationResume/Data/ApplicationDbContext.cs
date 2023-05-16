
using WebApplicationResume.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationResume.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //pass context to base class (DbContext)
        {

        }
        public DbSet<Project> Categories { get; set; }

    }
}
