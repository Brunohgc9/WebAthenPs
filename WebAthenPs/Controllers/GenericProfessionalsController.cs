﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAthenPs.API.Mappings.MappingProjectDTO;
using WebAthenPs.Models.DTOs;
using WebAthenPs.Models.Models;
using WebAthenPs.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Professional;

namespace WebAthenPs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericProfessionalController : ControllerBase
    {
        private readonly IGenericProfessionlRepository _repository;
        private readonly UserManager<ApplicationUser> _userManager;

        public GenericProfessionalController(IGenericProfessionlRepository repository, UserManager<ApplicationUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RegisterProfessionalModel model)
        {
            if (model == null || !ModelState.IsValid)
                return BadRequest("Dados inválidos.");

            var genericProfessional = GenericProfessionalMapping.CriarProfessionalEmDTO(model);

            try
            {
                await _repository.CreateAsync(genericProfessional);

                var createdDto = GenericProfessionalMapping.ConverterProfessionalParaDTO(genericProfessional);

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

                var dto = GenericProfessionalMapping.ConverterProfessionalParaDTO(professional);
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

                var dtoList = GenericProfessionalMapping.ConverterProfessionalsParaDTO(professionals);
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
                return BadRequest("Invalid data.");

            try
            {
                var existingProfessional = await _repository.GetByIdAsync(id);

                if (existingProfessional == null)
                    return NotFound("Professional not found.");

                existingProfessional.ProfessionalType = model.ProfessionalType;
                // Atualizar outros campos conforme necessário

                await _repository.UpdateAsync(existingProfessional);

                var updatedDto = GenericProfessionalMapping.ConverterProfessionalParaDTO(existingProfessional);
                return Ok(updatedDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error accessing the database: {ex.Message}");
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

        [HttpGet("architects")]
        public async Task<IActionResult> GetAllArchitects()
        {
            try
            {
                var architects = await _repository.GetAllArchitectsAsync();

                if (architects == null || !architects.Any())
                    return NotFound("Nenhum arquiteto encontrado.");

                var dtoList = architects.Select(architect => new GenericProfessionalDTO
                {
                    Id = architect.Professional.Id,
                    UserId = architect.Professional.UserId,
                    UserName = architect.Professional.User?.UserName,
                    PhoneNumber = architect.Professional.User?.PhoneNumber,
                    Email = architect.Professional.User?.Email,
                    ClientId = architect.Professional.ClientId,
                    ProfessionalType = architect.Professional.ProfessionalType
                }).ToList();

                return Ok(dtoList);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar o banco de dados: {ex.Message}");
            }
        }

    }
}
