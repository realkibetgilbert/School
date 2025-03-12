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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Hostel>().HasData(
            new Hostel { Id = 1, Name = "Alpha Hostel", Description = "A boys hostel near the main block", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 2, Name = "Beta Hostel", Description = "A girls hostel with modern facilities", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 3, Name = "Gamma Hostel", Description = "A hostel for senior students", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 4, Name = "Delta Hostel", Description = "A new hostel with high security", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 5, Name = "Epsilon Hostel", Description = "Spacious hostel with a gym facility", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 6, Name = "Zeta Hostel", Description = "Affordable accommodation for students", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 7, Name = "Eta Hostel", Description = "Premium hostel for postgraduate students", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 8, Name = "Theta Hostel", Description = "Hostel with attached cafeteria", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 9, Name = "Iota Hostel", Description = "Hostel with a large study hall", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 10, Name = "Kappa Hostel", Description = "A quiet place for research students", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 11, Name = "Lambda Hostel", Description = "Hostel with a rooftop relaxation area", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 12, Name = "Mu Hostel", Description = "Affordable hostel near the sports complex", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 13, Name = "Nu Hostel", Description = "Hostel with 24/7 medical assistance", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 14, Name = "Xi Hostel", Description = "An eco-friendly hostel with solar power", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 15, Name = "Omicron Hostel", Description = "A centrally located hostel for all", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 16, Name = "Pi Hostel", Description = "Hostel with a dedicated tech lab", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 17, Name = "Rho Hostel", Description = "A well-ventilated and green hostel", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 18, Name = "Sigma Hostel", Description = "Hostel with extra co-curricular facilities", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 19, Name = "Tau Hostel", Description = "Hostel with a library and digital lab", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" },
            new Hostel { Id = 20, Name = "Upsilon Hostel", Description = "A newly built hostel with modern amenities", CreatedOn = DateTime.UtcNow, CreatedBy = "Admin", ModifiedOn = DateTime.UtcNow, ModifiedBy = "Admin" }
        );
        }


    }
}
