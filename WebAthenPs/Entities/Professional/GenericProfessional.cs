using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Project;
using WebAthenPs.API.Entities.Clients;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes;

namespace WebAthenPs.API.Entities.Professional
{
    public class GenericProfessional
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        public int? ClientId { get; set; }

        public List<string> ProfessionalTypes { get; set; } = new List<string>(); // Alterado para uma lista

        [ForeignKey("ClientId")]
        public Client? Client { get; set; }

        public ICollection<Projecty> Projects { get; set; } = new List<Projecty>();

        public Guid? ArchId { get; set; }

        [ForeignKey("ArchId")]
        public Architect? Architect { get; set; }

        public ICollection<ProjectProfessional> ProjectProfessionals { get; set; } = new List<ProjectProfessional>();

    }
}
