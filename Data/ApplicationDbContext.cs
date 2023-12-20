using assignment_1_webapi.Entities;
using Microsoft.EntityFrameworkCore;

namespace assignment_1_webapi.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<StudentModel> studentModels { get; set; }
    public  DbSet<CourseModel> courseModels { get; set; }
    public DbSet<SemesterModel> semesterModels { get; set; }
    public DbSet<SemesterCoursesModel> semesterCoursesModels { get; set; }
    public IConfiguration Configuration { get; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentModel>()
            .HasIndex(student => student.StudentID).IsUnique();
    }
}