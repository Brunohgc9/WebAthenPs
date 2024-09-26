using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAthenPs.API.Mappings.MappingCommentDTO;
using WebAthenPs.API.Repositories.Interfaces;
using WebAthenPs.Models.DTOs.Components;

namespace WebAthenPs.API.Controllers.Components
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentRepository _commentRepository;

        public CommentsController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        // Criar um novo comentário
        [HttpPost]
        public async Task<ActionResult<CommentDTO>> CreateComment([FromBody] CommentCreateDTO dto)
        {
            if (dto == null || !ModelState.IsValid)
                return BadRequest("Dados inválidos.");

            try
            {
                var comment = dto.CriarCommentEmDTO();
                var createdComment = await _commentRepository.Create(comment);

                var createdCommentDTO = createdComment.ConverterCommentParaDTO();
                return CreatedAtAction(nameof(GetById), new { id = createdCommentDTO.Id }, createdCommentDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao criar o comentário: {ex.Message}");
            }
        }

        // Obter um comentário por ID
        [HttpGet("{id:int}")]
        public async Task<ActionResult<CommentDTO>> GetById(int id)
        {
            try
            {
                var comment = await _commentRepository.GetById(id);
                if (comment == null)
                    return NotFound("Comentário não encontrado.");

                var commentDTO = comment.ConverterCommentParaDTO();
                return Ok(commentDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar a base de dados. Detalhes: {ex.Message}");
            }
        }

        // **NOVO**: Obter todos os comentários por ID do post
        [HttpGet("post/{postId:int}")]
        public async Task<ActionResult<IEnumerable<CommentDTO>>> GetByPostId(int postId)
        {
            try
            {
                var comments = await _commentRepository.GetByPostId(postId);
                if (!comments.Any())
                    return NotFound("Nenhum comentário encontrado para este post.");

                var commentDTOs = comments.Select(c => c.ConverterCommentParaDTO()).ToList();
                return Ok(commentDTOs);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar a base de dados. Detalhes: {ex.Message}");
            }
        }

        // Atualizar um comentário
        [HttpPut("{id:int}")]
        public async Task<ActionResult<CommentDTO>> UpdateComment(int id, [FromBody] CommentUpdateDTO dto)
        {
            if (dto == null || !ModelState.IsValid)
                return BadRequest("Dados inválidos.");

            try
            {
                var existingComment = await _commentRepository.GetById(id);
                if (existingComment == null)
                    return NotFound("Comentário não encontrado.");

                existingComment = dto.AtualizarCommentEmDTO(existingComment);

                await _commentRepository.Update(existingComment);

                var updatedCommentDTO = existingComment.ConverterCommentParaDTO();
                return Ok(updatedCommentDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao atualizar o comentário: {ex.Message}");
            }
        }

        // Deletar um comentário
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteComment(int id)
        {
            try
            {
                var existingComment = await _commentRepository.GetById(id);
                if (existingComment == null)
                    return NotFound("Comentário não encontrado.");

                await _commentRepository.Delete(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao deletar o comentário. Detalhes: {ex.Message}");
            }
        }
    }
}
