namespace AssignmentOne
{
    public enum SemesterCode{
        Fall = 1,
        Summer = 2,
        Spring = 3,
    }

    public class Semester
    {
        public string? Year { get; set; }

        public SemesterCode SemesterCode { get; set; }

        public HashSet<Course> courses = new HashSet<Course>();
    }
}