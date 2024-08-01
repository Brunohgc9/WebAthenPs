using Microsoft.CodeAnalysis;
using WebAthenPs.API.Entities;

namespace WebAthenPs.API.Repositories.Interfaces
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Projecty>> GetAll();
        Task<Projecty> GetById(int id);
        Task<IEnumerable<Projecty>> GetByStatus(string status);
        Task<IEnumerable<Projecty>> GetByArea(decimal area);
    }
}
