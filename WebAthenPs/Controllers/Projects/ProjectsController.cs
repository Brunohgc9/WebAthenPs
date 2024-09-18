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

        public ProjectsController(IProjectRepository projectRepository, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _projectRepository = projectRepository;
            _userManager = userManager;
            _context = context;
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

        // Criar um novo projeto
        [HttpPost]
        public async Task<ActionResult<ProjectsDTO>> CreateProject([FromBody] RegisterProjectModel model)
        {
            if (model == null || !ModelState.IsValid)
                return BadRequest("Dados inválidos.");

            // Obtém o UserId do usuário autenticado
            var userId = _userManager.GetUserId(User);

            // Encontra o ClientId associado ao UserId
            var client = await _context.Clients.FirstOrDefaultAsync(c => c.UserId == userId);
            if (client == null)
                return NotFound("Cliente não encontrado.");

            var project = model.CriarProjetoEmDTO();
            project.ClientId = client.ClientId;

            try
            {
                await _projectRepository.CreateNewProject(project);

                var createdDto = project.ConverterProjetoParaDTO();

                return CreatedAtAction(nameof(GetById), new { id = createdDto.ProjectId }, createdDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao criar projeto: {ex.Message}");
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
    }
}
