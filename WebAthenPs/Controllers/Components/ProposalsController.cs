using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs.Components;
using WebAthenPs.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using WebAthenPs.API.Entities.Components;
using WebAthenPs.API.Mappings.MappingComponentDTO;

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

        // Método POST para criar uma proposta
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProposalDTO proposalDTO)
        {
            if (proposalDTO == null || !ModelState.IsValid)
                return BadRequest("Dados inválidos.");

            try
            {
                // Mapeamento de ProposalDTO para Proposal
                var proposal = proposalDTO.CriarPropostaEmDTO();

                // Salvar a proposta
                var createdProposal = await _proposalRepository.CreateAsync(proposal);

                // Retornar DTO criado
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

        // Método GET para buscar uma proposta por ID
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetProposal(Guid id)
        {
            try
            {
                var proposal = await _proposalRepository.GetByIdAsync(id);
                if (proposal == null) return NotFound("Proposta não encontrada.");

                // Retornar DTO
                var dto = proposal.ConverterPropostaParaDTO();
                return Ok(dto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar o banco de dados: {ex.Message}");
            }
        }

        // Método GET para buscar todas as propostas
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
    }
}
