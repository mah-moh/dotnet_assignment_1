using Newtonsoft.Json;

namespace assignment_1_webapi.Models;
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
            StudentModel studentObject = JsonConvert.DeserializeObject<StudentModel>(student);
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










// using System.Reflection.Metadata.Ecma335;

// using Microsoft.AspNetCore.Http.HttpResults;

// namespace assignment_1_webapi.Models.Validators;

// public class StudentModelValidate
// {
//     private readonly StudentModel _studentModel;
//     public StudentModelValidate ( StudentModel studentModel)
//     {
//         _studentModel = studentModel;
//         Validate();
//     }
//     public static bool IsValidStudentID(string studentID)
//     {
//         return System.Text.RegularExpressions.Regex.IsMatch(studentID, @"^\d{3}-\d{3}-\d{3}$");
//     }

//     public void Validate()
//     {
//         if ( !IsValidStudentID(_studentModel.StudentID))
//         {
//             throw new ArgumentException("Invalid student id");
//         } 
//     }
// }