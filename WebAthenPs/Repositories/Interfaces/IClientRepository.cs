using WebAthenPs.API.Entities.Clients;

namespace WebAthenPs.API.Repositories.Interfaces
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAll();
        Task<Client> GetById(int id);
        Task<IEnumerable<Client>> GetByName(string name);
        Task<Client> Create(Client client);
        Task Update(Client client);
        Task Delete(int id);
    }
}
