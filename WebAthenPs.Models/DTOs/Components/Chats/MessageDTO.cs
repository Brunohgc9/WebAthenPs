using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.DTOs.Components.Chats
{
    public class MessageDTO
    {
        public Guid MessageId { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string SenderId { get; set; }  // SenderId como string
        public Guid ChatId { get; set; }  // ChatId como Guid
    }
}
