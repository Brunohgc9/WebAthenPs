using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebAthenPs.API.Entities.Clients;
using WebAthenPs.API.Entities.Professional;

namespace WebAthenPs.API.Entities.Components.Chat
{
    public class Chat
    {
        [Key]
        public Guid ChatId { get; set; }

        public Guid ProposalId { get; set; }
        [ForeignKey("ProposalId")]
        public Proposal Proposal { get; set; }

        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        public int ProfessionalId { get; set; }
        [ForeignKey("ProfessionalId")]
        public GenericProfessional Professional { get; set; }

        public ICollection<UserChat> Messages { get; set; } = new List<UserChat>();

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
