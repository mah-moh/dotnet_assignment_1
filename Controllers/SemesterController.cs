using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment_1_webapi.Data;
using assignment_1_webapi.DTOs;
using assignment_1_webapi.Entities;
using assignment_1_webapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SemesterController : ControllerBase
    {
        private readonly ISemesterService _service;

        public SemesterController ( ISemesterService service )
        {
            _service = service;
        }

        [HttpPost("Add")]
        public IActionResult Add ([FromBody] SemesterAddDto semester)
        {   
            _service.AddSemester(semester);

            return Ok("Semester added.");
        }
    }
}