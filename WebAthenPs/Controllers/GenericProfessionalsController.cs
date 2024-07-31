using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAthenPs.API.Entities;
using WebAthenPs.API.Mappings.MappingProjectDTO;
using WebAthenPs.API.Repositories.Interfaces;
using WebAthenPs.Models.DTOs;

namespace WebAthenPs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericProfessionalsController : ControllerBase
    {
        private readonly IGenericProfessionalRepository _repository;
        private readonly IMapper _mapper;

        public GenericProfessionalsController(IGenericProfessionalRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var professionals = await _repository.GetAll();
            var professionalsDTO = professionals.ConverterProfissionaisParaDTO();
            return Ok(professionalsDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var professional = await _repository.GetById(id);
            if (professional == null)
            {
                return NotFound();
            }

            var professionalDTO = professional.ConverterProfissionalParaDTO();
            return Ok(professionalDTO);
        }

        [HttpGet("ByName/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var professionals = await _repository.GetByName(name);
            var professionalsDTO = professionals.ConverterProfissionaisParaDTO();
            return Ok(professionalsDTO);
        }

        [HttpGet("ByProfessionalType/{professionalType}")]
        public async Task<IActionResult> GetByProfessionalType(string professionalType)
        {
            var professionals = await _repository.GetByProfessionalType(professionalType);
            var professionalsDTO = professionals.ConverterProfissionaisParaDTO();
            return Ok(professionalsDTO);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Add(GProfessionalDTO professionalDTO)
        {
            if (!ModelState.IsValid) return BadRequest();

            var prof = _mapper.Map<GenericProfessional>(professionalDTO);
            await _repository.AddAsync(prof);

            return Ok(_mapper.Map<GenericProfessional>(professionalDTO));
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, GProfessionalDTO professionalDTO)
        {
            if (id != professionalDTO.GProfessionalId) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();

            await _repository.UpdateAsync(_mapper.Map<GenericProfessional>(professionalDTO));

            return Ok(professionalDTO);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Remove(int id)
        {
            var prof = await _repository.GetByIdAsync(id);
            if (prof is null) return NotFound();
            await _repository.RemoveAsync(prof.Id);
            return Ok();
        }
    }
}
