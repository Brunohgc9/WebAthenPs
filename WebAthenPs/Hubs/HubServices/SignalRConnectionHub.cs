using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;
using WebAthenPs.API.Entities;
using WebAthenPs.API.Hubs.HubServices;

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
        public async Task SendMessage(Guid chatId, string message)
        {
            var userId = Context.UserIdentifier; // Obtém o ID do usuário
            await _hubService.AddMessageAsync(userId, chatId, message);
            await Clients.Group(chatId.ToString()).SendAsync("ReceiveMessage", userId, message);
        }

        // Método para se juntar a um grupo (chat)
        public async Task JoinChat(Guid chatId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, chatId.ToString());
        }

        // Método para sair de um grupo (chat)
        public async Task LeaveChat(Guid chatId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, chatId.ToString());
        }
    }
}
