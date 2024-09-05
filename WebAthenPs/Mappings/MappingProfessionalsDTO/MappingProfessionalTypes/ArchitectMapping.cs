using WebAthenPs.API.Entities.Clients;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes;
using WebAthenPs.Models.DTOs.Client;
using WebAthenPs.Models.DTOs.Professional.ProfessionalTypes.Architect;

namespace WebAthenPs.API.Mappings.MappingProfessionalsDTO.MappingProfessionalTypes
{
    public static class ArchitectMapping
    {
        public static IEnumerable<GeneralArchitectDTO> ConverterArquitetosParaDTO(this IEnumerable<Architect> architects)
        {
            if (architects == null || !architects.Any())
            {
                return Enumerable.Empty<GeneralArchitectDTO>();
            }

            return architects.Select(a => new GeneralArchitectDTO
            {
                ArchId = a.ArchId,
                genericId = a.genericId,
                RegistroConselho = a.RegistroConselho,
                Especialidade = a.Especialidade,
                name = a.Professional.User?.UserName ?? "Nome não disponível",
                email = a.Professional.User?.Email ?? "Email não disponível"
            }).ToList();
        }



        public static GeneralArchitectDTO ConverterArquitetoParaDTO(this Architect architects)
        {
            return new GeneralArchitectDTO
            {
                ArchId = architects.ArchId,
                genericId = architects.genericId,
                RegistroConselho = architects.RegistroConselho,
                Especialidade = architects.Especialidade,
                name = architects.Professional.User?.UserName,
                email = architects.Professional.User?.Email
            };
        }

        public static Architect CriarArquitetoEmDTO(this RegisterArchitectModel model)
        {
            return new Architect
            {
                genericId = model.genericId
            };
        }


    }
}
