using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAthenPs.API.Repositories.Interfaces;
using WebAthenPs.Models.DTOs;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using WebAthenPs.API.Mappings.MappingProjectDTO;
using Microsoft.AspNetCore.Authorization;
using WebAthenPs.API.Entities;
using Microsoft.Build.Evaluation;

namespace WebAthenPs.API.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;

        public ClientsController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet]
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
        public async Task<ActionResult<ClientDTO>> Create(ClientDTO clientDTO)
        {
            try
            {
                if (clientDTO == null)
                {
                    return BadRequest("Cliente não pode ser nulo.");
                }

                var client = new Client
                {
                    ClientId = clientDTO.ClientId,
                    UserId = clientDTO.UserId,
                    // Mapeie outros campos conforme necessário
                    GenericProfessionals = clientDTO.GenericProfessionals?.Select(gp => new GenericProfessional
                    {
                        ProfessionalType = gp.ProfessionalType,
                        Id = gp.Id,
                        // Mapeie outros campos conforme necessário
                    }).ToList(),
                    Houses = clientDTO.Houses?.Select(p => new Projecty
                    {
                        ProjectId = p.ProjectId,
                        ProjectName = p.ProjectName
                    }).ToList()
                };

                var createdClient = await _clientRepository.Create(client);
                var createdClientDTO = createdClient.ConverterClienteParaDTO();

                return CreatedAtAction(nameof(GetById), new { id = createdClientDTO.ClientId }, createdClientDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao criar o cliente. Detalhes: " + ex.Message);
            }
        }

        [HttpPut("{id:int}")]
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
                    // Mapeie outros campos conforme necessário
                    GenericProfessionals = clientDTO.GenericProfessionals?.Select(gp => new GenericProfessional
                    {
                        ProfessionalType = gp.ProfessionalType,
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
    }
}
