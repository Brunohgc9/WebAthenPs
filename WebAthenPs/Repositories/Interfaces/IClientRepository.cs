using WebAthenPs.API.Entities;

namespace WebAthenPs.API.Repositories.Interfaces
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAll();
        Task<Client> GetById(int id);
        Task<IEnumerable<Client>> GetByName(string name);
    }
}
