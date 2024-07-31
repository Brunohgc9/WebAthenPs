using WebAthenPs.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAthenPs.API.Repositories.Interfaces
{
    public interface IGenericProfessionalRepository : IRepository<GenericProfessional>
    {
        Task<IEnumerable<GenericProfessional>> GetAll();
        Task<GenericProfessional> GetById(int id);
        Task<IEnumerable<GenericProfessional>> GetByName(string name);
        Task<IEnumerable<GenericProfessional>> GetByProfessionalType(string professionalType);
    }
}
