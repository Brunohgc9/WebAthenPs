﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAthenPs.API.Hubs.HubServices;
using WebAthenPs.API.Entities.Components.ChatEntities;
using WebAthenPs.API.Data;

namespace WebAthenPs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly HubService _hubService;
        private readonly ApplicationDbContext _context;

        public ChatController(HubService hubService, ApplicationDbContext context)
        {
            _hubService = hubService;
            _context = context;
        }

        // Obter membros de um chat específico
        [HttpGet("GetMembers/{chatId}")]
        public IActionResult GetMembers(Guid chatId)
        {
            var members = _hubService.GetMembers(chatId);
            return Ok(members);
        }

        // Criar um novo chat
        [HttpPost("CreateChat")]
        public async Task<IActionResult> CreateChat()
        {
            var creatorUserId = HttpContext.User.Identity.Name; // Obtenha o ID do criador do contexto HTTP
            var chatId = await _hubService.CreateChatAsync(creatorUserId);
            return CreatedAtAction(nameof(GetMembers), new { chatId }, chatId);
        }


        // Adicionar usuário a um chat
        [HttpPost("AddUserToChat")]
        public async Task<IActionResult> AddUserToChat(Guid chatId, string userId)
        {
            await _hubService.AddUserToChatAsync(userId, chatId);
            return NoContent();
        }
    }
}