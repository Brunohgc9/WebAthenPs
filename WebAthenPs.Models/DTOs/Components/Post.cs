using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs.Professional;
using WebAthenPs.Models.DTOs.User;

namespace WebAthenPs.Models.DTOs.Components
{
    public class PostDTO
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public string? ImageUrl { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<CommentDTO> Comments { get; set; } = new List<CommentDTO>();
        public ICollection<string> LikedByUserIds { get; set; } = new List<string>();
    }

    public class PostCreateDTO
    {
        public string? Content { get; set; }
        public string? ImageUrl { get; set; }
        public string UserId { get; set; }
    }

    public class PostUpdateDTO
    {
        public string? Content { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
