namespace AssignmentOne
{
    public class Course
    {
        private string courseId;
        public int Id { get; set; }
        public string? CourseId 
        { 
            get
            {
                return courseId;
            } 
            set
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(value, @"^[A-Za-z]{3}\s\d{3}$"))
                {
                    courseId = value;
                }
                else
                {
                    throw new ArgumentException("Invalid input format [XXX YYYY]");
                }
            } 
        }
        public string? CourseName { get; set; }
        public string? InstructorName { get; set; }
        public int? NumberOfCredits { get; set; }

        public override string ToString()
        {
            return $"{Id}.\nCourse Id: {CourseId}\nCourse name: {CourseName}\nInstructor: {InstructorName}\nCredits: {NumberOfCredits}\n";
        }
    }

}