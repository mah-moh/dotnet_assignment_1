using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_1_webapi.Entities.Validators
{
    public class IsYearAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (!IsYear((string) value))
            {
                return new ValidationResult("Invalid year format. Expected format: XXXX");
            }
            return ValidationResult.Success;
        }

        private static bool IsYear(string year)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(year, @"^\d{4}");
        }
    }
}