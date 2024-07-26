using WebAthenPs.API.Entities;
using WebAthenPs.Models.DTOs;

namespace WebAthenPs.API.Mappings.MappingProjectDTO
{
    public static class MappingProjectDTOs
    {
        public static IEnumerable<ProjectsDTO> ConverterProjetosParaDTO(this IEnumerable<Projects> projects)
        {
            return from item in projects
                   select new ProjectsDTO
                   {
                       ProjectId = item.ProjectId,
                       ProjectName = item.ProjectName,
                       ConstructionType = item.ConstructionType,
                       Status = item.Status,
                       Budget = item.Budget,
                       StartDate = item.StartDate,
                       EndDate = item.EndDate,
                       Description = item.Description,
                       ClientId = item.Client != null ? item.Client.ClientId : default(int),
                       ClientName = item.Client != null && item.Client.User != null ? item.Client.User.UserName : null,
                       Address = item.Address,
                       Neighborhood = item.Neighborhood,
                       City = item.City,
                       State = item.State,
                       PostalCode = item.PostalCode,
                       Country = item.Country,
                       TotalArea = item.TotalArea,
                       NumberOfRooms = item.NumberOfRooms,
                       NumberOfBathrooms = item.NumberOfBathrooms,
                       Professionals = item.Professionals.Select(p => new GProfessionalDTO
                       {
                           GProfessionalId = p.GProfessionalId,
                           UserName = p.User.UserName
                       }).ToList()
                   };
        }

        public static ProjectsDTO ConverterProjetoParaDTO(this Projects projects)
        {
            return new ProjectsDTO
            {
                ProjectId = projects.ProjectId,
                ProjectName = projects.ProjectName,
                ConstructionType = projects.ConstructionType,
                Status = projects.Status,
                Budget = projects.Budget,
                StartDate = projects.StartDate,
                EndDate = projects.EndDate,
                Description = projects.Description,
                ClientId = projects.Client != null ? projects.Client.ClientId : default(int),
                ClientName = projects.Client != null && projects.Client.User != null ? projects.Client.User.UserName : null,
                Address = projects.Address,
                Neighborhood = projects.Neighborhood,
                City = projects.City,
                State = projects.State,
                PostalCode = projects.PostalCode,
                Country = projects.Country,
                TotalArea = projects.TotalArea,
                NumberOfRooms = projects.NumberOfRooms,
                NumberOfBathrooms = projects.NumberOfBathrooms,
                Professionals = projects.Professionals.Select(p => new GProfessionalDTO
                {
                    GProfessionalId = p.GProfessionalId,
                    UserName = p.User.UserName
                }).ToList()
            };
        }
    }
}
