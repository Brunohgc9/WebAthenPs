using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAthenPs.API.Mappings;
using WebAthenPs.API.Repositories.Interfaces;
using WebAthenPs.Models.DTOs.Components;

namespace WebAthenPs.API.Controllers.Components
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepository _postRepository;

        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        // Obter todos os posts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostDTO>>> GetAll()
        {
            try
            {
                var posts = await _postRepository.GetAll();
                if (posts == null || !posts.Any())
                {
                    return NotFound("Nenhum post encontrado.");
                }
                var postDTOs = posts.ConverterPostsParaDTO();
                return Ok(postDTOs);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao buscar posts: {ex.Message}");
            }
        }

        // Obter um post por ID
        [HttpGet("{id:int}")]
        public async Task<ActionResult<PostDTO>> GetById(int id)
        {
            try
            {
                var post = await _postRepository.GetById(id);
                if (post == null)
                {
                    return NotFound("Post não encontrado.");
                }
                var postDTO = post.ConverterPostParaDTO();
                return Ok(postDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar a base de dados: {ex.Message}");
            }
        }

        // Obter posts por UserID
        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<PostDTO>>> GetByUserId(string userId)
        {
            try
            {
                var posts = await _postRepository.GetByUserId(userId);
                if (posts == null || !posts.Any())
                {
                    return NotFound("Nenhum post encontrado para o usuário.");
                }
                var postDTOs = posts.ConverterPostsParaDTO();
                return Ok(postDTOs);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao buscar posts para o usuário: {ex.Message}");
            }
        }

        // Criar um novo post
        [HttpPost]
        public async Task<ActionResult<PostDTO>> CreatePost([FromBody] PostCreateDTO dto)
        {
            if (dto == null || !ModelState.IsValid)
                return BadRequest("Dados inválidos.");

            try
            {
                var post = dto.CriarPostEmDTO();
                var createdPost = await _postRepository.Create(post);

                var createdPostDTO = createdPost.ConverterPostParaDTO();
                return CreatedAtAction(nameof(GetById), new { id = createdPostDTO.Id }, createdPostDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao criar o post: {ex.Message}");
            }
        }

        // Atualizar um post
        [HttpPut("{id:int}")]
        public async Task<ActionResult<PostDTO>> UpdatePost(int id, [FromBody] PostUpdateDTO dto)
        {
            if (dto == null || !ModelState.IsValid)
                return BadRequest("Dados inválidos.");

            try
            {
                var existingPost = await _postRepository.GetById(id);
                if (existingPost == null)
                    return NotFound("Post não encontrado.");

                existingPost = dto.AtualizarPostEmDTO(existingPost);

                await _postRepository.Update(existingPost);

                var updatedPostDTO = existingPost.ConverterPostParaDTO();
                return Ok(updatedPostDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao atualizar o post: {ex.Message}");
            }
        }

        // Deletar um post
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeletePost(int id)
        {
            try
            {
                var existingPost = await _postRepository.GetById(id);
                if (existingPost == null)
                {
                    return NotFound("Post não encontrado.");
                }

                await _postRepository.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao deletar o post: {ex.Message}");
            }
        }
    }
}
