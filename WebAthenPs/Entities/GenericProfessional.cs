using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebAthenPs.API.Data;

namespace WebAthenPs.API.Entities
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
