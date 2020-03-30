using Microsoft.EntityFrameworkCore;

namespace TheSma.WebApi.Models
{
    public class SchoolDbContext: DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Stream> Stream { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentParent>().HasKey(p => new { p.StudentId, p.ParentId });

            modelBuilder.Entity<StudentParent>().HasOne(pt => pt.Student).WithMany(p => p.StudentParents).HasForeignKey(p => p.StudentId);
            modelBuilder.Entity<StudentParent>().HasOne(pt => pt.Parent).WithMany(p => p.StudentParents).HasForeignKey(p => p.ParentId);
        }
    }
}
