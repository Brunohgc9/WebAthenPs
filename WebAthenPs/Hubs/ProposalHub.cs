using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs.Components;
using WebAthenPs.API.Repositories.Interfaces;
using WebAthenPs.API.Entities.Components;
using WebAthenPs.API.Mappings.MappingComponentDTO;

namespace WebAthenPs.API.SignalRHubs
{
    public class ProposalHub : Hub
    {
        private readonly IProposalRepository _proposalRepository;

        public ProposalHub(IProposalRepository proposalRepository)
        {
            _proposalRepository = proposalRepository;
        }

        // Cliente envia uma proposta para o profissional
        public async Task SendProposal(ProposalDTO proposalDto)
        {
            // Mapeando o DTO para a entidade Proposal
            var proposal = proposalDto.CriarPropostaEmDTO();

            // Salvar a proposta no banco de dados
            await _proposalRepository.CreateAsync(proposal);

            // Enviar a proposta via SignalR para o profissional
            if (proposalDto.Professional != null)
            {
                await Clients.User(proposalDto.Professional.UserId).SendAsync("ReceiveProposal", proposalDto);
            }
        }
    }
}
