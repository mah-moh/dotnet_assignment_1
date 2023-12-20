using assignment_1_webapi.Data;
using assignment_1_webapi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CourseController ( ApplicationDbContext context )
        {
            _context = context;
        }

        [HttpPost("Add")]
        public IActionResult Add( [FromBody] CourseModel course )
        {
            _context.courseModels.Add(course);
            _context.SaveChanges();

            return Ok("course added.");
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var data = _context.courseModels.ToList();
            return Ok(data);
        }
    }
}