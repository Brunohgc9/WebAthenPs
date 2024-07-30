using WebAthenPs.Models.Models;

namespace WebAthenPs.Project.Services.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);
        Task<bool> Register(RegisterModel registerModel); // Adicione esta linha

        Task Logout();
    }
}
