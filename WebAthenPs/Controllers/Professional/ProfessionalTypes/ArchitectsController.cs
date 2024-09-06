using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes;
using WebAthenPs.API.Mappings.MappingProfessionalsDTO.MappingProfessionalTypes;
using WebAthenPs.API.Repositories.Interfaces;
using WebAthenPs.Models.DTOs.Professional.ProfessionalTypes.Architect;

[Route("api/[controller]")]
[ApiController]
public class ArchitectsController : ControllerBase
{
    private readonly IArchitectRepository _architectRepository;

    public ArchitectsController(IArchitectRepository architectRepository)
    {
        _architectRepository = architectRepository;
    }

    [HttpGet]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<IEnumerable<GeneralArchitectDTO>>> GetAll()
    {
        try
        {
            var architects = await _architectRepository.GetAllAsync();
            if (architects == null || !architects.Any())
            {
                return NotFound("Nenhum arquiteto encontrado.");
            }

            var architectsDTO = architects.ConverterArquitetosParaDTO();
            return Ok(architectsDTO);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados. Detalhes: " + ex.Message);
        }
    }

    [HttpGet("{id:Guid}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult<GeneralArchitectDTO>> GetById(Guid id)
    {
        try
        {
            var architect = await _architectRepository.GetByIdAsync(id);
            if (architect == null)
            {
                return NotFound("Arquiteto não encontrado.");
            }
            var architectDTO = architect.ConverterArquitetoParaDTO();
            return Ok(architectDTO);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados. Detalhes: " + ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<GeneralArchitectDTO>> Create([FromBody] RegisterArchitectModel model)
    {
        if (model == null || !ModelState.IsValid)
            return BadRequest("Dados inválidos.");

        var architect = model.CriarArquitetoEmDTO();

        try
        {
            await _architectRepository.CreateAsync(architect);

            var createdDto = architect.ConverterArquitetoParaDTO();

            return CreatedAtAction(nameof(GetById), new { id = createdDto.ArchId }, createdDto);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao criar arquiteto: {ex.Message}");
        }
    }

    [HttpPut("{id:Guid}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult> Update(Guid id, [FromBody] GeneralArchitectDTO architectDTO)
    {
        try
        {
            if (id != architectDTO.ArchId)
            {
                return BadRequest("ID do arquiteto não corresponde.");
            }

            var existingArchitect = await _architectRepository.GetByIdAsync(id);
            if (existingArchitect == null)
            {
                return NotFound("Arquiteto não encontrado.");
            }

            var architect = new Architect
            {
                ArchId = architectDTO.ArchId,
                genericId = architectDTO.genericId,
                RegistroConselho = architectDTO.RegistroConselho,
                Especialidade = architectDTO.Especialidade
            };

            await _architectRepository.UpdateAsync(architect);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao atualizar o arquiteto. Detalhes: " + ex.Message);
        }
    }

    [HttpDelete("{id:Guid}")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<ActionResult> Delete(Guid id)
    {
        try
        {
            var existingArchitect = await _architectRepository.GetByIdAsync(id);
            if (existingArchitect == null)
            {
                return NotFound("Arquiteto não encontrado.");
            }

            await _architectRepository.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao excluir o arquiteto. Detalhes: " + ex.Message);
        }
    }
}
