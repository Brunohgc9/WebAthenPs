using WebAthenPs.Models.DTOs;
using WebAthenPs.Models.Models;

namespace WebAthenPs.Project.Services.Interfaces
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectsDTO>> GetAll();
        Task<ProjectsDTO> GetById(int id);
        Task<IEnumerable<ProjectsDTO>> GetByStatus(string status);
        Task<IEnumerable<ProjectsDTO>> GetByArea(decimal area);
        Task<ProjectsDTO> CreateProject(RegisterProjectModel model);
        Task DeleteProject(int id);
    }
}
