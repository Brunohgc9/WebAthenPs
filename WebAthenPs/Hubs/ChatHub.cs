using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using WebAthenPs.API.Entities;
using WebAthenPs.API.Entities.Components.ChatEntities;
using WebAthenPs.API.Repositories.Interfaces.ChatImplementation;
using WebAthenPs.Models.DTOs.Components.Chats;

namespace WebAthenPs.API.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IChatRepository _chatRepository;

        public ChatHub(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

        public async Task CreateChat(string userId)
        {
            var chat = new Chat
            {
                ChatId = Guid.NewGuid(), // Gerar novo ChatId
                Participants = new List<ChatParticipant>
                {
                    new ChatParticipant
                    {
                        UserId = userId // Adicionar o usuário que criou o chat
                    }
                }
            };

            await _chatRepository.CreateChatAsync(chat);
            await Clients.User(userId).SendAsync("ChatCreated", chat.ChatId);
        }

        public async Task SendMessage(string chatId, string content, string senderId)
        {
            var message = new Message
            {
                Content = content,
                SenderId = senderId,
                ChatId = Guid.Parse(chatId)
            };

            await _chatRepository.AddMessageAsync(message);
            await Clients.Group(chatId).SendAsync("ReceiveMessage", new MessageDTO
            {
                MessageId = message.MessageId,
                Content = message.Content,
                Timestamp = message.Timestamp,
                SenderId = message.SenderId,
                ChatId = message.ChatId
            });
        }

        public async Task JoinChat(string chatId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, chatId);
            await Clients.Group(chatId).SendAsync("UserJoined", Context.ConnectionId);
        }
    }
}
