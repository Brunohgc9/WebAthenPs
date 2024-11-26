    using Microsoft.AspNetCore.Http;
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
                var creatorUserId = HttpContext.User.Identity?.Name; // Verifique se o usuário está autenticado
                if (string.IsNullOrEmpty(creatorUserId))
                {
                    return Unauthorized(); // Retorna 401 se o usuário não estiver autenticado
                }

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

            // Obter todos os chats do usuário autenticado
            [HttpGet("GetUserChats")]
            public IActionResult GetUserChats()
            {
                var userId = HttpContext.User.Identity?.Name; // Verifique se o usuário está autenticado
                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized(); // Retorna 401 se o usuário não estiver autenticado
                }

                var chats = _hubService.GetChatsByUserId(userId);
                return Ok(chats);
            }

        //[HttpPost("AddProfessionalToProject")]
        //public async Task<IActionResult> AddProfessionalToProject(int projectId, string professionalId)
        //{
        //    var project = _context.Projects.FirstOrDefault(p => p.Id == projectId);
        //    if (project == null)
        //        return NotFound("Projeto não encontrado.");

        //    // Adiciona o profissional ao projeto
        //    var projectProfessional = new ProjectProfessional
        //    {
        //        Id = Guid.NewGuid(),
        //        ProjectId = projectId,
        //        ProfessionalId = professionalId
        //    };

        //    _context.ProjectProfessionals.Add(projectProfessional);

        //    // Recupera o cliente associado ao projeto
        //    var clientId = project.ClientId;
        //    if (string.IsNullOrEmpty(clientId))
        //        return BadRequest("Cliente associado ao projeto não encontrado.");

        //    // Criar chat individual entre cliente e profissional
        //    var individualChatId = await _hubService.CreateChatAsync(clientId);
        //    await _hubService.AddUserToChatAsync(professionalId, individualChatId);

        //    // Adicionar o profissional ao chat geral do projeto
        //    if (project.GeneralChatId == null)
        //    {
        //        // Cria o chat geral caso não exista
        //        var generalChatId = await _hubService.CreateChatAsync(clientId);
        //        project.GeneralChatId = generalChatId;
        //    }

        //    await _hubService.AddUserToChatAsync(professionalId, project.GeneralChatId.Value);

        //    // Salvar alterações no banco
        //    await _context.SaveChangesAsync();
        //    return Ok("Profissional adicionado ao projeto e chats atualizados.");
        //}

    }


}
