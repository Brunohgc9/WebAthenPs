using WebAthenPs.API.Entities;
using WebAthenPs.Models.DTOs;

namespace WebAthenPs.API.Mappings.MappingProjectDTO
{
    public static class MappingGenericProfessionalDTO
    {
        public static IEnumerable<GProfessionalDTO> ConverterProfissionaisParaDTO(this IEnumerable<GenericProfessional> professionals)
        {
            // Verifica se a lista de profissionais é nula ou vazia
            if (professionals == null)
            {
                return Enumerable.Empty<GProfessionalDTO>();
            }

            return professionals.Select(p => new GProfessionalDTO
            {
                GProfessionalId = p.Id,
                UserId = p.UserId,
                ProfessionalType = p.ProfessionalType,
                Projects = p.Projects != null ? p.Projects.Select(pr => new ProjectsDTO
                {
                    ProjectId = pr.ProjectId,
                    ProjectName = pr.ProjectName
                }).ToList() : new List<ProjectsDTO>()
            });
        }


        public static GProfessionalDTO ConverterProfissionalParaDTO(this GenericProfessional professional)
        {
            return new GProfessionalDTO
            {
                GProfessionalId = professional.Id,
                UserId = professional.UserId,
                UserName = professional.User != null ? professional.User.UserName : null,
                ProfessionalType = professional.ProfessionalType,
                Projects = professional.Projects != null ? professional.Projects.Select(pr => new ProjectsDTO
                {
                    ProjectId = pr.ProjectId,
                    ProjectName = pr.ProjectName
                }).ToList() : new List<ProjectsDTO>()
            };
        }
    }
}
