

using System.ComponentModel.DataAnnotations;
using assignment_1_webapi.Entities;

namespace assignment_1_webapi.DTOs
{
    public class CreateStudentDto
    {
        private string? firstName;
        private string? middleName;
        private string? lastName;

        [Required]
        public string? FirstName 
        { 
            get { return firstName; }
            set { firstName = MakeFirstCharUpper(value); }
        }


        public string? MiddleName 
        { 
            get { return middleName; }
            set { middleName = MakeFirstCharUpper(value); }
        }

        [Required]
        public string? LastName {
            get { return lastName; }
            set { lastName = MakeFirstCharUpper(value); }
        }

        [Required]
        [IsValidStudentID]
        public string StudentID { get; set; }

        public string? JoiningBatch { get; set; }

        public Degree degree { get; set; }

        public Department department { get; set; }
        
        private string MakeFirstCharUpper(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                value = char.ToUpper(value[0]) + value.Substring(1);
            }
            return value;
        }
    }
}