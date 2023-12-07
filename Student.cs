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
        private string? firstName;
        private string? middleName;
        private string? lastName;

        public string? FirstName { 
            get { return firstName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    firstName = char.ToUpper(value[0]) + value.Substring(1);
                }
            }
        }
        public string? MiddleName 
        { 
            get { return middleName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    middleName = char.ToUpper(value[0]) + value.Substring(1);
                }
            }
        }
        public string? LastName {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    lastName = char.ToUpper(value[0]) + value.Substring(1);
                }
            }
        }
        public string? StudentID
        {
            get { return studentID; }
            set 
            {
                if (!DataValidator.IsValidStudentID(value))
                {
                    throw new ArgumentException("Invalid Student ID format. Expected format: XXX-XXX-XXX");
                }
                studentID = value;
            }
        }

        public string? JoiningBatch { get; set; }
        public Department Department { get; set; }
        public Degree Degree { get; set; }

        public Semester? Semester { get; set; }

        public void ToString()
        {
            Console.Clear();

            Console.WriteLine("==========Student's details===========\n");
            Console.WriteLine($"First name: {FirstName}");
            Console.WriteLine($"Middle name: {MiddleName}");
            Console.WriteLine($"Last name: {LastName}");
            Console.WriteLine($"Student ID: {StudentID}");
            Console.WriteLine($"Joining Batch: {JoiningBatch}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Degree: {Degree}");

            if (Semester != null)
            {
                Console.Write($"Semester: {Semester.SemesterCode}     ");
                Console.WriteLine(Semester.Year);

                Console.WriteLine("Courses: \n");

                foreach( var course in Semester.courses)
                {
                    Console.Write($"{course.CourseId}   ");
                    Console.WriteLine(course.CourseName);
                }
            }
            

            Console.WriteLine();
            Console.WriteLine("Press any key to return.");
            Console.ReadKey();
        }
    }
}
