using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Mappings.MappingProjectDTO;
using WebAthenPs.API.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using WebAthenPs.API.Repositories;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Clients;
using WebAthenPs.Models.DTOs.Project;
using WebAthenPs.API.Entities.Project;

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
        [HttpPut("{id:int}")]
        public async Task<ActionResult<ProjectsDTO>> UpdateProject(int id, [FromBody] ProjectsDTO dto)
        {
            if (dto == null || !ModelState.IsValid)
                return BadRequest("Dados inválidos.");

            try
            {
                var project = await _projectRepository.GetById(id);
                if (project == null)
                    return NotFound("Projeto não encontrado.");

                // Atualiza o projeto com os dados fornecidos
                project.ProjectName = dto.ProjectName;
                project.ConstructionType = dto.ConstructionType;
                project.Status = dto.Status;
                project.Budget = dto.Budget;
                project.StartDate = dto.StartDate;
                project.EndDate = dto.EndDate;
                project.Description = dto.Description;
                project.Address = dto.Address;
                project.Neighborhood = dto.Neighborhood;
                project.City = dto.City;
                project.State = dto.State;
                project.PostalCode = dto.PostalCode;
                project.Country = dto.Country;
                project.ActStep = dto.Step;
                project.TotalArea = dto.TotalArea;
                project.NumberOfRooms = dto.NumberOfRooms;
                project.NumberOfBathrooms = dto.NumberOfBathrooms;

                // Atualiza o projeto no repositório
                await _projectRepository.UpdateProject(project);

                // Converte o projeto atualizado para DTO e retorna a resposta
                var updatedDto = project.ConverterProjetoParaDTO();
                return Ok(updatedDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao atualizar o projeto: {ex.Message}");
            }
        }



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

            // Obtém o UserId do usuário autenticado
            var userId = _userManager.GetUserId(User);

            // Encontra o ClientId associado ao UserId
            var client = await _context.Clients.FirstOrDefaultAsync(c => c.UserId == userId);
            if (client == null)
                return NotFound("Cliente não encontrado.");

            // Encontra o ProfessionalId do usuário, caso ele seja um profissional
            var professional = await _context.GenericProfessionals
                .FirstOrDefaultAsync(p => p.UserId == userId);

            // Cria o objeto Projecty a partir do modelo
            var project = model.CriarProjetoEmDTO();
            project.ClientId = client.ClientId;  // Define o ClientId do projeto

            try
            {
                // Cria o projeto no banco de dados
                await _projectRepository.CreateNewProject(project);

                // Registra automaticamente a ProjectConnection após o projeto ter sido criado
                var projectConnection = new ProjectConnection
                {
                    ProjectId = project.ProjectId,
                    ClientId = client.ClientId,
                    ProfessionalId = professional?.Id  // Caso seja um profissional, registra o ProfessionalId
                };

                // Registra a ProjectConnection no banco de dados
                _context.ProjectConnections.Add(projectConnection);
                await _context.SaveChangesAsync();

                var createdDto = project.ConverterProjetoParaDTO();

                return CreatedAtAction(nameof(GetById), new { id = createdDto.ProjectId }, createdDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao criar projeto: {ex.Message}");
            }
        }



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
