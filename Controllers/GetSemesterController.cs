
using assignment_1_webapi.DTOs;
using assignment_1_webapi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace assignment_1_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetSemesterController : ControllerBase
    {
        [HttpGet]

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
        