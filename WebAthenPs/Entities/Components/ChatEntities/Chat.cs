using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebAthenPs.API.Entities.Clients;
using WebAthenPs.API.Entities.Professional;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Components.ChatEntities;

namespace WebAthenPs.API.Entities
{
    public class Chat
    {
        public Guid ChatId { get; set; }

        public List<ChatParticipant> Participants { get; set; } = new List<ChatParticipant>();

        public List<Message>? Messages { get; set; } = new List<Message>();
    }
}
