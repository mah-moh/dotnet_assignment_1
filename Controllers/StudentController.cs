using Microsoft.AspNetCore.Mvc;

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

        [HttpGet("GetAll")]
        public IActionResult GetAll ()
        {
            return Ok(_service.GetAllStudents());
        }

        [HttpGet("Get")]
        public IActionResult Get ( string studentId )
        {
            return Ok(_service.GetStudentById(studentId));
        }
    }
}