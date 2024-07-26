using WebAthenPs.Models.DTOs;

namespace WebAthenPs.Project.Services.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<ClientDTO>> GetAll();
        Task<ClientDTO> GetById(int id);
        Task<IEnumerable<ClientDTO>> GetByName(string name);
    }
}
