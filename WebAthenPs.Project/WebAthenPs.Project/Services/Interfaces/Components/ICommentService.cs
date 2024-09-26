using WebAthenPs.Models.DTOs.Components;

namespace WebAthenPs.Project.Services.Interfaces.Components
{
    public interface ICommentService
    {
        Task<IEnumerable<CommentDTO>> GetAll();
        Task<CommentDTO> GetById(int id);
        Task<CommentDTO> CreateComment(CommentCreateDTO dto);
        Task<CommentDTO> UpdateComment(int id, CommentUpdateDTO dto);
        Task DeleteComment(int id);
        Task<IEnumerable<CommentDTO>> GetByPostId(int postId);
    }
}
