using System.ComponentModel.DataAnnotations;

namespace assignment_1_webapi.Entities;

public class IsValidStudentIDAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (!IsValidStudentID((string)value))
        {
            return new ValidationResult("Invalid Student ID format. Expected format: XXX-XXX-XXX");
        }
        return ValidationResult.Success;
    }

    private static bool IsValidStudentID(string studentID)
    {
        return System.Text.RegularExpressions.Regex.IsMatch(studentID, @"^\d{3}-\d{3}-\d{3}$");
    }
}