using System.ComponentModel.DataAnnotations.Schema;
using WebAthenPs.API.Data;

namespace WebAthenPs.API.Entities.Components.ChatEntities
{
    public class ChatMessage
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public string UserId {  get; set; }
        public Guid ChatId { get; set; }
        public DateTime SentAt { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        [ForeignKey("ChatId")]
        public Chats Chats { get; set; }

        [ForeignKey("ChatMessageFileId")]
        public ChatMessageFile? ChatMessageFile { get; set; }
        public Guid? ChatMessageFileId { get; set; }
    }
}
