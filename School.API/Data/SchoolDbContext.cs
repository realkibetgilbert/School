using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using School.MODEL;

namespace School.API.Data
{
    public class SchoolDbContext : IdentityDbContext<AuthUser, IdentityRole<long>, long>
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Unit> Units { get; set; }
        public DbSet<Hostel> Hostels { get; set; }
        

        
    }
}
