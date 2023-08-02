using checkpoint.Models;
using Microsoft.EntityFrameworkCore;

namespace checkpoint.Data
{
    public class CheckpointDbContext : DbContext 
    {

        public CheckpointDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

    }
}
