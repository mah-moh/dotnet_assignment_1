using Microsoft.AspNetCore.Mvc;

namespace assignment_1_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetStudentController : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok("get");
        }

        [HttpGet("{studentId}")]
        public IActionResult GetByStudentID(string studentId)
        {
            return Ok(studentId);
        }
    }
}