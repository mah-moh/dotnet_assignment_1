using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_1_webapi.Models.Validators
{
    public class IsCourseIDAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (!IsCourseId((string) value))
            {
                return new ValidationResult("Invalid course id. Expected format: XXX YYY");
            }
            return ValidationResult.Success;
        }
        private static bool IsCourseId(string courseId)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(courseId, @"^[A-Za-z]{3}\s\d{3}$");
        }
    }
}

    