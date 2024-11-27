using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs.Project;
using WebAthenPs.Models.DTOs.User;

namespace WebAthenPs.Models.DTOs.Components.Chats
{
    public class ChatDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } // Data de criação do chat
        public List<ApplicationUserDTO> User { get; set; } // Lista de IDs dos usuários no chat
        public List<string> userId { get; set; }
        public List<ChatMessageDto> Messages { get; set; }
        public ProjectsDTO Project { get; set; }
        public int? ProjectId { get; set; }
        public bool IsGeneral { get; set; }


    }
}
