using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Mappings.MappingProjectDTO;
using WebAthenPs.API.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Linq;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Clients;
using WebAthenPs.Models.DTOs.Project;
using WebAthenPs.API.Entities.Project;
using WebAthenPs.API.Entities.Professional;
using WebAthenPs.Models.DTOs.Professional;
using WebAthenPs.API.Hubs.HubServices;
using WebAthenPs.Models.DTOs.Components.Chats;
using WebAthenPs.API.Entities.Project.Steps;

namespace WebAthenPs.API.Controllers.Projects
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectRepository _projectRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly HubService _hubService;

        public ProjectsController(IProjectRepository projectRepository, UserManager<ApplicationUser> userManager, ApplicationDbContext context, HubService hubService)
        {
            _projectRepository = projectRepository;
            _userManager = userManager;
            _context = context;
            _hubService = hubService;
        }



        // Atualizar um projeto, incluindo profissionais
        [HttpPut("{id:int}")]
        public async Task<ActionResult<ProjectsDTO>> UpdateProject(int id, [FromBody] ProjectsDTO dto)
        {
            if (dto == null || !ModelState.IsValid)
                return BadRequest("Dados inválidos.");

            try
            {
                var existingProject = await _projectRepository.GetById(id);
                if (existingProject == null)
                    return NotFound("Projeto não encontrado.");

                // Atualize os campos do projeto
                existingProject.ProjectName = dto.ProjectName;

                // Atualize os profissionais do projeto
                if (dto.ProjectProfessionals != null && dto.ProjectProfessionals.Any())
                {
                    existingProject.ProjectProfessionals.Clear(); // Remove os profissionais atuais
                    foreach (var projectProfessionalDto in dto.ProjectProfessionals)
                    {
                        var professional = await _context.GenericProfessionals.FindAsync(projectProfessionalDto.ProfessionalId);
                        if (professional != null)
                        {
                            existingProject.ProjectProfessionals.Add(new ProjectProfessional
                            {
                                ProjectId = existingProject.ProjectId,
                                ProfessionalId = professional.Id
                            });
                        }
                        else
                        {
                            Console.WriteLine($"Profissional não encontrado com ID: {projectProfessionalDto.ProfessionalId}");
                        }
                    }
                }

                // Salvar alterações no repositório
                await _projectRepository.UpdateProject(existingProject);

                var updatedDto = existingProject.ConverterProjetoParaDTO();
                return Ok(updatedDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao atualizar o projeto: {ex.Message}");
            }
        }


        // Adicionar profissionais a um projeto
        // Adicionar um profissional a um projeto





        // Obter todos os projetos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectsDTO>>> GetAll()
        {
            try
            {
                var projects = await _projectRepository.GetAll();
                if (projects == null || !projects.Any())
                {
                    return NotFound("Não foi possível encontrar projetos.");
                }
                var projectsDTO = projects.ConverterProjetosParaDTO();
                return Ok(projectsDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados. Detalhes: " + ex.Message);
            }
        }

        // Obter projeto por ID
        [HttpGet("id/{id:int}")]
        public async Task<ActionResult<ProjectsDTO>> GetById(int id)
        {
            try
            {
                var project = await _projectRepository.GetById(id);
                if (project == null)
                {
                    return NotFound("Projeto não encontrado.");
                }
                var projectDTO = project.ConverterProjetoParaDTO();
                return Ok(projectDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados. Detalhes: " + ex.Message);
            }
        }

        // Obter projetos por status
        [HttpGet("status/{status}")]
        public async Task<ActionResult<IEnumerable<ProjectsDTO>>> GetByStatus(string status)
        {
            try
            {
                var projects = await _projectRepository.GetByStatus(status);
                if (projects == null || !projects.Any())
                {
                    return NotFound("Nenhum projeto encontrado com o status informado.");
                }
                var projectsDTO = projects.ConverterProjetosParaDTO();
                return Ok(projectsDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados. Detalhes: " + ex.Message);
            }
        }

        // Obter projetos de um cliente logado
        [HttpGet("clientProjects")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<IEnumerable<ProjectsDTO>>> GetProjectsByLoggedInUser()
        {
            try
            {
                // Obtém o userId do usuário logado
                var userId = _userManager.GetUserId(User);

                // Usa LINQ para obter o ClientId associado ao userId
                var clientId = await _context.Clients
                                             .Where(c => c.UserId == userId)
                                             .Select(c => c.ClientId)
                                             .FirstOrDefaultAsync();

                if (clientId == default)
                {
                    return NotFound("Cliente não encontrado para o usuário logado.");
                }

                // Busca os projetos relacionados ao ClientId usando LINQ
                var projects = await _context.Projects
                                             .Where(p => p.ClientId == clientId)
                                             .ToListAsync();

                if (!projects.Any())
                {
                    return NotFound("Nenhum projeto encontrado para o cliente logado.");
                }

                // Converte os projetos para DTO
                var projectsDTO = projects.ConverterProjetosParaDTO();
                return Ok(projectsDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados. Detalhes: " + ex.Message);
            }
        }

        // Obter projetos por área
        [HttpGet("area/{area:decimal}")]
        public async Task<ActionResult<IEnumerable<ProjectsDTO>>> GetByArea(decimal area)
        {
            try
            {
                var projects = await _projectRepository.GetByArea(area);
                if (projects == null || !projects.Any())
                {
                    return NotFound("Nenhum projeto encontrado com a área informada.");
                }
                var projectsDTO = projects.ConverterProjetosParaDTO();
                return Ok(projectsDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados. Detalhes: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ProjectsDTO>> CreateProject([FromBody] RegisterProjectModel model)
        {
            if (model == null || !ModelState.IsValid)
                return BadRequest("Dados inválidos.");

            model.ActStep = "Etapa 1";

            // Obtém o UserId do usuário autenticado
            var userId = _userManager.GetUserId(User);

            // Encontra o ClientId associado ao UserId
            var client = await _context.Clients.FirstOrDefaultAsync(c => c.UserId == userId);
            if (client == null)
                return NotFound("Cliente não encontrado.");

            // Converte o modelo para a entidade de projeto
            var project = model.CriarProjetoEmDTO();
            project.ClientId = client.ClientId;

            // Define a data de criação do projeto
            project.StartDate = DateTime.UtcNow;  // Define a data de criação como a data atual

            try
            {
                // Cria o projeto no banco
                await _projectRepository.CreateNewProject(project);

                // Cria e associa o ProjectSteps ao projeto
                var projectSteps = new ProjectSteps
                {
                    Id = Guid.NewGuid(),
                    ProjectId = project.ProjectId, // Associa o ProjectSteps ao ProjectId criado
                };
                _context.ProjectSteps.Add(projectSteps);
                await _context.SaveChangesAsync();

                // Cria um chat geral para o projeto, passando o ProjectId
                var chatId = await _hubService.CreateChatAsync(client.UserId, project.ProjectId, isGeneral: true);

                // Retorna o projeto criado como DTO
                var createdDto = project.ConverterProjetoParaDTO();
                createdDto.ProjectSteps.Id = projectSteps.Id; // Inclui o ID do ProjectSteps no DTO
                return CreatedAtAction(nameof(GetById), new { id = createdDto.ProjectId }, createdDto);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict($"Erro ao criar chat: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao criar projeto: {ex.Message}");
            }
        }






        [HttpPost("{projectId:int}/professionals")]
        public async Task<ActionResult<ProjectProfessionalDTO>> AddProfessionalToProject(int projectId, [FromBody] ProjectProfessionalDTO projectProfessionalDTO)
        {
            if (projectProfessionalDTO == null || !ModelState.IsValid)
                return BadRequest("Dados inválidos.");

            try
            {
                var existingProject = await _projectRepository.GetById(projectId);
                if (existingProject == null)
                    return NotFound("Projeto não encontrado.");

                var professional = await _context.GenericProfessionals.FindAsync(projectProfessionalDTO.ProfessionalId);
                if (professional == null)
                    return NotFound("Profissional não encontrado.");

                var projectProfessional = projectProfessionalDTO.ConverterDTOParaProjectProfessional();
                projectProfessional.ProjectId = projectId;
                projectProfessional.Professional = professional;

                await _projectRepository.AddProfessionalToProject(projectProfessional);

                // 1. Adicionar o profissional ao chat geral do projeto
                var clientUserId = existingProject.Client.UserId;

                if (!Guid.TryParse(clientUserId, out Guid clientUserIdGuid))
                    return BadRequest("O UserId do cliente não é um GUID válido.");

                if (!Guid.TryParse(professional.UserId, out Guid professionalUserIdGuid))
                    return BadRequest("O UserId do profissional não é um GUID válido.");

                var generalChatId = await _hubService.GetChatIdByProjectIdAsync(projectId, isGeneral: true);
                if (!generalChatId.HasValue)
                {
                    // Se o chat geral não existir, cria o chat geral
                    generalChatId = await _hubService.CreateChatAsync(clientUserIdGuid.ToString(), projectId, isGeneral: true);
                }

                // Adiciona o profissional ao chat geral
                await _hubService.AddUserToChatAsync(professionalUserIdGuid.ToString(), generalChatId.Value, projectId, isGeneralChat: true);

                // 2. Criar um chat entre o cliente e o profissional, se não existir
                var existingClientProfessionalChatId = await _hubService.GetChatIdByProjectIdAsync(
                    projectId,
                    isGeneral: false,
                    clientUserId: clientUserIdGuid,
                    professionalUserId: professionalUserIdGuid
                );

                if (!existingClientProfessionalChatId.HasValue)
                {
                    // Cria um novo chat específico entre o cliente e o profissional
                    var chatId = await _hubService.CreateChatAsync(clientUserIdGuid.ToString(), projectId, isGeneral: false);

                    // Adiciona o profissional e o cliente ao novo chat
                    await _hubService.AddUserToChatAsync(professionalUserIdGuid.ToString(), chatId, projectId, isGeneralChat: false);
                    await _hubService.AddUserToChatAsync(clientUserIdGuid.ToString(), chatId, projectId, isGeneralChat: false);
                }
                else
                {
                    // Se o chat já existir, apenas adiciona o profissional ao chat existente
                    await _hubService.AddUserToChatAsync(professionalUserIdGuid.ToString(), existingClientProfessionalChatId.Value, projectId, isGeneralChat: false);
                }

                // **Chamando o StepOne aqui**
                var stepOneResult = await StepOne(projectId, professional.Id);
                if (stepOneResult is NotFoundObjectResult || stepOneResult is BadRequestObjectResult)
                {
                    return stepOneResult; // Retorna o erro de StepOne, se houver
                }

                // Converte a entidade para DTO
                var createdDto = projectProfessional.ConverterProjectProfessionalParaDTO();
                return CreatedAtAction(nameof(GetById), new { id = createdDto.ProjectId }, createdDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao adicionar profissional ao projeto: {ex.Message}");
            }
        }














        // Deletar projeto
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteProject(int id)
        {
            try
            {
                var existingProject = await _projectRepository.GetById(id);
                if (existingProject == null)
                {
                    return NotFound("Projeto não encontrado.");
                }

                await _projectRepository.DeleteProject(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao deletar o projeto. Detalhes: " + ex.Message);
            }
        }

        [HttpGet("{projectId:int}/professionals")]
        public async Task<ActionResult<IEnumerable<GenericProfessionalDTO>>> GetProfessionalsByProject(int projectId)
        {
            try
            {
                var professionals = await _projectRepository.GetProfessionalsByProject(projectId);

                if (professionals == null || !professionals.Any())
                {
                    // Retorna uma lista vazia ao invés de NotFound
                    return Ok(Enumerable.Empty<GenericProfessionalDTO>());
                }

                return Ok(professionals);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar os profissionais do projeto: {ex.Message}");
            }
        }

        [HttpGet("{projectId:int}/chat")]
        public async Task<ActionResult<ChatDto>> GetChatByProjectId(int projectId)
        {
            try
            {
                // Busca o projeto no banco de dados com o projectId fornecido
                var existingProject = await _context.Projects
                    .FirstOrDefaultAsync(p => p.ProjectId == projectId); // Supondo que 'Projects' seja o DbSet de projetos

                if (existingProject == null)
                {
                    return NotFound("Projeto não encontrado.");
                }

                // Tenta obter o chat associado ao projeto com o projectId fornecido
                var chatId = await _hubService.GetChatIdByProjectIdAsync(existingProject.ProjectId, isGeneral: true);

                // Verifica se o chatId retornado é nulo e substitui por Guid.Empty se necessário
                if (chatId == null || chatId == Guid.Empty)
                {
                    return NotFound("Chat não encontrado para o projeto.");
                }

                // Cria e retorna o DTO de chat com base no chatId encontrado
                var chatDto = new ChatDto
                {
                    Id = chatId.Value,  // Usa .Value para acessar o valor do Guid? (nulo garantido)
                    ProjectId = projectId
                };

                return Ok(chatDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar o chat do projeto: {ex.Message}");
            }
        }

        [HttpGet("{projectId:int}/individual-chats")]
        public async Task<ActionResult<List<ChatDto>>> GetIndividualChatsByProjectId(int projectId)
        {
            try
            {
                // Busca o projeto no banco de dados com o projectId fornecido
                var existingProject = await _context.Projects
                    .FirstOrDefaultAsync(p => p.ProjectId == projectId); // Supondo que 'Projects' seja o DbSet de projetos

                if (existingProject == null)
                {
                    return NotFound("Projeto não encontrado.");
                }

                // Tenta obter todos os chats associados ao projeto com o projectId fornecido
                var chatIds = await _hubService.GetChatIdsByProjectIdAsync(existingProject.ProjectId, isGeneral: false);

                // Verifica se algum chat foi encontrado
                if (chatIds == null || !chatIds.Any())
                {
                    return NotFound("Nenhum chat individual encontrado para este projeto.");
                }

                // Cria a lista de DTOs para cada chat encontrado
                var chatDtos = new List<ChatDto>();

                foreach (var chatId in chatIds)
                {
                    var chatDto = new ChatDto
                    {
                        Id = chatId,  // Adiciona o chatId na propriedade Id do DTO
                        ProjectId = projectId
                    };

                    chatDtos.Add(chatDto);
                }

                return Ok(chatDtos);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar os chats individuais do projeto: {ex.Message}");
            }
        }


        private async Task<ActionResult> StepOne(int projectId, int professionalId)
        {
            try
            {
                // Verifica se o projeto existe
                var existingProject = await _projectRepository.GetById(projectId);
                if (existingProject == null)
                    return NotFound("Projeto não encontrado.");

                // Verifica se o profissional existe
                var professional = await _context.GenericProfessionals.FindAsync(professionalId);
                if (professional == null)
                    return NotFound("Profissional não encontrado.");

                // Verifica se o profissional é um arquiteto
                if (!professional.ProfessionalTypes.Contains("Arquiteto") && !professional.ProfessionalTypes.Contains("Architect"))
                {
                    return BadRequest("Somente um arquiteto pode ser adicionado a este projeto.");
                }

                // Verifica se já existe um arquiteto atribuído no Step1
                var step1HireArchitect = existingProject.ProjectSteps?.Step1HireArchitect;
                if (step1HireArchitect != null)
                {
                    return BadRequest("Já existe um arquiteto atribuído para a Etapa 1 deste projeto.");
                }

                // Verifica se o tipo do profissional e o ID do arquiteto estão definidos
                if (professional.GenericProfessionalType == null || professional.GenericProfessionalType.ArchitectId == null)
                {
                    return BadRequest("O tipo profissional ou o arquiteto não estão definidos.");
                }

                // Cria um novo Step1HireArchitect
                step1HireArchitect = new Step1HireArchitect
                {
                    Id = Guid.NewGuid(),
                    ArchitectId = professional.GenericProfessionalType.ArchitectId ?? Guid.Empty,  // Usa Guid.Empty se for nulo
                    ProjectStepsId = existingProject.ProjectSteps.Id,
                    Description = "Arquiteto contratado para o projeto",
                    IsFinished = true
                };

                // Adiciona o Step1HireArchitect à base de dados
                await _context.Step1HireArchitects.AddAsync(step1HireArchitect);

                // Atualiza o ProjectSteps com o novo Step1HireArchitectId
                existingProject.ProjectSteps.Step1HireArchitectId = step1HireArchitect.Id;
                _context.ProjectSteps.Update(existingProject.ProjectSteps);

                // Atualiza o ActStep do projeto
                existingProject.ActStep = "Etapa 2";
                _context.Projects.Update(existingProject);

                // Salva as alterações no banco de dados
                await _context.SaveChangesAsync();

                return Ok("Arquiteto registrado com sucesso na Etapa 1 e projeto avançado para a Etapa 2.");
            }
            catch (Exception ex)
            {
                // Retorna erro se ocorrer uma exceção
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao registrar arquiteto na Etapa 1: {ex.Message}");
            }
        }





    }
}