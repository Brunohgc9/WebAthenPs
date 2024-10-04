using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using WebAthenPs.Models.DTOs.User;

namespace WebAthenPs.API.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;

        public UsersController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _context = context;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            if (model == null || string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Password))
            {
                return BadRequest("Email and password are required.");
            }

            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                Role = model.Role,
                UserType = model.UserType,
                CPF = model.CPF,
                RG = model.RG,
                Gender = model.Gender,
                Address = model.Address,
                City = model.City,
                State = model.State,
                PostalCode = model.PostalCode
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return Ok(new RegisterResult { UserId = user.Id });
            }

            return BadRequest(new { result.Errors });
        }

        [HttpPost("Login")]
        public async Task<ActionResult<UserToken>> Login([FromBody] LoginModel userInfo)
        {
            if (userInfo == null || string.IsNullOrEmpty(userInfo.Email) || string.IsNullOrEmpty(userInfo.Password))
            {
                return BadRequest("Email e senha são obrigatórios.");
            }

            var user = await _userManager.FindByEmailAsync(userInfo.Email);
            if (user == null)
            {
                return BadRequest("Usuário não encontrado.");
            }

            var result = await _signInManager.PasswordSignInAsync(userInfo.Email, userInfo.Password, isPersistent: true, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                var token = BuildToken(userInfo, user.Id);
                return Ok(token);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Login inválido.");
                return BadRequest(ModelState);
            }
        }

        private UserToken BuildToken(LoginModel userInfo, string userId)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId),
                new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var expiration = DateTime.UtcNow.AddHours(2);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: expiration,
                signingCredentials: creds);

            return new UserToken
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                TokenExpiration = expiration,
                UserId = userId
            };
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<ApplicationUser>> GetUserInfo(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound("Usuário não encontrado.");
            }

            // Retorna o objeto ApplicationUser
            return Ok(new ApplicationUser
            {
                UserName = user.UserName,
                Email = user.Email,
                Role = user.Role,
                UserType = user.UserType,
                CPF = user.CPF,
                RG = user.RG,
                Gender = user.Gender,
                Address = user.Address,
                City = user.City,
                State = user.State,
                PostalCode = user.PostalCode
            });
        }
    }
}
