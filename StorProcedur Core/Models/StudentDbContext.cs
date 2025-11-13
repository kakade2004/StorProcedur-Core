using Microsoft.EntityFrameworkCore;

namespace StorProcedur_Core.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<StudentRecord> studentRecords { get; set; }

        public DbSet<District> district { get; set; }

        public DbSet<Taluka> talukas { get; set; }
        public DbSet<Village> village { get; set; }

    }
}
