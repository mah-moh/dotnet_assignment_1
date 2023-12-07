using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Http.HttpResults;

namespace assignment_1_webapi.Models;

public class StudentModel
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

    [Required]
    public Department Department { get; set; }

    [Required]
    public Degree Degree { get; set; }

    public SemesterModel? Semester { get; set; }

    private string MakeFirstCharUpper(string value)
    {
        if (!string.IsNullOrEmpty(value))
        {
            value = char.ToUpper(value[0]) + value.Substring(1);
        }
        return value;
    }
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

public enum Department
{
    ComputerScience = 1,
    BBA,
    English,
}