using WebAthenPs.API.Entities.Clients;
using WebAthenPs.API.Entities.Professional;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes.ProfessionalsRelation;

namespace WebAthenPs.API.Repositories.Interfaces
{
    public interface IGenericProfessionlRepository
    {
        Task<GenericProfessional> GetByIdAsync(int id);
        Task<GenericProfessional> GetByNameAsync(string name);
        Task<IEnumerable<GenericProfessional>> GetByProfessionalTypeAsync(string professionalType);
        Task CreateAsync(GenericProfessional genericProfessional, List<string> professionalTypeNames);
        Task DeleteAsync(int id);
        Task UpdateAsync(GenericProfessional genericProfessional);
        Task<IEnumerable<GenericProfessional>> GetAllAsync();

        Task<GenericProfessional> GetByUserId(string userId);

        Task<IEnumerable<GenericProfessional>> GetProfessionalsByTypeAsync(string type);
        Task<IEnumerable<GenericProfessionalProfessionalType>> GetSpecializationsByProfessionalIdAsync(int professionalId);


    }
}
