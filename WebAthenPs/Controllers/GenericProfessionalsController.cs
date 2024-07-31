using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebAthenPs.API.Entities;
using WebAthenPs.API.Repositories.Interfaces;
using WebAthenPs.Models.DTOs;

namespace WebAthenPs.API.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    public class GenericProfessionalsController : ControllerBase
    {
        private readonly IGenericProfessionalRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<GenericProfessionalsController> _logger;

        public GenericProfessionalsController(IGenericProfessionalRepository repository, IMapper mapper, ILogger<GenericProfessionalsController> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var professionals = await _repository.GetAll();
            var professionalsDTO = _mapper.Map<IEnumerable<GenericProfessional>, IEnumerable<GProfessionalDTO>>(professionals);
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

            var professionalDTO = _mapper.Map<GenericProfessional, GProfessionalDTO>(professional);
            return Ok(professionalDTO);
        }

        [HttpGet("ByName/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var professionals = await _repository.GetByName(name);
            var professionalsDTO = _mapper.Map<IEnumerable<GenericProfessional>, IEnumerable<GProfessionalDTO>>(professionals);
            return Ok(professionalsDTO);
        }

        [HttpGet("ByProfessionalType/{professionalType}")]
        public async Task<IActionResult> GetByProfessionalType(string professionalType)
        {
            var professionals = await _repository.GetByProfessionalType(professionalType);
            var professionalsDTO = _mapper.Map<IEnumerable<GenericProfessional>, IEnumerable<GProfessionalDTO>>(professionals);
            return Ok(professionalsDTO);
        }

        [HttpPost("CreateP")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Add(GProfessionalDTO professionalDTO)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized();
            }

            professionalDTO.UserId = userId;

            var prof = _mapper.Map<GenericProfessional>(professionalDTO);
            await _repository.AddAsync(prof);

            var createdProfessionalDTO = _mapper.Map<GProfessionalDTO>(prof);
            return Ok(createdProfessionalDTO);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, GProfessionalDTO professionalDTO)
        {
            if (id != professionalDTO.GProfessionalId) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();

            var prof = _mapper.Map<GenericProfessional>(professionalDTO);
            await _repository.UpdateAsync(prof);

            var updatedProfessionalDTO = _mapper.Map<GProfessionalDTO>(prof);
            return Ok(updatedProfessionalDTO);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Remove(int id)
        {
            var prof = await _repository.GetById(id);
            if (prof is null) return NotFound();
            await _repository.RemoveAsync(prof.Id);
            return Ok();
        }
    }

}
