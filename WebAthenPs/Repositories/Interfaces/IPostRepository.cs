using WebAthenPs.API.Entities.Components;

namespace WebAthenPs.API.Repositories.Interfaces
{
    public interface IPostRepository
    {
        Task<Post> GetById(int id);
        Task<IEnumerable<Post>> GetByUserId(string userId);
        Task<Post> Create(Post post);
        Task Update(Post post);
        Task Delete(int id);

        Task<Comment> AddCommentToPost(int postId, Comment comment);
        Task UpdateComment(Comment comment);
        Task DeleteComment(int commentId);
        Task<IEnumerable<Post>> GetAll();
            }
}
