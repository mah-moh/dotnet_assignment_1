using Microsoft.AspNetCore.Mvc;

using assignment_1_webapi.Data;


namespace assignment_1_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetCoursesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public GetCoursesController( ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _context.courseModels.ToList();
            return Ok(data);
        }
    }
}