using WebAthenPs.API.Entities.Professional;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes;

namespace WebAthenPs.API.Repositories.Interfaces
{
    public interface IArchitectRepository
    {
        Task<Architect> GetByIdAsync(Guid id);
        Task CreateAsync(Architect architect);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Architect architect);
        Task<IEnumerable<Architect>> GetAllAsync();
    }



}
