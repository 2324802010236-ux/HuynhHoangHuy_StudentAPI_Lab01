using HuynhHoangHuy_StudentAPI_Lab01.Models;
using Microsoft.EntityFrameworkCore;
using HuynhHoangHuy_StudentAPI_Lab01.Models;

namespace HuynhHoangHuy_StudentAPI_Lab01.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
                new Student { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" }
            );
        }

    }
}
