using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TodoApi.Data;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly TodoApiContext _context;
        private readonly IConfiguration _config;

        public LoginController(TodoApiContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpPost]
        public  IActionResult Login(LoginUser userLogin)
        {
            var user = Authenticate(userLogin);
            
            if (user != null)
            {
                //Creamos Token

                var token = Generate(user);

                return Ok(token);
            }

            return NotFound("Usuario o Contraseña incorrectos");
        }


        private Estudiante Authenticate(LoginUser user)
        {
            var estudiante = _context.Estudiante
                .FirstOrDefault(e => e.Name == user.UserName && e.Password == user.Password);

            if (estudiante != null)
            {
                return estudiante;
            }
            return null;
        }
        private string Generate(Estudiante user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim("name", user.Name),
                new Claim("idEstudiante",user.Id.ToString())
            };

            var token = new JwtSecurityToken(
                 _config["Jwt:Issuer"],
                 _config["Jwt:Audience"],
                 claims,
                 expires: DateTime.Now.AddMinutes(60),
                 signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
