using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAthenPs.API.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using WebAthenPs.API.Entities.Project;
using WebAthenPs.API.Entities.Professional;
using WebAthenPs.API.Entities.Clients;
using WebAthenPs.Models.DTOs.Client;
using WebAthenPs.API.Mappings.MappingClientsDTO;

namespace WebAthenPs.API.Controllers.Clients
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;

        public ClientsController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<IEnumerable<ClientDTO>>> GetAll()
        {
            try
            {
                var clients = await _clientRepository.GetAll();
                if (clients == null || !clients.Any())
                {
                    return NotFound("Não foi possível encontrar clientes.");
                }

                var clientsDTO = clients.ConverterClientesParaDTO();
                return Ok(clientsDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados. Detalhes: " + ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<ClientDTO>> GetById(int id)
        {
            try
            {
                var client = await _clientRepository.GetById(id);
                if (client == null)
                {
                    return NotFound("Cliente não encontrado.");
                }
                var clientDTO = client.ConverterClienteParaDTO();
                return Ok(clientDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados. Detalhes: " + ex.Message);
            }
        }

        [HttpGet("name/{name}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<IEnumerable<ClientDTO>>> GetByName(string name)
        {
            try
            {
                var clients = await _clientRepository.GetByName(name);
                if (clients == null || !clients.Any())
                {
                    return NotFound($"Nenhum cliente encontrado com o nome {name}.");
                }
                var clientsDTO = clients.ConverterClientesParaDTO();
                return Ok(clientsDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados. Detalhes: " + ex.Message);
            }
        }


        [HttpPost]
        public async Task<ActionResult<ClientDTO>> Create([FromBody] RegisterClientModel model)
        {
            if (model == null || !ModelState.IsValid)
                return BadRequest("Dados inválidos.");

            var client = model.CriarClienteEmDTO();

            try
            {
                await _clientRepository.Create(client);

                var createdDto = client.ConverterClienteParaDTO();

                return CreatedAtAction(nameof(GetById), new { id = createdDto.ClientId }, createdDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao criar cliente: {ex.Message}");
            }
        }

        [HttpPut("{id:int}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult> Update(int id, ClientDTO clientDTO)
        {
            try
            {
                if (id != clientDTO.ClientId)
                {
                    return BadRequest("ID do cliente não corresponde.");
                }

                var existingClient = await _clientRepository.GetById(id);
                if (existingClient == null)
                {
                    return NotFound("Cliente não encontrado.");
                }

                var client = new Client
                {
                    ClientId = clientDTO.ClientId,
                    UserId = clientDTO.UserId,
                    GenericProfessionals = clientDTO.GenericProfessionals?.Select(gp => new GenericProfessional
                    {
                        ProfessionalTypes = gp.ProfessionalTypes,
                        Id = gp.Id,
                        // Mapeie outros campos conforme necessário
                    }).ToList(),
                    Houses = clientDTO.Houses?.Select(p => new Projecty
                    {
                        ProjectId = p.ProjectId,
                        ProjectName = p.ProjectName
                    }).ToList()
                };

                await _clientRepository.Update(client);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao atualizar o cliente. Detalhes: " + ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var existingClient = await _clientRepository.GetById(id);
                if (existingClient == null)
                {
                    return NotFound("Cliente não encontrado.");
                }

                await _clientRepository.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao excluir o cliente. Detalhes: " + ex.Message);
            }
        }

        [HttpGet("user/{userId}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<ClientDTO>> GetByUserId(string userId)
        {
            try
            {
                var client = await _clientRepository.GetByUserId(userId);
                if (client == null)
                {
                    return NotFound($"Cliente não encontrado para UserId {userId}.");
                }

                var clientDTO = client.ConverterClienteParaDTO();
                return Ok(clientDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados. Detalhes: " + ex.Message);
            }
        }

    }


}
