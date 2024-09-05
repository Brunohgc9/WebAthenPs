using System.Collections.Generic;
using System.Linq;
using WebAthenPs.API.Entities.Professional;
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
                        UserName = professional.User?.UserName, // Inclui o nome do usuário, se disponível
                        PhoneNumber = professional.User?.PhoneNumber,
                        Email = professional.User?.Email,
                        ClientId = professional.ClientId,
                        ProfessionalType = professional.ProfessionalType // Inclui o nome do cliente, se disponível
                    }).ToList();
        }

        public static GenericProfessionalDTO ConverterProfessionalParaDTO(this GenericProfessional professional)
        {
            return new GenericProfessionalDTO
            {
                Id = professional.Id,
                UserId = professional.UserId,
                UserName = professional.User?.UserName, // Inclui o nome do usuário, se disponível
                PhoneNumber = professional.User?.PhoneNumber,
                Email = professional.User?.Email,
                ClientId = professional.ClientId,
                ProfessionalType = professional.ProfessionalType,
            };
        }

        public static IEnumerable<GenericProfessional> CriarProfessionalsEmDTO(
            this IEnumerable<RegisterProfessionalModel> dtos)
        {
            return (from dto in dtos
                    select new GenericProfessional
                    {
                        UserId = dto.UserId,
                        ProfessionalType = dto.ProfessionalType
                        // Não mapeando User e Client aqui, você pode precisar configurar esses valores separadamente
                    }).ToList();
        }

        public static GenericProfessional CriarProfessionalEmDTO(this RegisterProfessionalModel dto)
        {
            return new GenericProfessional
            {
                UserId = dto.UserId,
                ProfessionalType = dto.ProfessionalType
                // Não mapeando User e Client aqui, você pode precisar configurar esses valores separadamente
            };
        }
    }
}
