using WebAthenPs.Models.DTOs.Components;

namespace WebAthenPs.Project.Services.Interfaces.Components
{
    public interface IProposalService
    {
        Task<ProposalDTO> CreateAsync(ProposalDTO proposalDTO);
        Task<ProposalDTO> GetByIdAsync(Guid id);
        Task<IEnumerable<ProposalDTO>> GetByClientIdAsync(int clientId);
        Task<ProposalDTO> UpdateAsync(Guid id, ProposalDTO proposalDTO);
        Task DeleteAsync(Guid id);

    }
}
