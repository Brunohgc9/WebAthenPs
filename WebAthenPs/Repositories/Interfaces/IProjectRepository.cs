using Microsoft.CodeAnalysis;
using WebAthenPs.API.Entities.Project;
using WebAthenPs.Models.DTOs.Professional;

namespace WebAthenPs.API.Repositories.Interfaces
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Projecty>> GetAll();
        Task<Projecty> GetById(int id);
        Task<IEnumerable<Projecty>> GetByStatus(string status);
        Task<IEnumerable<Projecty>> GetByArea(decimal area);
        Task<Projecty> CreateNewProject(Projecty projecty);
        Task UpdateProject(Projecty projecty);
        Task DeleteProject(int id);
        Task<IEnumerable<Projecty>> GetByClientId(int clientId);
        Task AddProfessionalToProject(ProjectProfessional projectProfessional);
        Task<IEnumerable<GenericProfessionalDTO>> GetProfessionalsByProject(int projectId);


    }
}
