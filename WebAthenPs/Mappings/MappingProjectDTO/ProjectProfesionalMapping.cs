using System.Collections.Generic;
using System.Linq;
using WebAthenPs.API.Entities.Project;
using WebAthenPs.Models.DTOs.Professional;

namespace WebAthenPs.API.Mappings.MappingProjectDTO
{
    public static class ProjectProfessionalMapping
    {
        // Converte uma lista de ProjectProfessional para DTO
        public static IEnumerable<ProjectProfessionalDTO> ConverterProjectProfessionalsParaDTO(
            this IEnumerable<ProjectProfessional> projectProfessionals)
        {
            return (from projectProfessional in projectProfessionals
                    select new ProjectProfessionalDTO
                    {
                        ProfessionalId = projectProfessional.ProfessionalId,
                        ProjectId = projectProfessional.ProjectId,
                        Professional = projectProfessional.Professional != null
                            ? new GenericProfessionalDTO
                            {
                                Id = projectProfessional.Professional.Id,
                                UserId = projectProfessional.Professional.UserId,
                                UserName = projectProfessional.Professional.User?.UserName,
                                Email = projectProfessional.Professional.User?.Email,
                                PhoneNumber = projectProfessional.Professional.User?.PhoneNumber
                            }
                            : null,
                        ContractedAs = projectProfessional.ContractedAs.ToList()
                    }).ToList();
        }

        // Converte um ProjectProfessional individual para DTO
        public static ProjectProfessionalDTO ConverterProjectProfessionalParaDTO(this ProjectProfessional projectProfessional)
        {
            return new ProjectProfessionalDTO
            {
                ProfessionalId = projectProfessional.ProfessionalId,
                ProjectId = projectProfessional.ProjectId,
                Professional = projectProfessional.Professional != null
                    ? new GenericProfessionalDTO
                    {
                        Id = projectProfessional.Professional.Id,
                        UserId = projectProfessional.Professional.UserId,
                        UserName = projectProfessional.Professional.User?.UserName,
                        Email = projectProfessional.Professional.User?.Email,
                        PhoneNumber = projectProfessional.Professional.User?.PhoneNumber
                    }
                    : null,
                ContractedAs = projectProfessional.ContractedAs.ToList()
            };
        }

        // Converte um DTO para entidade de ProjectProfessional
        public static ProjectProfessional ConverterDTOParaProjectProfessional(this ProjectProfessionalDTO dto)
        {
            return new ProjectProfessional
            {
                ProfessionalId = dto.ProfessionalId,
                ProjectId = dto.ProjectId,
                ContractedAs = dto.ContractedAs
            };
        }
    }
}
