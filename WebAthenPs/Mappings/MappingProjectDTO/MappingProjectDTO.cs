using System.Collections.Generic;
using System.Linq;
using WebAthenPs.API.Entities.Project;
using WebAthenPs.API.Entities.Professional;
using WebAthenPs.Models.DTOs.Professional;
using WebAthenPs.Models.DTOs.Project;

namespace WebAthenPs.API.Mappings.MappingProjectDTO
{
    public static class MappingProjectDTO
    {
        public static IEnumerable<ProjectsDTO> ConverterProjetosParaDTO(this IEnumerable<Projecty> projects)
        {
            return projects?.Select(item => new ProjectsDTO
            {
                ProjectId = item.ProjectId,
                ProjectName = item.ProjectName,
                ConstructionType = item.ConstructionType,
                Status = item.Status,
                Budget = item.Budget,
                StartDate = item.StartDate,
                EndDate = item.EndDate,
                Description = item.Description,
                ClientId = item.Client?.ClientId ?? default,
                ClientName = item.Client?.User?.UserName ?? string.Empty, // Verificação de null
                Address = item.Address,
                Neighborhood = item.Neighborhood,
                City = item.City,
                State = item.State,
                PostalCode = item.PostalCode,
                Country = item.Country,
                TotalArea = item.TotalArea,
                NumberOfRooms = item.NumberOfRooms,
                Step = item.ActStep,
                NumberOfBathrooms = item.NumberOfBathrooms,
                LProfessionals = item.Professionals?.Select(p => new GenericProfessionalDTO
                {
                    Id = p.Id,
                    UserId = p.UserId,
                    UserName = p.User?.UserName ?? string.Empty,
                    PhoneNumber = p.User?.PhoneNumber,
                    Email = p.User?.Email,
                    ProfessionalTypes = p.ProfessionalTypes
                }).ToList() ?? new List<GenericProfessionalDTO>(),
                ProjectProfessionals = item.ProjectProfessionals?.Select(pp => new ProjectProfessionalDTO
                {
                    ProfessionalId = pp.ProfessionalId,
                    ProjectId = pp.ProjectId,
                    Professional = pp.Professional != null ? new GenericProfessionalDTO
                    {
                        Id = pp.Professional.Id,
                        UserId = pp.Professional.UserId,
                        UserName = pp.Professional.User?.UserName ?? string.Empty,
                        PhoneNumber = pp.Professional.User?.PhoneNumber,
                        Email = pp.Professional.User?.Email,
                        ProfessionalTypes = pp.Professional.ProfessionalTypes
                    } : null
                }).ToList() ?? new List<ProjectProfessionalDTO>()
            }) ?? Enumerable.Empty<ProjectsDTO>();
        }

