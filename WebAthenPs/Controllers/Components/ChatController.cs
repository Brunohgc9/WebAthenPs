using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAthenPs.API.Repositories.Interfaces.ChatImplementation;
using WebAthenPs.Models.DTOs.Components.Chats;
using WebAthenPs.API.Mappings.MappingComponentDTO;
using WebAthenPs.API.Entities.Components.ChatEntities;

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

            // Cria o chat a partir do DTO
            var chat = chatDto.CriarChatEmDTO();

            // Cria o chat no repositório e o ChatId é gerado automaticamente
            var createdChat = await _chatRepository.CreateChatAsync(chat);

            // Vincula o ChatId gerado a todos os participantes e mensagens
            foreach (var participant in createdChat.Participants)
            {
                participant.ChatId = createdChat.ChatId;
            }
            foreach (var message in createdChat.Messages)
            {
                message.ChatId = createdChat.ChatId;
            }

            // Retorna o chat criado com o ID correto
            var createdChatDTO = createdChat.ConverterChatParaDTO();

            return CreatedAtAction(nameof(GetChat), new { chatId = createdChatDTO.ChatId }, createdChatDTO);
        }



        [HttpGet("{chatId}")]
        public async Task<IActionResult> GetChat(Guid chatId)
        {
            var chat = await _chatRepository.GetChatByIdAsync(chatId);
            if (chat == null) return NotFound("Chat não encontrado.");

            var chatDto = chat.ConverterChatParaDTO();
            return Ok(chatDto);
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetChatsByUserId(string userId)
        {
            var chats = await _chatRepository.GetChatsByUserIdAsync(userId);
            var chatsDto = chats.ConverterChatsParaDTO();

            return Ok(chatsDto);
        }

        [HttpPost("{chatId}/message")]
        public async Task<IActionResult> SendMessage(Guid chatId, [FromBody] MessageDTO messageDto)
        {
            if (messageDto == null) return BadRequest("Mensagem inválida.");

            var message = messageDto.CriarMensagemEmDTO();
            message.ChatId = chatId;

            var createdMessage = await _chatRepository.AddMessageAsync(message);
            var createdMessageDTO = createdMessage.ConverterMensagemParaDTO();

            return CreatedAtAction(nameof(GetMessagesByChatId), new { chatId }, createdMessageDTO);
        }

        [HttpGet("{chatId}/messages")]
        public async Task<IActionResult> GetMessagesByChatId(Guid chatId)
        {
            var messages = await _chatRepository.GetMessagesByChatIdAsync(chatId);
            var messagesDto = messages.ConverterMensagensParaDTO();

            return Ok(messagesDto);
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
