using WebAthenPs.API.Entities.Components;

namespace WebAthenPs.API.Repositories.Interfaces
{
    public interface ICommentRepository
    {
        Task<Comment> GetById(int id);
        Task<IEnumerable<Comment>> GetByPostId(int postId);
        Task<Comment> Create(Comment comment);
        Task Update(Comment comment);
        Task Delete(int id);
    }
}
