using Microsoft.EntityFrameworkCore;
using School.API.Models;

namespace School.API.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Unit> Units { get; set; }
    }
}
