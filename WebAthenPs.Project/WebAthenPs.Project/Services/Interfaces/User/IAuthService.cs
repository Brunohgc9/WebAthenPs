using WebAthenPs.Models.DTOs.User;

namespace WebAthenPs.Project.Services.Interfaces.User
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel, bool rememberMe);
        Task<string?> Register(RegisterModel registerModel);
        Task Logout();
        Task<string> GetUserIdFromToken();
        Task<bool> IsLoggedIn();

        Task<string> GetToken();

    }
}
