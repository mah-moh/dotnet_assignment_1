namespace assignment_1_webapi.Models;

public class StudentModel
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

    public SemesterModel? Semester { get; set; }
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