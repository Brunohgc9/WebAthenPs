﻿using System.Collections.Generic;
using System.Linq;
using WebAthenPs.API.Entities.Components;
using WebAthenPs.Models.DTOs.Client;
using WebAthenPs.Models.DTOs.Components;
using WebAthenPs.Models.DTOs.Professional;
using WebAthenPs.Models.DTOs.Project;

namespace WebAthenPs.API.Mappings.MappingComponentDTO
{
    public static class MappingProposalDTO
    {
        public static IEnumerable<ProposalDTO> ConverterPropostasParaDTO(this IEnumerable<Proposal> proposals)
        {
            return proposals?.Select(item => new ProposalDTO
            {
                ProposalId = item.ProposalId,
                ProposalMessage = item.ProposalMessage ?? string.Empty,
                ProposalValue = item.ProposalValue,
                ProposalType = item.ProposalType ?? string.Empty,
                IsAccepted = item.IsAccepted,
                Client = item.Client != null ? new ClientDTO
                {
                    ClientId = item.Client.ClientId,
                    UserId = item.Client.UserId,
                    UserName = item.Client.User?.UserName ?? string.Empty,
                    Email = item.Client.User?.Email ?? string.Empty,
                } : null,
                Professional = item.Professional != null ? new GenericProfessionalDTO
                {
                    Id = item.Professional.Id,
                    UserId = item.Professional.UserId,
                    UserName = item.Professional.User?.UserName ?? string.Empty,
                    Email = item.Professional.User?.Email ?? string.Empty,
                } : null,
                Projects = item.Project != null ? new ProjectsDTO
                {
                    ProjectId = item.Project.ProjectId,
                    ProjectName = item.Project.ProjectName,
                    // Mapeie outros campos conforme necessário
                } : null,
                ToBeContractedAs = item.ToBeContractedAs?.ToList() ?? new List<string>()
            }) ?? Enumerable.Empty<ProposalDTO>();
        }

        public static ProposalDTO ConverterPropostaParaDTO(this Proposal proposal)
        {
            return new ProposalDTO
            {
                ProposalId = proposal.ProposalId,
                ProposalMessage = proposal.ProposalMessage ?? string.Empty,
                ProposalValue = proposal.ProposalValue,
                ProposalType = proposal.ProposalType ?? string.Empty,
                IsAccepted = proposal.IsAccepted,
                Client = proposal.Client != null ? new ClientDTO
                {
                    ClientId = proposal.Client.ClientId,
                    UserId = proposal.Client.UserId,
                    UserName = proposal.Client.User?.UserName ?? string.Empty,
                    Email = proposal.Client.User?.Email ?? string.Empty,
                } : null,
                Professional = proposal.Professional != null ? new GenericProfessionalDTO
                {
                    Id = proposal.Professional.Id,
                    UserId = proposal.Professional.UserId,
                    UserName = proposal.Professional.User?.UserName ?? string.Empty,
                    Email = proposal.Professional.User?.Email ?? string.Empty,
                } : null,
                Projects = proposal.Project != null ? new ProjectsDTO
                {
                    ProjectId = proposal.Project.ProjectId,
                } : null,
                ToBeContractedAs = proposal.ToBeContractedAs?.ToList() ?? new List<string>()
            };
        }

        public static Proposal CriarPropostaEmDTO(this ProposalDTO proposalDTO)
        {
            return new Proposal
            {
                ProposalId = proposalDTO.ProposalId,
                ProposalMessage = proposalDTO.ProposalMessage,
                ProposalValue = proposalDTO.ProposalValue,
                ProposalType = proposalDTO.ProposalType,
                IsAccepted = proposalDTO.IsAccepted,
                ClientId = proposalDTO.Client?.ClientId ?? default,
                ProfessionalId = proposalDTO.Professional?.Id ?? default,
                ToBeContractedAs = proposalDTO.ToBeContractedAs?.ToList() ?? new List<string>(),
                ProjectId = proposalDTO.Projects?.ProjectId ?? default
            };
        }

        public static Proposal AtualizarPropostaDTO(this ProposalDTO proposalDTO)
        {
            return new Proposal
            {
                ProposalId = proposalDTO.ProposalId,
                ProposalMessage = proposalDTO.ProposalMessage,
                ProposalValue = proposalDTO.ProposalValue,
                ProposalType = proposalDTO.ProposalType,
                IsAccepted = proposalDTO.IsAccepted,
                ClientId = proposalDTO.Client?.ClientId ?? default,
                ProfessionalId = proposalDTO.Professional?.Id ?? default,
                ToBeContractedAs = proposalDTO.ToBeContractedAs?.ToList() ?? new List<string>(),
                ProjectId = proposalDTO.Projects?.ProjectId ?? default
            };
        }
    }
}
