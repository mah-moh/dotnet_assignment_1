using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using assignment_1_webapi.Entities.Validators;

namespace assignment_1_webapi.Entities;

public class CourseModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? Id { get; set; }
    [IsCourseID]
    public string? CourseId { get; set; }
    public string? CourseName { get; set; }
    public string? InstructorName { get; set; }
    public int? NumberOfCredits { get; set; }
}