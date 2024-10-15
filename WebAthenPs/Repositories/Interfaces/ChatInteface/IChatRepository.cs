using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAthenPs.API.Entities;
using WebAthenPs.API.Entities.Components.ChatEntities;

namespace WebAthenPs.API.Repositories.Interfaces.ChatImplementation
{
    public interface IChatRepository
    {
        Task<Chat> CreateChatAsync(Chat chat);
        Task<Chat> GetChatByIdAsync(Guid chatId);
        Task<IEnumerable<Chat>> GetChatsByUserIdAsync(string userId);
        Task<Message> AddMessageAsync(Message message);
        Task<IEnumerable<Message>> GetMessagesByChatIdAsync(Guid chatId);
        Task<ChatParticipant> AddParticipantAsync(ChatParticipant participant);
    }
}
