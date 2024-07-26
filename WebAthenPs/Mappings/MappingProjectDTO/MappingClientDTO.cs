using WebAthenPs.API.Entities;
using WebAthenPs.Models.DTOs;

namespace WebAthenPs.API.Mappings.MappingProjectDTO
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
                    ? c.GenericProfessionals.Select(gp => new GProfessionalDTO
                    {
                        GProfessionalId = gp.GProfessionalId,
                        UserName = gp.User != null ? gp.User.UserName : null
                    }).ToList()
                    : new List<GProfessionalDTO>()
            });
        }

        public static ClientDTO ConverterClienteParaDTO(this Client client)
        {
            return new ClientDTO
            {
                ClientId = client.ClientId,
                UserId = client.UserId,
                UserName = client.User != null ? client.User.UserName : null,
                PhoneNumber = client.User != null ? client.User.PhoneNumber : null,
                Email = client.User != null ? client.User.Email : null,
                Houses = client.Houses != null ? client.Houses.Select(p => new ProjectsDTO
                {
                    ProjectId = p.ProjectId,
                    ProjectName = p.ProjectName
                }).ToList() : new List<ProjectsDTO>(),
                GenericProfessionals = client.GenericProfessionals != null
                    ? client.GenericProfessionals.Select(gp => new GProfessionalDTO
                    {
                        GProfessionalId = gp.GProfessionalId,
                        UserName = gp.User != null ? gp.User.UserName : null
                    }).ToList()
                    : new List<GProfessionalDTO>()
            };
        }
    }
}
