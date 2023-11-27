﻿using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace AssignmentOne
{
    public class Program
    {

        public static List<string> StudentList = new List<string>();
        public static string ConvertToJson(Student student)
        {
            string Json = JsonConvert.SerializeObject(student);
            return Json;
        }


        public static void AddToList(Student student)
        {
            string json = ConvertToJson(student);
            StudentList.Add(json);
        }

        public static void AddStudent()
        {
            Console.Clear();
            Student student = new Student();

            Console.WriteLine("===============Add student===================");

            Console.WriteLine("Enter first name:");
            student.FirstName = Console.ReadLine();
            Console.WriteLine("Enter middle name:");
            student.MiddleName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            student.LastName = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter student id(Format: XXX-XXX-XXX)");
                    student.StudentID = Console.ReadLine();
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            Console.WriteLine("Enter student's joining batch:");
            student.JoiningBatch = Console.ReadLine();

            Console.WriteLine("1. Computer Science");
            Console.WriteLine("2. BBA");
            Console.WriteLine("3. English");



            while (true)
            {
                Console.WriteLine("Enter your choice:");
                int departmentChoice = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(Department), departmentChoice))
                {
                    student.Department = (Department)departmentChoice; break;
                }
                else
                {
                    Console.WriteLine("Invalid department option.");
                }
            }

            Console.WriteLine("1. BSc");
            Console.WriteLine("2. BBA");
            Console.WriteLine("3. BA");
            Console.WriteLine("4. MSc");
            Console.WriteLine("5. MBA");
            Console.WriteLine("6. MA");

            Console.WriteLine("Enter you degree:");

            while (true)
            {
                int DegreeInput = int.Parse(Console.ReadLine());
                if (Enum.IsDefined(typeof(Degree), DegreeInput))
                {
                    student.Degree = (Degree)DegreeInput; break;
                }
                else
                {
                    Console.WriteLine("Invalid options.");
                }
            }


            AddToList(student);
        }

        public static void DisplayById(string studentId)
        {
            
            foreach(string StudentJson in StudentList)
            {
                Student studentObject = JsonConvert.DeserializeObject<Student>(StudentJson);
                if (studentObject.StudentID == studentId)
                {
                    Console.Clear();
                    Console.WriteLine($"First name: {studentObject.FirstName}");
                    Console.WriteLine($"Middle name: {studentObject.MiddleName}");
                    Console.WriteLine($"Last name: {studentObject.LastName}");
                    Console.WriteLine($"Student ID: {studentObject.StudentID}");
                    Console.WriteLine($"Joining Batch: {studentObject.JoiningBatch}");
                    Console.WriteLine($"Department: {studentObject.Department}");
                    Console.WriteLine($"Degree: {studentObject.Degree}");

                    Console.WriteLine();
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    return;
                }
            }
            throw new ArgumentException("Invalid input.");
        }

        public static void DeleteStudent(string studentId)
        {
            foreach(string studentJson in StudentList)
            {
                Student studentObject = JsonConvert.DeserializeObject<Student>(studentJson);
                if (studentObject.StudentID == studentId)
                {
                    StudentList.Remove(studentJson);
                    Console.Clear();
                    Console.WriteLine("Succesfully deleted.\n Press any key to exit.");
                    Console.ReadKey();
                    return;
                }
            }
            throw new ArgumentException($"No student found by id: {studentId}");
        }
        
        static void Main(string[] args)
        {
            Student student1 = new Student{
                FirstName = "Maheen",
                MiddleName = "",
                LastName = "Chowdhury",
                StudentID = "123-456-789",
                JoiningBatch = "fall",
                Department = Department.ComputerScience,
                Degree = Degree.MSC,
            };

            AddToList(student1);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("0. Exit.");
                Console.WriteLine("1. Add student.");
                Console.WriteLine("2. Delete student.");
                Console.WriteLine("3. Show student's detail.");
                Console.WriteLine("===============================");
                Console.WriteLine();

                Console.WriteLine("Enter your choice:");

                StudentList.ForEach(student => Console.WriteLine(student));

                string? userInput = Console.ReadLine();
                

                if (int.TryParse(userInput, out int input))
                {
                    switch (input)
                    {
                        case 0:
                            Console.WriteLine("Exiting the program.");
                            return;
                        case 1:
                            AddStudent();
                            break;
                        case 2:
                            while (true)
                            {
                                Console.WriteLine("Enter student id:");
                                string studentId = Console.ReadLine();
                                try
                                {
                                    DeleteStudent(studentId); break;
                                }
                                catch(Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            break;
                        case 3:
                            while (true)
                            {
                                Console.WriteLine("Enter student id:");
                                string studentId = Console.ReadLine();
                                try
                                {
                                    DisplayById(studentId); break;
                                }
                                catch(Exception ex)
                                {

                                    Console.WriteLine(ex.Message);
                                }
                            }
                            break;
                    }
                }

                else
                {
                
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                }
            }

        }
    }

}