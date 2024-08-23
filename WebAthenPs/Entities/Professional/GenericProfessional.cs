using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Project;
using WebAthenPs.API.Entities.Clients;

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

        public string? ProfessionalType { get; set; }  // Corrigido para 'ProfessionalType'

        [ForeignKey("ClientId")]
        public Client? Client { get; set; }

        public ICollection<Projecty> Projects { get; set; } = new List<Projecty>();
    }
}
