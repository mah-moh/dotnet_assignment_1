using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using assignment_1_webapi.Entities.Validators;

namespace assignment_1_webapi.Entities;

public class SemesterModel
{
    
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int SemesterId { get; set; }
    [IsYear]
    public string? Year { get; set; }

    public SemesterCode SemesterCode { get; set; }
    [ForeignKey("StudentModel")]
    public string studentId { get; set; }
    public StudentModel? Student { get; set; }
}

public enum SemesterCode{
    Fall = 1,
    Summer = 2,
    Spring = 3,
}