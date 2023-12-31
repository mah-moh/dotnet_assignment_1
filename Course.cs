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
                if (DataValidator.IsCourseId(value))
                {
                    courseId = value;
                }
                else
                {
                    throw new ArgumentException("Invalid input format [XXX YYY]");
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