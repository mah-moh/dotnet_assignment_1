using System.ComponentModel.DataAnnotations;

namespace assignment_1_webapi.Entities;

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

    [Key]
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

