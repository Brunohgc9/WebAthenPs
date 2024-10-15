using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAthenPs.API.Data;

namespace WebAthenPs.API.Entities
{
    public class Message
    {
        [Key]
        public Guid MessageId { get; set; } = Guid.NewGuid();

        public string Content { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        public string SenderId { get; set; }  // SenderId como string
        [ForeignKey("SenderId")]
        public ApplicationUser User { get; set; }

        public Guid ChatId { get; set; }  // ChatId como Guid
        [ForeignKey("ChatId")]
        public Chat Chat { get; set; }
    }
}
