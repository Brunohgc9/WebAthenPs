using WebAthenPs.Models.DTOs.Components.Chats;

namespace WebAthenPs.Project.Services.Interfaces.Chats
{
    public interface IChatService
    {
        Task<ChatDTO> CreateChatAsync(ChatDTO chatDto);
        Task<List<ChatDTO>> GetChatsByUserIdAsync(string userId);
        Task<MessageDTO> SendMessageAsync(MessageDTO messageDto);
        Task<ChatDTO> GetChatByIdAsync(Guid chatId); 
        Task DeleteChatAsync(Guid chatId); 
        Task<IEnumerable<MessageDTO>> GetMessagesAsync(Guid chatId);
    }
}
