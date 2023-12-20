using System.IdentityModel.Tokens.Jwt;
using System.Text;

using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace assignment_1_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JwtAuthenticationController : ControllerBase
    {
        private readonly IConfiguration _config;

        public JwtAuthenticationController( IConfiguration config )
        {
            _config = config;
        }
        [HttpGet]
        public IActionResult Authenticate()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var Sectoken = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                null,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            var token =  new JwtSecurityTokenHandler().WriteToken(Sectoken);

            return Ok(token);
        }
        
    }
}