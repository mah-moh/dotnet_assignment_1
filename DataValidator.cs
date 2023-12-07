using Newtonsoft.Json;

namespace AssignmentOne
{
    public class DataValidator
    {
        public static bool IsYear(string year)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(year, @"^\d{4}");
        }

        public static bool IsValidStudentID(string studentID)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(studentID, @"^\d{3}-\d{3}-\d{3}$");
        }

        public static bool IsStudent(string studentId, List<string> StudentList)
        {
            foreach(string student in StudentList)
            {
                Student studentObject = JsonConvert.DeserializeObject<Student>(student);
                if (studentId == studentObject.StudentID)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsCourseId(string courseId)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(courseId, @"^[A-Za-z]{3}\s\d{3}$");
        }
    }
}