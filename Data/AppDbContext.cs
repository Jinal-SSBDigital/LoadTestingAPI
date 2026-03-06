using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Common;

namespace LoadTestingAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        public DbSet<StudentResultEntity> FinalPublishedResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentResultEntity>().ToTable("EXAM_FinalPublishedResult").HasNoKey();
        }
    }
}
