using WebAthenPs.Models.DTOs.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAthenPs.Project.Services.Interfaces.Components
{
    public interface IPostService
    {
        Task<IEnumerable<PostDTO>> GetAllPostsAsync();
        Task<PostDTO> GetPostByIdAsync(int id);
        Task<PostDTO> CreatePostAsync(PostCreateDTO postCreateDto);
        Task<PostDTO> UpdatePostAsync(int id, PostUpdateDTO postUpdateDto);
        Task DeletePostAsync(int id);
        Task<IEnumerable<PostDTO>> GetPostsByUserIdAsync(string userId); // Adicionado
    }
}
