using WebAthenPs.API.Entities.Clients;
using WebAthenPs.Models.DTOs.Client;
using WebAthenPs.Models.DTOs.Professional;
using WebAthenPs.Models.DTOs.Project;

namespace WebAthenPs.API.Mappings.MappingClientsDTO
{
    public static class MappingClientDTO
    {
        public static IEnumerable<ClientDTO> ConverterClientesParaDTO(this IEnumerable<Client> clients)
        {
            // Verifica se a lista de clientes é nula ou vazia
            if (clients == null)
            {
                return Enumerable.Empty<ClientDTO>();
            }

            return clients.Select(c => new ClientDTO
            {
                ClientId = c.ClientId,
                UserId = c.UserId,
                UserName = c.User != null ? c.User.UserName : null,
                PhoneNumber = c.User != null ? c.User.PhoneNumber : null,
                Email = c.User != null ? c.User.Email : null,
                Houses = c.Houses != null ? c.Houses.Select(p => new ProjectsDTO
                {
                    ProjectId = p.ProjectId,
                    ProjectName = p.ProjectName
                }).ToList() : new List<ProjectsDTO>(),
                GenericProfessionals = c.GenericProfessionals != null
                    ? c.GenericProfessionals.Select(gp => new GenericProfessionalDTO
                    {
                        ProfessionalTypes = gp.ProfessionalTypes,  // Incluindo ProfessionalType
                        Id = gp.Id,
                        UserName = gp.User != null ? gp.User.UserName : null
                    }).ToList()
                    : new List<GenericProfessionalDTO>()
            });
        }

        public static ClientDTO ConverterClienteParaDTO(this Client client)
        {
            return new ClientDTO
            {
                ClientId = client.ClientId,
                UserId = client.UserId,
                UserName = client.User?.UserName,
                PhoneNumber = client.User?.PhoneNumber,
                Email = client.User?.Email,
                Houses = client.Houses?.Select(p => new ProjectsDTO
                {
                    ProjectId = p.ProjectId,
                    ProjectName = p.ProjectName
                }).ToList() ?? new List<ProjectsDTO>(),
                GenericProfessionals = client.GenericProfessionals?.Select(gp => new GenericProfessionalDTO
                {
                    ProfessionalTypes = gp.ProfessionalTypes,
                    Id = gp.Id,
                    UserName = gp.User?.UserName
                }).ToList() ?? new List<GenericProfessionalDTO>()
            };
        }

        public static Client CriarClienteEmDTO(this RegisterClientModel dto)
        {
            return new Client
            {
                UserId = dto.UserId
            };
        }

    }
}
