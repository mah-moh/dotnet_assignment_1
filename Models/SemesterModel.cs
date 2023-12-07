using assignment_1_webapi.Models.Validators;

namespace assignment_1_webapi.Models;

public class SemesterModel
{
    [IsYear]
    public string? Year { get; set; }

    public SemesterCode SemesterCode { get; set; }

    public HashSet<CourseModel> courses = new HashSet<CourseModel>();
}

public enum SemesterCode{
    Fall = 1,
    Summer = 2,
    Spring = 3,
}