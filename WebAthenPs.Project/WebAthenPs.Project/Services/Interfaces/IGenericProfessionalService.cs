using WebAthenPs.Models.DTOs;

namespace WebAthenPs.Project.Services.Interfaces
{
    public interface IGenericProfessionalService
    {
        Task<IEnumerable<GProfessionalDTO>> GetAll();
        Task<GProfessionalDTO> GetById(int id);
        Task<IEnumerable<GProfessionalDTO>> GetByName(string name);
        Task<IEnumerable<GProfessionalDTO>> GetByProfessionalType(string professionalType);
        Task<bool> CreateProfessional(GProfessionalDTO professionalDTO); // Atualizado para bool
        Task<GProfessionalDTO> UpdateProfessional(GProfessionalDTO professionalDTO, int id);
        Task<bool> DeleteProfessional(int id); // Atualizado para bool
    }

}
