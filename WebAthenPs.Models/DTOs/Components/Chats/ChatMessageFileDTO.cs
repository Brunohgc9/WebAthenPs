using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.DTOs.Components.Chats
{
    public class ChatMessageFileDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FileRoute { get; set; }

        public ChatMessageDto ChatMessage { get; set; }
        public Guid MessageId { get; set; }
    }
}
