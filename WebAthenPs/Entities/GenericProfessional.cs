using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebAthenPs.API.Data;

namespace WebAthenPs.API.Entities
{
    public class GenericProfessional
    {
        [Key]
        public int GProfessionalId { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        public ICollection<Projects> Projects { get; set; } = new List<Projects>();
    }
}
