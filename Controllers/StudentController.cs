using Microsoft.AspNetCore.Mvc;

using assignment_1_webapi.DTOs;
using assignment_1_webapi.Services;
using assignment_1_webapi.Entities;

namespace assignment_1_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController ( IStudentService service)
        {
            _service = service;
        }

        [HttpPost("Add")]
        public IActionResult Add ([FromBody] StudentModel newStudent)
        {
            if (!ModelState.IsValid) 
            {
                return ValidationProblem(ModelState);
            }

            _service.CreateStudent(newStudent);
            
            return Ok("Student added");
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(string studentId)
        {
            _service.DeleteStudent(studentId);
            return Ok("Successfully deleted.");
        }

        // [HttpGet]
        // public IActionResult GetAll ()
        // {
        //     throw new Exception();
        // }

        // public IActionResult Get ( string studentId )
        // {
        //     throw new Exception();
        // }
    }
}