using Microsoft.AspNetCore.Mvc;

using assignment_1_webapi.DTOs;
using assignment_1_webapi.Entities;
using assignment_1_webapi.Services;
using Microsoft.AspNetCore.Authorization;

namespace assignment_1_webapi.Controllers
{
    [ApiController]
    [Authorize]
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

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var semesterCode = Enum.GetValues(typeof(SemesterCode))
                        .Cast<SemesterCode>()
                        .Select((value, _) => new EnumDto
                        {
                            Index = (int)value,
                            Value = value.ToString()
                        })
                        .ToList();
    
            return Ok(semesterCode);
        }
    }
}