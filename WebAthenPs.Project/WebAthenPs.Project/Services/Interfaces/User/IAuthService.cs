using WebAthenPs.Models.DTOs.User;

namespace WebAthenPs.Project.Services.Interfaces.User
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);
        Task<string?> Register(RegisterModel registerModel);
        Task Logout();
    }
}
