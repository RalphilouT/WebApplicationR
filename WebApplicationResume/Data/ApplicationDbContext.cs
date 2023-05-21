
using WebApplicationResume.Models;
using Microsoft.EntityFrameworkCore;
using WebApplicationResume.Controllers;

namespace WebApplicationResume.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //pass context to base class (DbContext)
        {

        }
        public DbSet<Project> Project { get; set; }
        public DbSet<Education> Education { get; set; }

        public DbSet<Contact> Contact { get; set; }

    }
}
