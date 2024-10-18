using System.Collections.Concurrent;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Components.ChatEntities;

namespace WebAthenPs.API.Hubs.HubServices
{
    public class HubService
    {
        private readonly ConcurrentDictionary<string, string> ConnectionUsers = new(); // Mapeia a ConnectionId para o UserId
        private readonly ApplicationDbContext _context;

        public HubService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Adiciona uma nova conexão com o usuário
        public void AddConnection(string connectionId, string userId)
        {
            ConnectionUsers.TryAdd(connectionId, userId);
        }

        // Remove uma conexão de um usuário
        public void RemoveConnection(string connectionId)
        {
            ConnectionUsers.TryRemove(connectionId, out _);
        }

        // Cria um novo chat e associa o criador a ele
        public async Task<Guid> CreateChatAsync(string creatorUserId)
        {
            var chat = new Chats
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow
            };

            _context.Chats.Add(chat);

            // Relaciona o criador do chat ao chat recém-criado
            var chatUser = new ChatAndUsers
            {
                Id = Guid.NewGuid(),
                UserId = creatorUserId,
                ChatId = chat.Id
            };

            _context.ChatAndUsers.Add(chatUser);
            await _context.SaveChangesAsync();

            return chat.Id; // Retorna o ID do chat
        }

        // Adiciona um usuário a um chat existente
        public async Task AddUserToChatAsync(string userId, Guid chatId)
        {
            // Verifica se o usuário já está no chat
            if (IsUserInChat(userId, chatId))
                return; // Não adiciona se já estiver

            var chatUser = new ChatAndUsers
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                ChatId = chatId
            };

            _context.ChatAndUsers.Add(chatUser);
            await _context.SaveChangesAsync();
        }

        // Envia uma mensagem e a registra no banco de dados
        public async Task AddMessageAsync(string userId, Guid chatId, string message)
        {
            if (!IsUserInChat(userId, chatId))
                throw new InvalidOperationException("Usuário não está no chat.");

            var chatMessage = new ChatMessage
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                ChatId = chatId,
                Message = message
            };

            _context.ChatMessages.Add(chatMessage);
            await _context.SaveChangesAsync();
        }

        // Recupera as mensagens de um chat específico
        public List<ChatMessage> GetMessagesByChatId(Guid chatId)
        {
            return _context.ChatMessages
                .Where(cm => cm.ChatId == chatId)
                .OrderBy(cm => cm.Id)
                .ToList();
        }

        // Verifica se o usuário já está em um chat específico
        public bool IsUserInChat(string userId, Guid chatId)
        {
            return _context.ChatAndUsers.Any(cu => cu.UserId == userId && cu.ChatId == chatId);
        }

        // Obtém o UserId relacionado à ConnectionId
        public string GetUserIdByConnectionId(string connectionId)
        {
            return ConnectionUsers.TryGetValue(connectionId, out var userId) ? userId : string.Empty;
        }

        // Recupera os membros de um chat pelo ChatId
        public List<string> GetMembers(Guid chatId)
        {
            return _context.ChatAndUsers
                .Where(cu => cu.ChatId == chatId)
                .Select(cu => cu.UserId)
                .ToList();
        }
    }
}
