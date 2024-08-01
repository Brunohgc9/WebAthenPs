using Microsoft.CodeAnalysis;
using WebAthenPs.API.Entities;

namespace WebAthenPs.API.Repositories.Interfaces
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Projects>> GetAll();
        Task<Projects> GetById(int id);
        Task<IEnumerable<Projects>> GetByStatus(string status);
        Task<IEnumerable<Projects>> GetByArea(decimal area);
    }
}
