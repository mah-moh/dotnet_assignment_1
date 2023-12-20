using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment_1_webapi.Entities;
using assignment_1_webapi.Entities.Validators;

namespace assignment_1_webapi.DTOs
{
    public class SemesterAddDto
    {
        [IsYear]
        public string? Year { get; set; }
        public SemesterCode SemesterCode { get; set; }
        [IsValidStudentID]
        public string studentId { get; set; }
    }
}