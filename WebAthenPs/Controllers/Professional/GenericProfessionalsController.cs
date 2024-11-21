    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebAthenPs.Models.DTOs;
    using WebAthenPs.API.Repositories.Interfaces;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Http;
    using WebAthenPs.API.Data;
    using WebAthenPs.API.Entities.Professional;
    using WebAthenPs.Models.DTOs.Professional;
    using WebAthenPs.API.Mappings.MappingProfessionalsDTO;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes;
using Microsoft.AspNetCore.Authorization;
using WebAthenPs.API.Repositories;
using WebAthenPs.Models.DTOs.Client;
using NuGet.Protocol.Core.Types;

    namespace WebAthenPs.API.Controllers.Professional
    {
        [Route("api/[controller]")]
        [ApiController]
        public class GenericProfessionalController : ControllerBase
        {
        private readonly IGenericProfessionlRepository _repository;
        private readonly UserManager<ApplicationUser> _userManager;

        public GenericProfessionalController(
            IGenericProfessionlRepository repository,
            UserManager<ApplicationUser> userManager) // Adicione esta linha no construtor
        {
            _repository = repository;
            _userManager = userManager;
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RegisterProfessionalModel model)
        {
            if (model == null || !ModelState.IsValid)
                return BadRequest("Dados inválidos.");

            try
            {
                var genericProfessional = model.CriarProfessionalEmDTO();

                await _repository.CreateAsync(genericProfessional, model.ProfessionalTypes);

                var createdDto = genericProfessional.ConverterProfessionalParaDTO();
                return CreatedAtAction(nameof(GetById), new { id = createdDto.Id }, createdDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao criar profissional: {ex.Message}");
            }
        }





        [HttpGet("{id:int}")]
            public async Task<IActionResult> GetById(int id)
            {
                try
                {
                    var professional = await _repository.GetByIdAsync(id);

                    if (professional == null)
                        return NotFound("Professional not found.");

                    var dto = professional.ConverterProfessionalParaDTO();
                    return Ok(dto);
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, $"Error accessing the database: {ex.Message}");
                }
            }

            [HttpGet]
            public async Task<IActionResult> GetAll([FromQuery] string professionalType = null)
            {
                try
                {
                    IEnumerable<GenericProfessional> professionals;

                    if (string.IsNullOrEmpty(professionalType))
                    {
                        professionals = await _repository.GetAllAsync(); // Método para obter todos
                    }
                    else
                    {
                        professionals = await _repository.GetByProfessionalTypeAsync(professionalType);
                    }

                    var dtoList = professionals.ConverterProfessionalsParaDTO();
                    return Ok(dtoList);
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, $"Error accessing the database: {ex.Message}");
                }
            }

            [HttpPut("{id:int}")]
            public async Task<IActionResult> Update(int id, [FromBody] RegisterProfessionalModel model)
            {
                if (model == null || !ModelState.IsValid)
                    return BadRequest("Dados inválidos.");

                try
                {
                    var existingProfessional = await _repository.GetByIdAsync(id);

                    if (existingProfessional == null)
                        return NotFound("Profissional não encontrado.");

                    existingProfessional.ProfessionalTypes = model.ProfessionalTypes ?? new List<string>();


                    await _repository.UpdateAsync(existingProfessional);

                    var updatedDto = existingProfessional.ConverterProfessionalParaDTO();
                    return Ok(updatedDto);
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar o banco de dados: {ex.Message}");
                }
            }


            [HttpDelete("{id:int}")]
            public async Task<IActionResult> Delete(int id)
            {
                try
                {
                    var professional = await _repository.GetByIdAsync(id);

                    if (professional == null)
                        return NotFound("Professional not found.");

                    await _repository.DeleteAsync(id);
                    return NoContent();
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, $"Error accessing the database: {ex.Message}");
                }
            }

        [HttpGet("user/{userId}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<ClientDTO>> GetByUserId(string userId)
        {
            try
            {
                var client = await _repository.GetByUserId(userId);
                if (client == null)
                {
                    return NotFound($"Cliente não encontrado para UserId {userId}.");
                }

                var clientDTO = client.ConverterProfessionalParaDTO();
                return Ok(clientDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados. Detalhes: " + ex.Message);
            }
        }



    }
    }
