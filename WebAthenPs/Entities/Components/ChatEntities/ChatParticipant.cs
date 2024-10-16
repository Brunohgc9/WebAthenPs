using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAthenPs.API.Data;

namespace WebAthenPs.API.Entities.Components.ChatEntities
{
    public class ChatParticipant
    {
        [Key]
        public Guid Id { get; set; }
        // Relacionamento com o Chat (usando ChatId como chave estrangeira)
        public Guid ChatId { get; set; }

        [ForeignKey("ChatId")]
        public Chat Chat { get; set; }

        // Relacionamento com o ApplicationUser (UserId do tipo string)
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}
