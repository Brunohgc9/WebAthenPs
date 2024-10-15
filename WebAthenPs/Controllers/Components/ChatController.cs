using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAthenPs.API.Repositories.Interfaces.ChatImplementation;
using WebAthenPs.Models.DTOs.Components.Chats;
using WebAthenPs.API.Entities.Components.ChatEntities;
using WebAthenPs.API.Entities;

namespace WebAthenPs.API.Controllers.Components
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatRepository _chatRepository;

        public ChatController(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateChat([FromBody] ChatDTO chatDto)
        {
            if (chatDto == null) return BadRequest("Chat inválido.");

            var chat = new Chat
            {
                ChatId = Guid.NewGuid(),
                Participants = new List<ChatParticipant>(),
                Messages = new List<Message>()
            };

            // Adicionar participantes
            foreach (var participant in chatDto.Participants)
            {
                chat.Participants.Add(new ChatParticipant
                {
                    ChatId = chat.ChatId,
                    UserId = participant.UserId
                });
            }

            var createdChat = await _chatRepository.CreateChatAsync(chat);
            return CreatedAtAction(nameof(GetChat), new { chatId = createdChat.ChatId }, createdChat);
        }

        [HttpGet("{chatId}")]
        public async Task<IActionResult> GetChat(Guid chatId)
        {
            var chat = await _chatRepository.GetChatByIdAsync(chatId);
            if (chat == null) return NotFound("Chat não encontrado.");

            // Mapear para DTO
            var chatDto = new ChatDTO
            {
                ChatId = chat.ChatId,
                Participants = chat.Participants.Select(p => new ChatParticipantDTO
                {
                    ChatId = p.ChatId,
                    UserId = p.UserId
                }).ToList(),
                Messages = chat.Messages.Select(m => new MessageDTO
                {
                    MessageId = m.MessageId,
                    Content = m.Content,
                    Timestamp = m.Timestamp,
                    SenderId = m.SenderId,
                    ChatId = m.ChatId
                }).ToList()
            };

            return Ok(chatDto);
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetChatsByUserId(string userId)
        {
            var chats = await _chatRepository.GetChatsByUserIdAsync(userId);
            return Ok(chats);
        }

        [HttpPost("{chatId}/message")]
        public async Task<IActionResult> SendMessage(Guid chatId, [FromBody] MessageDTO messageDto)
        {
            if (messageDto == null) return BadRequest("Mensagem inválida.");

            var message = new Message
            {
                Content = messageDto.Content,
                SenderId = messageDto.SenderId,
                ChatId = chatId
            };

            var createdMessage = await _chatRepository.AddMessageAsync(message);
            return CreatedAtAction(nameof(GetMessagesByChatId), new { chatId = chatId }, createdMessage);
        }

        [HttpGet("{chatId}/messages")]
        public async Task<IActionResult> GetMessagesByChatId(Guid chatId)
        {
            var messages = await _chatRepository.GetMessagesByChatIdAsync(chatId);
            return Ok(messages);
        }

        [HttpPost("{chatId}/participant")]
        public async Task<IActionResult> AddParticipant(Guid chatId, [FromBody] ChatParticipantDTO participantDto)
        {
            if (participantDto == null) return BadRequest("Participante inválido.");

            var participant = new ChatParticipant
            {
                ChatId = chatId,
                UserId = participantDto.UserId
            };

            await _chatRepository.AddParticipantAsync(participant);
            return NoContent();
        }
    }
}
