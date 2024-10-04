using System.Collections.Generic;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs.Client;
using WebAthenPs.Models.DTOs.Professional;

namespace WebAthenPs.Project.Services.Interfaces.Professional
{
    public interface IGenericProfessionalService
    {
        Task<GenericProfessionalDTO> CreateAsync(RegisterProfessionalModel model, string userId);
        Task<GenericProfessionalDTO> GetByIdAsync(int id);
        Task<IEnumerable<GenericProfessionalDTO>> GetByProfessionalTypeAsync(string professionalType);
        Task<GenericProfessionalDTO> UpdateAsync(int id, RegisterProfessionalModel model);
        Task DeleteAsync(int id);
        Task<IEnumerable<GenericProfessionalDTO>> GetAllAsync(string professionalType);
        Task<GenericProfessionalDTO> GetByUserId(string userId);

    }
}
