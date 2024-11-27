using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> DoesChatExistAsync(int projectId, bool isGeneral)
        {
            return await _context.Chats.AnyAsync(c => c.ProjectId == projectId && c.IsGeneral == isGeneral);
        }


        // Cria um novo chat e associa o criador a ele
        public async Task<Guid> CreateChatAsync(string creatorUserId, int? projectId = null, bool isGeneral = false)
        {
            // Verifica se já existe um chat geral para o projeto
            if (isGeneral && projectId.HasValue)
            {
                var existingGeneralChat = await _context.Chats
                    .FirstOrDefaultAsync(c => c.ProjectId == projectId && c.IsGeneral);

                if (existingGeneralChat != null)
                    throw new InvalidOperationException("Chat geral já existe para este projeto.");
            }

            // Cria uma nova instância do chat
            var chat = new Chats
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
                ProjectId = projectId,
                IsGeneral = isGeneral // Define se é chat geral
            };

            _context.Chats.Add(chat);

            // Relaciona o criador ao chat
            var chatUser = new ChatAndUsers
            {
                Id = Guid.NewGuid(),
                UserId = creatorUserId,
                ChatId = chat.Id
            };

            _context.ChatAndUsers.Add(chatUser);

            await _context.SaveChangesAsync();

            return chat.Id; // Retorna o ID do chat criado
        }





        // Adiciona um usuário a um chat existente
        public async Task AddUserToChatAsync(string userId, Guid chatId, int? projectId = null, bool isGeneralChat = false)
        {
            // Verifica se o usuário já está no chat
            if (IsUserInChat(userId, chatId))
                return; // Não adiciona se já estiver

            var chat = await _context.Chats.FirstOrDefaultAsync(c => c.Id == chatId);

            if (chat != null)
            {
                if (isGeneralChat && projectId.HasValue)
                {
                    // Se for um chat geral, atribuímos o ProjectId e marcamos como geral
                    chat.ProjectId = projectId;
                    chat.IsGeneral = true; // Marca como chat geral
                }
                else if (!isGeneralChat && projectId.HasValue)
                {
                    // Se não for um chat geral, atribuímos o ProjectId ao chat específico
                    chat.ProjectId = projectId;
                    chat.IsGeneral = false; // Marca como chat específico
                }
            }

            // Cria uma nova associação do usuário ao chat
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
            {
                throw new InvalidOperationException("Usuário não está no chat.");
            }

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

        // Obtém os chats que o usuário está associado
        public List<Chats> GetChatsByUserId(string userId)
        {
            return _context.ChatAndUsers
                .Where(cu => cu.UserId == userId)
                .Select(cu => cu.Chat)
                .ToList();
        }

        public async Task<bool> IsUserInChatAsync(string userId, string otherUserId, int projectId)
        {
            return await _context.ChatAndUsers
                .Where(cu => cu.UserId == userId)
                .Join(
                    _context.ChatAndUsers.Where(cu => cu.UserId == otherUserId),
                    cu1 => cu1.ChatId,
                    cu2 => cu2.ChatId,
                    (cu1, cu2) => cu1
                )
                .Join(
                    _context.Chats.Where(c => c.ProjectId == projectId && c.IsGeneral == false), // Verifica se o chat é específico (não geral)
                    cu => cu.ChatId,
                    chat => chat.Id,
                    (cu, chat) => cu
                )
                .AnyAsync();
        }



        public bool IsGeneralChat(Guid chatId)
        {
            var chat = _context.Chats.FirstOrDefault(c => c.Id == chatId);
            return chat != null && chat.IsGeneral;
        }

        public async Task<Guid?> GetChatIdByProjectIdAsync(int projectId, bool isGeneral)
        {
            var chat = await _context.Chats
                .Where(c => c.ProjectId == projectId && c.IsGeneral == isGeneral)
                .FirstOrDefaultAsync();

            return chat?.Id; // Retorna o chatId ou null caso não exista
        }


    }
}
