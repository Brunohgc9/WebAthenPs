using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAthenPs.API.Data;

namespace WebAthenPs.API.Entities.Components.Chat
{
    public class UserChat
    {
        [Key]
        public Guid MessageId { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        public Guid ChatId { get; set; }
        [ForeignKey("ChatId")]
        public Chat Chat { get; set; }

        public DateTime SentAt { get; set; } = DateTime.UtcNow;
        public string Message { get; set; }
    }
}
