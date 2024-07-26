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

namespace WebAthenPs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<UserToken>> CreateUser([FromBody] User model)
        {
            var user = new ApplicationUser { UserName = model.TryEmail, Email = model.TryEmail };
            var result = await _userManager.CreateAsync(user, model.TryPassword);

            if (result.Succeeded)
            {
                return Ok(BuildToken(user));
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpPost("Login")]
        public async Task<ActionResult<UserToken>> Login([FromBody] User userInfo)
        {
            var user = await _userManager.FindByEmailAsync(userInfo.TryEmail);
            if (user == null)
            {
                return BadRequest("Usuário não encontrado. Verifique o e-mail fornecido.");
            }

            // Verifica se o email do usuário foi confirmado
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                return BadRequest("Login não permitido. O e-mail não foi confirmado.");
            }

            // Tenta realizar o login
            var result = await _signInManager.PasswordSignInAsync(userInfo.TryEmail, userInfo.TryPassword, isPersistent: false, lockoutOnFailure: false);

            // Verifica o resultado do login e retorna uma resposta apropriada
            if (result.Succeeded)
            {
                return Ok(BuildToken(user));
            }
            else if (result.IsLockedOut)
            {
                return BadRequest("Usuário bloqueado. O usuário excedeu o número máximo de tentativas de login e está temporariamente bloqueado. Tente novamente mais tarde.");
            }
            else if (result.IsNotAllowed)
            {
                // Caso o login não seja permitido, verificar se é por causa da confirmação do e-mail
                return BadRequest("Login não permitido. O usuário pode estar com o e-mail não confirmado ou pode haver restrições adicionais.");
            }
            else if (result.RequiresTwoFactor)
            {
                return BadRequest("Requer autenticação de dois fatores. O login requer uma segunda etapa de autenticação. Verifique seu método de autenticação de dois fatores.");
            }
            else if (result.IsLockedOut)
            {
                return BadRequest("Usuário bloqueado devido a múltiplas tentativas de login falhadas. Aguarde o desbloqueio ou entre em contato com o suporte.");
            }
            else if (result.IsNotAllowed)
            {
                return BadRequest("Login não permitido. Verifique se há restrições específicas configuradas para esta conta.");
            }
            else if (!result.Succeeded)
            {
                return BadRequest("Credenciais inválidas. Verifique seu e-mail e senha e tente novamente.");
            }
            else
            {
                return BadRequest("Erro desconhecido ao tentar realizar o login. Tente novamente mais tarde.");
            }
        }

        private UserToken BuildToken(ApplicationUser user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, user.Email),
                new Claim(JwtRegisteredClaimNames.Aud, _configuration["Jwt:Audience"]),
                new Claim(JwtRegisteredClaimNames.Iss, _configuration["Jwt:Issuer"]),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var expiration = DateTime.UtcNow.AddHours(2);

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: null,
                audience: null,
                claims: claims,
                expires: expiration,
                signingCredentials: creds);

            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                TokenExpiration = expiration
            };
        }
    }
}
