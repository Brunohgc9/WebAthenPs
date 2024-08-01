using System.Collections.Generic;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs;
using WebAthenPs.Models.Models;

namespace WebAthenPs.API.Services.Interfaces
{
    public interface IGenericProfessionalService
    {
        Task<GenericProfessionalDTO> CreateAsync(RegisterProfessionalModel model, string userId);
        Task<GenericProfessionalDTO> GetByIdAsync(int id);
        Task<IEnumerable<GenericProfessionalDTO>> GetByProfessionalTypeAsync(string professionalType);
        Task<GenericProfessionalDTO> UpdateAsync(int id, RegisterProfessionalModel model);
        Task DeleteAsync(int id);
    }
}
