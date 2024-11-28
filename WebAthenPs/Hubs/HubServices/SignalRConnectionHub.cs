    using Microsoft.AspNetCore.SignalR;
    using System;
    using System.Threading.Tasks;
    using WebAthenPs.API.Entities;
using WebAthenPs.API.Entities.Components.ChatEntities;
using WebAthenPs.API.Hubs.HubServices;
using WebAthenPs.Models.DTOs.Components.Chats;

    namespace WebAthenPs.API.Hubs
    {
        public class SignalRConnectionHub : Hub
        {
            private readonly HubService _hubService;

            public SignalRConnectionHub(HubService hubService)
            {
                _hubService = hubService;
            }

            // Método chamado quando um usuário se conecta
            public override async Task OnConnectedAsync()
            {
                var userId = Context.UserIdentifier; // Identificador do usuário autenticado
                _hubService.AddConnection(Context.ConnectionId, userId);
                await base.OnConnectedAsync();
            }

            // Método chamado quando um usuário se desconecta
            public override async Task OnDisconnectedAsync(Exception exception)
            {
                _hubService.RemoveConnection(Context.ConnectionId);
                await base.OnDisconnectedAsync(exception);
            }

            // Método para obter o ConnectionId
            public async Task<string> GetConnectionId()
            {
                return Context.ConnectionId; // Retorna o ConnectionId do usuário
            }




            // Cria um novo chat
            public async Task<Guid> CreateChat(string userId)
            {
                var creatorUserId = Context.UserIdentifier; // Obtém o ID do criador
                return await _hubService.CreateChatAsync(userId);
            }

            // Adiciona um usuário a um chat
            public async Task AddUserToChat(Guid chatId, string userId)
            {
                await _hubService.AddUserToChatAsync(userId, chatId);
                await Clients.Group(chatId.ToString()).SendAsync("UserAdded", userId); // Notifica os membros do chat
            }

        // Envia uma mensagem a um chat
        public async Task SendMessage(string userId, Guid chatId, string message)
        {
            string? fileRoute = null;  // Inicializa com null, já que não há arquivo

            // Chama o método para adicionar a mensagem sem arquivo
            await _hubService.AddMessageAsync(userId, chatId, message, fileRoute);

            // Envia a mensagem para o grupo
            await Clients.Group(chatId.ToString()).SendAsync("ReceiveMessage", userId, message);
        }


        public async Task<List<ChatMessageDto>> GetChatMessages(string userId, Guid chatId)
        {
            var messages = _hubService.GetMessagesByChatId(chatId);

            var messageDtos = messages.Select(msg => new ChatMessageDto
            {
                Id = msg.Id,
                UserId = msg.UserId,
                ChatId = msg.ChatId,
                Message = msg.Message,
                SentAt = msg.SentAt, // Caso exista a propriedade
                ChatMessageFile = msg.ChatMessageFile == null ? null : new ChatMessageFileDTO
                {
                    Id = msg.ChatMessageFile.Id,
                    Name = msg.ChatMessageFile.Name,
                    FileRoute = msg.ChatMessageFile.FileRoute,
                    MessageId = msg.ChatMessageFile.MessageId
                }
            }).ToList();


            return messageDtos;
        }

        public async Task JoinChat(Guid chatId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, chatId.ToString());
        }

        // Método para sair de um grupo (chat)
        public async Task LeaveChat(Guid chatId)
            {
                await Groups.RemoveFromGroupAsync(Context.ConnectionId, chatId.ToString());
            }
            // Método para obter todos os chats do usuário
            public async Task<List<ChatDto>> GetUserChats(string userId)
            {
                // Obtém os chats do usuário a partir do banco de dados
                var userChats = _hubService.GetChatsByUserId(userId);

                // Mapeia os chats para o DTO
                var chatDtos = userChats.Select(chat => new ChatDto
                {
                    Id = chat.Id,
                    // Outros campos podem ser mapeados aqui, como o nome do chat, último remetente, etc.
                }).ToList();

                return chatDtos;
            }

        // Método para obter o ChatId associado ao ProjectId
        public async Task<List<ChatDto>> GetChatsByProjectId(int projectId)
        {
            // Chama o serviço para obter os chats associados ao projeto
            var chats = await _hubService.GetChatsByProjectIdAsync(projectId);

            // Mapeia os chats para o DTO
            var chatDtos = chats.Select(chat => new ChatDto
            {
                Id = chat.Id,
                // Aqui você pode adicionar outros campos que quiser retornar no DTO, como o nome do chat, etc.
            }).ToList();

            return chatDtos;
        }
        public async Task SendMessageWithFile(string userId, Guid chatId, string message, string fileRoute)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fileRoute))
                    throw new ArgumentException("File route is empty.");

                // Adiciona a mensagem ao chat com a rota do arquivo
                await _hubService.AddMessageAsync(userId, chatId, message, fileRoute);

                // Notifica os clientes no grupo sobre a nova mensagem
                await Clients.Group(chatId.ToString()).SendAsync("ReceiveMessage", userId, message, fileRoute);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SendMessageWithFile: {ex.Message}");
                throw;
            }
        }

    }






}

