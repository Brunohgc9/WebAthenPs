using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs.Components;
using WebAthenPs.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using WebAthenPs.API.Entities.Components;
using WebAthenPs.API.Mappings.MappingComponentDTO;
using WebAthenPs.API.Entities.Clients;

namespace WebAthenPs.API.Controllers.Components
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProposalController : ControllerBase
    {
        private readonly IProposalRepository _proposalRepository;

        public ProposalController(IProposalRepository proposalRepository)
        {
            _proposalRepository = proposalRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProposalDTO proposalDTO)
        {
            if (proposalDTO == null || !ModelState.IsValid)
                return BadRequest("Dados inválidos.");

            try
            {
                var proposal = proposalDTO.CriarPropostaEmDTO();
                var createdProposal = await _proposalRepository.CreateAsync(proposal);
                var createdDto = createdProposal.ConverterPropostaParaDTO();
                return CreatedAtAction(nameof(GetProposal), new { id = createdDto.ProposalId }, createdDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao criar proposta: {ex.Message}");
            }
        }

        // Método PUT para aceitar uma proposta
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> AcceptProposal(Guid id)
        {
            try
            {
                var proposal = await _proposalRepository.GetByIdAsync(id);
                if (proposal == null) return NotFound("Proposta não encontrada.");

                proposal.IsAccepted = true; // Marcar como aceita
                await _proposalRepository.UpdateAsync(proposal);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao aceitar proposta: {ex.Message}");
            }
        }

        // Método DELETE para deletar uma proposta
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteProposal(Guid id)
        {
            try
            {
                var proposal = await _proposalRepository.GetByIdAsync(id);
                if (proposal == null) return NotFound("Proposta não encontrada.");

                await _proposalRepository.DeleteAsync(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao deletar proposta: {ex.Message}");
            }
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetProposal(Guid id)
        {
            try
            {
                var proposal = await _proposalRepository.GetByIdAsync(id);
                if (proposal == null) return NotFound("Proposta não encontrada.");

                var dto = proposal.ConverterPropostaParaDTO();
                return Ok(dto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar o banco de dados: {ex.Message}");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProposals()
        {
            try
            {
                var proposals = await _proposalRepository.GetAllAsync();
                var dtoList = proposals.Select(p => p.ConverterPropostaParaDTO()).ToList();
                return Ok(dtoList);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar o banco de dados: {ex.Message}");
            }
        }

        [HttpGet("client/{clientId:int}")]
        public async Task<IActionResult> GetProposalsByClient(int clientId)
        {
            try
            {
                // Obtém as propostas do repositório para o clientId informado
                var proposals = await _proposalRepository.GetByClientIdAsync(clientId);

                // Verifica se proposals é null
                if (proposals == null)
                {
                    return NotFound("Não foram encontradas propostas para o cliente informado.");
                }

                // Converte diretamente a proposta para DTO
                var proposalDTO = proposals.ConverterPropostasParaDTO();

                return Ok(proposalDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar o banco de dados: {ex.Message}");
            }
        }

        [HttpGet("professional/{professionalId:int}")]
        public async Task<IActionResult> GetProposalsByProfessional(int professionalId)
        {
            try
            {
                // Obtém as propostas do repositório para o professionalId informado
                var proposals = await _proposalRepository.GetByProfessionalIdAsync(professionalId);

                // Verifica se proposals é null
                if (proposals == null)
                {
                    return NotFound("Não foram encontradas propostas para o profissional informado.");
                }

                // Converte diretamente a proposta para DTO
                var proposalDTO = proposals.ConverterPropostasParaDTO();

                return Ok(proposalDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar o banco de dados: {ex.Message}");
            }
        }



    }
}
