using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAthenPs.API.Mappings.MappingProjectDTO;
using WebAthenPs.API.Repositories.Interfaces;
using WebAthenPs.Models.DTOs;
using System.Threading.Tasks;
using System.Collections.Generic;
using WebAthenPs.Models.Models;
using WebAthenPs.API.Repositories;

namespace WebAthenPs.API.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectsController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
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

            var project = MappingProjectDTO.CriarProjetoEmDTO(model);

            try
            {
                await _projectRepository.CreateNewProject(project);

                var createdDto = MappingProjectDTO.ConverterProjetoParaDTO(project);

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
