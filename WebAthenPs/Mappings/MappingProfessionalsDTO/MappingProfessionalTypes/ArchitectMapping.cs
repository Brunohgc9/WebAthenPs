using WebAthenPs.API.Entities.Professional.ProfessionalTypes;
using WebAthenPs.Models.DTOs.Professional.ProfessionalTypes.Architect;
using System.Collections.Generic;
using System.Linq;

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
                name = a.Professional?.User?.UserName ?? "Nome não disponível",
                email = a.Professional?.User?.Email ?? "Email não disponível"
            }).ToList();
        }

        public static GeneralArchitectDTO ConverterArquitetoParaDTO(this Architect architect)
        {
            if (architect == null)
            {
                return null;
            }

            return new GeneralArchitectDTO
            {
                ArchId = architect.ArchId,
                genericId = architect.genericId,
                RegistroConselho = architect.RegistroConselho,
                Especialidade = architect.Especialidade,
                name = architect.Professional?.User?.UserName ?? "Nome não disponível",
                email = architect.Professional?.User?.Email ?? "Email não disponível"
            };
        }

        public static Architect CriarArquitetoEmDTO(this RegisterArchitectModel model)
        {
            if (model == null)
            {
                return null;
            }

            return new Architect
            {
                genericId = model.genericId
                // Outros campos podem ser adicionados aqui, se necessário
            };
        }
    }
}
