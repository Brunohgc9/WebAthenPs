using WebAthenPs.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAthenPs.Project.Services.Interfaces
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectsDTO>> GetAll();
        Task<ProjectsDTO> GetById(int id);
        Task<IEnumerable<ProjectsDTO>> GetByStatus(string status);
        Task<IEnumerable<ProjectsDTO>> GetByArea(decimal area);
    }
}
