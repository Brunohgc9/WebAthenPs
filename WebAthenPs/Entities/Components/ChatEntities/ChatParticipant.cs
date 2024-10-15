using System.ComponentModel.DataAnnotations.Schema;
using WebAthenPs.API.Data;

namespace WebAthenPs.API.Entities.Components.ChatEntities
{
    public class ChatParticipant
    {
        public Guid ChatId { get; set; }
        [ForeignKey("ChatId")]
        public Chat Chat { get; set; }

        public string UserId { get; set; }  // UserId como string
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}
