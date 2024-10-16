using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.DTOs.Components.Chats
{
    public class ChatParticipantDTO
    {
        public Guid Id { get; set; } // ID do participante
        public Guid ChatId { get; set; }
        public ChatDTO? Chat { get; set; }
        public string UserId { get; set; } // UserId como string
    }

}
