using FileHandler.Models;
using Microsoft.EntityFrameworkCore;

namespace FileHandler.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<FileDetail> FileDetails { get; set; }
    }
}
