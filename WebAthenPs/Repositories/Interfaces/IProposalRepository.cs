using WebAthenPs.API.Entities.Components;

namespace WebAthenPs.API.Repositories.Interfaces
{
    public interface IProposalRepository
    {
        Task<Proposal> CreateAsync(Proposal proposal);
        Task DeleteAsync(Guid proposalId);
        Task<IEnumerable<Proposal>> GetByClientIdAsync(int clientId);
        Task<IEnumerable<Proposal>> GetByProfessionalIdAsync(int professionalId);
        Task<Proposal> GetByIdAsync(Guid proposalId);
        Task UpdateAsync(Proposal proposal);
        Task <IEnumerable<Proposal>> GetAllAsync();
    }
}
