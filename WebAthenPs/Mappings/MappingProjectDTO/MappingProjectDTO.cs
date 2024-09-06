using System.Collections.Generic;
using System.Linq;
using WebAthenPs.API.Entities.Project;
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
                ClientName = item.Client?.User?.UserName,
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
                Professionals = item.Professionals?.Select(p => new GenericProfessionalDTO
                {
                    Id = p.Id,
                    UserName = p.User?.UserName,
                    ProfessionalTypes = p.ProfessionalTypes
                }).ToList() ?? new List<GenericProfessionalDTO>()
            }) ?? Enumerable.Empty<ProjectsDTO>();
        }

        public static ProjectsDTO ConverterProjetoParaDTO(this Projecty project)
        {
            return new ProjectsDTO
            {
                ProjectId = project.ProjectId,
                ProjectName = project.ProjectName,
                ConstructionType = project.ConstructionType,
                Status = project.Status,
                Budget = project.Budget,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
                Description = project.Description,
                ClientId = project.Client?.ClientId ?? default,
                ClientName = project.Client?.User?.UserName,
                Address = project.Address,
                Neighborhood = project.Neighborhood,
                City = project.City,
                State = project.State,
                PostalCode = project.PostalCode,
                Country = project.Country,
                Step = project.ActStep,
                TotalArea = project.TotalArea,
                NumberOfRooms = project.NumberOfRooms,
                NumberOfBathrooms = project.NumberOfBathrooms,
                Professionals = project.Professionals?.Select(p => new GenericProfessionalDTO
                {
                    Id = p.Id,
                    UserName = p.User?.UserName,
                    ProfessionalTypes = p.ProfessionalTypes
                }).ToList() ?? new List<GenericProfessionalDTO>()
            };
        }

        public static Projecty CriarProjetoEmDTO(this RegisterProjectModel registerProjectModel)
        {
            return new Projecty
            {
                ProjectId = registerProjectModel.ProjectId, // Usando o ID fornecido
                ConstructionType = registerProjectModel.ConstructionType,
                Status = registerProjectModel.Status,
                Budget = registerProjectModel.Budget,
                ClientId = registerProjectModel.ClientId, // Usando o ClientId fornecido
                Address = registerProjectModel.Address,
                Neighborhood = registerProjectModel.Neighborhood,
                City = registerProjectModel.City,
                State = registerProjectModel.State,
                Country = registerProjectModel.Country,
                Description = registerProjectModel.ClientDescription // Mapeia ClientDescription para Description
                // Os seguintes campos não estão no RegisterProjectModel e devem ser definidos como padrão ou omitidos:
                // ProjectName, PostalCode, TotalArea, NumberOfRooms, Step, NumberOfBathrooms, Professionals
            };
        }


    }
}
