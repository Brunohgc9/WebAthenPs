using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAthenPs.API.Repositories.Interfaces;
using WebAthenPs.Models.DTOs;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using WebAthenPs.API.Mappings.MappingProjectDTO;
using Microsoft.AspNetCore.Authorization;

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
                // Log the exception (use your logging framework)
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
                // Log the exception (use your logging framework)
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
                // Log the exception (use your logging framework)
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados. Detalhes: " + ex.Message);
            }
        }
    }
}
