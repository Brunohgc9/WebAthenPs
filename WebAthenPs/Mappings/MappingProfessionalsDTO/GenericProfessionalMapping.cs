using System.Collections.Generic;
using System.Linq;
using WebAthenPs.API.Entities.Professional;
using WebAthenPs.Models.DTOs.Components;
using WebAthenPs.Models.DTOs.Professional;

namespace WebAthenPs.API.Mappings.MappingProfessionalsDTO
{
    public static class GenericProfessionalMapping
    {
        public static IEnumerable<GenericProfessionalDTO> ConverterProfessionalsParaDTO(
            this IEnumerable<GenericProfessional> professionals)
        {
            return (from professional in professionals
                    select new GenericProfessionalDTO
                    {
                        Id = professional.Id,
                        UserId = professional.UserId,
                        UserName = professional.User?.UserName,
                        PhoneNumber = professional.User?.PhoneNumber,
                        Email = professional.User?.Email,
                        ClientId = professional.ClientId,
                        ProfessionalTypes = professional.ProfessionalTypes,
                        ProjectProfessionals = professional.ProjectProfessionals
                            .Select(pp => new ProjectProfessionalDTO
                            {
                                ProfessionalId = pp.ProfessionalId,
                                ProjectId = pp.ProjectId,
                            }).ToList(),
                        //GeneralArchitect = professional.Architect != null ? new GeneralArchitectDTO
                        //{
                        //    ArchId = professional.Architect.ArchId,
                        //    RegistroConselho = professional.Architect.RegistroConselho,
                        //    Especialidade = professional.Architect.Especialidade,
                        //    genericId = professional.Architect.genericId,
                        //    name = professional.User?.UserName,
                        //    email = professional.User?.Email
                        //} : null,
                        Proposals = professional.Proposals
                .Select(pp => new ProposalDTO
                {
                    ProposalId = pp.ProposalId
                }).ToList(),

                    }).ToList();
        }

        public static GenericProfessionalDTO ConverterProfessionalParaDTO(this GenericProfessional professional)
        {
            return new GenericProfessionalDTO
            {
                Id = professional.Id,
                UserId = professional.UserId,
                UserName = professional.User?.UserName,
                PhoneNumber = professional.User?.PhoneNumber,
                Email = professional.User?.Email,
                ClientId = professional.ClientId,
                ProfessionalTypes = professional.ProfessionalTypes,
                ProjectProfessionals = professional.ProjectProfessionals
                    .Select(pp => new ProjectProfessionalDTO
                    {
                        ProfessionalId = pp.ProfessionalId,
                        ProjectId = pp.ProjectId,
                    }).ToList(),
                //GeneralArchitect = professional.Architect != null ? new GeneralArchitectDTO
                //{
                //    ArchId = professional.Architect.ArchId,
                //    RegistroConselho = professional.Architect.RegistroConselho,
                //    Especialidade = professional.Architect.Especialidade,
                //    genericId = professional.Architect.genericId,
                //    name = professional.User?.UserName,
                //    email = professional.User?.Email
                //} : null,
                Proposals = professional.Proposals
                .Select(pp => new ProposalDTO
                {
                    ProposalId = pp.ProposalId
                }).ToList(),
            };
        }

        public static IEnumerable<GenericProfessional> CriarProfessionalsEmDTO(
            this IEnumerable<RegisterProfessionalModel> dtos)
        {
            return (from dto in dtos
                    select new GenericProfessional
                    {
                        UserId = dto.UserId,
                        ProfessionalTypes = dto.ProfessionalTypes,
                        // Inclua ArchitectId se necessário
                    }).ToList();
        }

        public static GenericProfessional CriarProfessionalEmDTO(this RegisterProfessionalModel dto)
        {
            return new GenericProfessional
            {
                UserId = dto.UserId,
                ProfessionalTypes = dto.ProfessionalTypes,
                // Inclua ArchitectId se necessário
            };
        }
    }

}
