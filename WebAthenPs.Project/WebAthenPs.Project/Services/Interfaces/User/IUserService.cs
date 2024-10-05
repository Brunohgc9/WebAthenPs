using WebAthenPs.Models.DTOs.User;

namespace WebAthenPs.Project.Services.Interfaces.User
{
    public interface IUserService
    {
        Task<ApplicationUser> GetUserInfo(string userId);
        Task<string> UpdateUserInfo(string userId, UpdateUserModel model);
        Task<bool> DeleteAccount(string userId);
        Task<string> GetUserTypeById(string userId);
    }
}
