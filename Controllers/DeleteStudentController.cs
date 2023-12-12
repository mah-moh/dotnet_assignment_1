using Microsoft.AspNetCore.Mvc;

namespace assignment_1_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeleteStudentController : ControllerBase
    {
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("deleted.");
        }
    }
}