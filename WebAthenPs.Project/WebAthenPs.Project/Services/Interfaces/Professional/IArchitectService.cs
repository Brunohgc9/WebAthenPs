using WebAthenPs.Models.DTOs.Professional.ProfessionalTypes.Architect;

namespace WebAthenPs.Project.Services.Interfaces.Professional
{
    public interface IArchitectService
    {
        Task<GeneralArchitectDTO> CreateAsync(RegisterArchitectModel model);
        Task<GeneralArchitectDTO> GetByIdAsync(Guid id);
        Task<IEnumerable<GeneralArchitectDTO>> GetAllAsync();
        Task UpdateAsync(Guid id, GeneralArchitectDTO model);
        Task DeleteAsync(Guid id);
    }
}
