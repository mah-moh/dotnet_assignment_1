using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;


namespace AssignmentOne
{

    public enum Department
    {
        ComputerScience = 1,
        BBA,
        English,
    }

    public enum Degree
    {
        BSC = 1,
        BBA, 
        BA, 
        MSC, 
        MBA, 
        MA
    }
    public class Student
    {

        private string? studentID;

        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? StudentID
        {
            get { return studentID; }
            set 
            {
                if (!IsValidStudentID(value))
                {
                    throw new ArgumentException("Invalid Student ID format. Expected format: XXX-XXX-XXX");
                }
                studentID = value;
            }
        }

        public string? JoiningBatch { get; set; }
        public Department Department { get; set; }
        public Degree Degree { get; set; }

        

        public void ShowById(String studentID)
        {
            foreach(string student in Program.StudentList)
            {
                var student1 = JsonConvert.DeserializeObject(student);
                Console.WriteLine(student1);
                
            }
        }

        private bool IsValidStudentID(string studentID)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(studentID, @"^\d{3}-\d{3}-\d{3}$");
        }
    }
}
