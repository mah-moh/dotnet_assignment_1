using Newtonsoft.Json;

namespace assignment_1_webapi.Models;
public class DataValidator
{
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