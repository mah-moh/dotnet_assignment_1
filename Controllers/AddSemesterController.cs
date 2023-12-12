using assignment_1_webapi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddSemesterController : ControllerBase
    {
        [HttpPost]
        public IActionResult Add([FromBody] SemesterModel semesterModel)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }
            return Ok("Semester added.");
        }
        
    }
}