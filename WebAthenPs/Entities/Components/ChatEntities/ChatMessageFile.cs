using System.ComponentModel.DataAnnotations.Schema;

namespace WebAthenPs.API.Entities.Components.ChatEntities
{
    public class ChatMessageFile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FileRoute { get; set; }

        [ForeignKey("MessageId")]
        public ChatMessage ChatMessage { get; set; }
        public Guid MessageId { get; set; }
    }
}
