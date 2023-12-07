using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using assignment_1_webapi.Models;

namespace assignment_1_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddStudentController : ControllerBase
    {
        [HttpPost]
        public IActionResult Add([FromBody] StudentModel newStudent)
        {
            if (!ModelState.IsValid) 
            {
                return ValidationProblem(ModelState);
            }
            
            return Ok("Student added");
        }
    }
}