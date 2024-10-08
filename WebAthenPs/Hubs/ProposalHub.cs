﻿using Microsoft.AspNetCore.SignalR;
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
            if (proposalDto == null)
            {
                throw new ArgumentNullException(nameof(proposalDto), "O DTO da proposta não pode ser nulo.");
            }

            // Mapeando o DTO para a entidade Proposal
            var proposal = proposalDto.CriarPropostaEmDTO();

            // Atribuir o ID do cliente a partir do ClientDTO
            if (proposalDto.Client != null)
            {
                proposal.ClientId = proposalDto.Client.ClientId; // Supondo que ClientDTO tenha uma propriedade ClientId
            }
            else
            {
                throw new ArgumentException("Cliente não informado no DTO da proposta.");
            }

            // Salvar a proposta no banco de dados
            await _proposalRepository.CreateAsync(proposal);

            // Enviar a proposta via SignalR para o profissional
            if (proposalDto.Professional != null)
            {
                await Clients.User(proposalDto.Professional.UserId).SendAsync("ReceiveProposal", proposalDto);
            }
        }

        // Profissional aceita ou rejeita uma proposta
        public async Task RespondToProposal(Guid proposalId, bool isAccepted)
        {
            // Buscar a proposta pelo ID
            var proposal = await _proposalRepository.GetByIdAsync(proposalId);
            if (proposal == null)
            {
                throw new ArgumentException("Proposta não encontrada.", nameof(proposalId));
            }

            // Atualiza a proposta com a resposta do profissional
            proposal.IsAccepted = isAccepted;

            // Atualizar a proposta no banco de dados
            await _proposalRepository.UpdateAsync(proposal);

            // Enviar a resposta de volta ao cliente que enviou a proposta
            await Clients.User(proposal.ClientId.ToString()).SendAsync("ProposalResponse", proposalId, isAccepted);
        }
    }
}
