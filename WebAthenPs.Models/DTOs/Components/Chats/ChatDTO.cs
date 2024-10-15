using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.DTOs.Components.Chats
{
    public class ChatDTO
    {
        public Guid ChatId { get; set; }
        public List<ChatParticipantDTO> Participants { get; set; } = new List<ChatParticipantDTO>();
        public List<MessageDTO> Messages { get; set; } = new List<MessageDTO>();
    }
}
