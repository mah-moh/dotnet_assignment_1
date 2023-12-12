using assignment_1_webapi.Entities;
using Microsoft.EntityFrameworkCore;

namespace assignment_1_webapi.Data;

public class ApplicationDbContext : DbContext
{
    DbSet<StudentModel> studentModels { get; set; }
    public  DbSet<CourseModel> courseModels { get; set; }
    DbSet<SemesterModel> semesterModels { get; set; }
    public IConfiguration Configuration { get; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SemesterModel>()
            .HasKey(semester => semester.SemesterCode); // Define primary key
        // Other configurations...

        modelBuilder.Entity<StudentModel>()
            .HasKey(student => student.StudentID);
    }
}