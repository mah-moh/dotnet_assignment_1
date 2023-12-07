namespace assignment_1_webapi.Models;

public class CourseModel
{
    public int Id { get; set; }
    [IsValidStudentID]
    public string? CourseId { get; set; }
    public string? CourseName { get; set; }
    public string? InstructorName { get; set; }
    public int? NumberOfCredits { get; set; }
}