        public static ProjectsDTO ConverterProjetoParaDTO(this Projecty project)
        {
            return new ProjectsDTO
            {
                ProjectId = project.ProjectId,
                ProjectName = project.ProjectName ?? string.Empty, // Verificação de null
                ConstructionType = project.ConstructionType ?? string.Empty,
                Status = project.Status ?? string.Empty,
                Budget = project.Budget,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
                Description = project.Description ?? string.Empty,
                ClientId = project.Client?.ClientId ?? default,
                ClientName = project.Client?.User?.UserName ?? string.Empty,
                Address = project.Address ?? string.Empty,
                Neighborhood = project.Neighborhood ?? string.Empty,
                City = project.City ?? string.Empty,
                State = project.State ?? string.Empty,
                PostalCode = project.PostalCode ?? string.Empty,
                Country = project.Country ?? string.Empty,
                TotalArea = project.TotalArea,
                NumberOfRooms = project.NumberOfRooms,
                NumberOfBathrooms = project.NumberOfBathrooms,
                Step = project.ActStep ?? string.Empty,
                LProfessionals = project.Professionals?.Select(p => new GenericProfessionalDTO
                {
                    Id = p.Id,
                    UserId = p.UserId,
                    UserName = p.User?.UserName ?? string.Empty, // Verificação de null
                    PhoneNumber = p.User?.PhoneNumber,
                    Email = p.User?.Email,
                    ProfessionalTypes = p.ProfessionalTypes ?? new List<string>() // Verificação de null
                }).ToList() ?? new List<GenericProfessionalDTO>(),
                ProjectProfessionals = project.ProjectProfessionals?.Select(pp => new ProjectProfessionalDTO
                {
                    ProfessionalId = pp.ProfessionalId,
                    ProjectId = pp.ProjectId,
                    Professional = pp.Professional != null ? new GenericProfessionalDTO
                    {
                        Id = pp.Professional.Id,
                        UserId = pp.Professional.UserId,
                        UserName = pp.Professional.User?.UserName ?? string.Empty,
                        PhoneNumber = pp.Professional.User?.PhoneNumber,
                        Email = pp.Professional.User?.Email,
                        ProfessionalTypes = pp.Professional.ProfessionalTypes ?? new List<string>() // Verificação de null
                    } : null
                }).ToList() ?? new List<ProjectProfessionalDTO>()
            };
        }


        public static Projecty CriarProjetoEmDTO(this RegisterProjectModel registerProjectModel)
        {
            return new Projecty
            {
                ProjectId = registerProjectModel.ProjectId,
                ConstructionType = registerProjectModel.ConstructionType,
                Status = registerProjectModel.Status,
                Budget = registerProjectModel.Budget,
                ClientId = registerProjectModel.ClientId,
                Address = registerProjectModel.Address,
                Neighborhood = registerProjectModel.Neighborhood,
                City = registerProjectModel.City,
                State = registerProjectModel.State,
                Country = registerProjectModel.Country,
                Description = registerProjectModel.ClientDescription
                // Os seguintes campos não estão no RegisterProjectModel e devem ser definidos como padrão ou omitidos:
                // ProjectName, PostalCode, TotalArea, NumberOfRooms, Step, NumberOfBathrooms, Professionals
            };
        }

        public static Projecty AtualizarProjetoDTO(this ProjectsDTO updateProjectDTO)
        {
            return new Projecty
            {
                ProjectId = updateProjectDTO.ProjectId,
                ProjectName = updateProjectDTO.ProjectName,
                ConstructionType = updateProjectDTO.ConstructionType,
                Status = updateProjectDTO.Status,
                Budget = updateProjectDTO.Budget,
                StartDate = updateProjectDTO.StartDate,
                EndDate = updateProjectDTO.EndDate,
                Description = updateProjectDTO.Description,
                ClientId = updateProjectDTO.ClientId,
                Address = updateProjectDTO.Address,
                Neighborhood = updateProjectDTO.Neighborhood,
                City = updateProjectDTO.City,
                State = updateProjectDTO.State,
                PostalCode = updateProjectDTO.PostalCode,
                Country = updateProjectDTO.Country,
                TotalArea = updateProjectDTO.TotalArea,
                NumberOfRooms = updateProjectDTO.NumberOfRooms,
                ActStep = updateProjectDTO.Step,
                NumberOfBathrooms = updateProjectDTO.NumberOfBathrooms,
                Professionals = updateProjectDTO.LProfessionals?.Select(p => new GenericProfessional
                {
                    Id = p.Id,
                    UserId = p.UserId, // Ajuste conforme necessário
                    ProfessionalTypes = p.ProfessionalTypes
                }).ToList() ?? new List<GenericProfessional>(),
                ProjectProfessionals = updateProjectDTO.ProjectProfessionals?.Select(pp => new ProjectProfessional
                {
                    ProfessionalId = pp.ProfessionalId,
                    ProjectId = pp.ProjectId,
                }).ToList() ?? new List<ProjectProfessional>()
            };
        }
    }
}
