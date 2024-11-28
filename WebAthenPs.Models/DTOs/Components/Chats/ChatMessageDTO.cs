using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs.User;

namespace WebAthenPs.Models.DTOs.Components.Chats
{
    public class ChatMessageDto
    {
        public Guid Id { get; set; }
        public string UserId { get; set; } // ID do usuário que enviou a mensagem
        public Guid ChatId { get; set; } // ID do chat
        public string Message { get; set; } // Conteúdo da mensagem
        public DateTime SentAt { get; set; } // Data e hora do envio
        public ApplicationUserDTO User { get; set; }
        public ChatDto Chat { get; set; }
        public ChatMessageFileDTO? ChatMessageFile { get; set; }
        public Guid? ChatMessageFileId { get; set; }
    }
}

