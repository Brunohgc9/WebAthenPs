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
using WebAthenPs.Models.DTOs.User;

namespace WebAthenPs.API.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<Data.ApplicationUser> _userManager;
        private readonly SignInManager<Data.ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public UsersController(UserManager<Data.ApplicationUser> userManager,
            SignInManager<Data.ApplicationUser> signInManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        // Método de registro já existente
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            if (model == null || string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Password))
            {
                return BadRequest("Email and password are required.");
            }

            var user = new Data.ApplicationUser
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

        // Método para login já existente
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

        // Método para construir o token já existente
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

        // Método para retornar informações do usuário já existente
        [HttpGet("{userId}")]
        public async Task<ActionResult<Data.ApplicationUser>> GetUserInfo(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound("Usuário não encontrado.");
            }

            // Retorna o objeto ApplicationUser
            return base.Ok(new Data.ApplicationUser
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

        // Atualização de informações do usuário
        [HttpPut("UpdateUserInfo/{userId}")]
        public async Task<IActionResult> UpdateUserInfo(string userId, [FromBody] UpdateUserModel model)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound("Usuário não encontrado.");
            }

            // Atualiza os campos permitidos
            user.CPF = model.CPF;
            user.RG = model.RG;
            user.Gender = model.Gender;
            user.Address = model.Address;
            user.City = model.City;
            user.State = model.State;
            user.PostalCode = model.PostalCode;
            user.UserType = model.UserType;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return Ok("Informações do usuário atualizadas com sucesso.");
            }

            return BadRequest(result.Errors);
        }

        // Deletar conta do usuário
        [HttpDelete("DeleteAccount/{userId}")]
        public async Task<IActionResult> DeleteAccount(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound("Usuário não encontrado.");
            }

            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return Ok("Conta excluída com sucesso.");
            }

            return BadRequest(result.Errors);
        }

        // Retornar o tipo de usuário
        [HttpGet("GetUserType/{userId}")]
        public async Task<ActionResult<string>> GetUserTypeById(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound("Usuário não encontrado.");
            }

            return Ok(user.UserType);
        }
    }
}
