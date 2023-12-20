using System.ComponentModel.DataAnnotations;

namespace assignment_1_webapi.Entities;

public class StudentModel
{
    public string? FirstName { get; set; }


    public string? MiddleName { get; set; }
    public string? LastName { get; set; }

    [Key]
    public string StudentID { get; set; }

    public string? JoiningBatch { get; set; }

    public Degree degree { get; set; }

    public Department department { get; set; }

    public ICollection<SemesterModel>? Semesters { get; set; }
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

