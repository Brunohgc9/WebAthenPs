using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAthenPs.API.Entities.Project;
using WebAthenPs.Project.Components.Pages;

namespace WebAthenPs.API.Entities.Professional.ProfessionalTypes
{
    public class Architect
    {
        [Key]
        public Guid ArchId { get; set; }

        [ForeignKey("genericId")]
        public GenericProfessional Professional { get; set; }

        public int genericId { get; set; }

        public string? RegistroConselho { get; set; } 

        public string? Especialidade { get; set; }


    }
}
