using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebAthenPs.API.Data;

namespace WebAthenPs.API.Entities.Components
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public string? Content { get; set; }
        public string? ImageUrl { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Altere para IList
        public IList<string> LikedByUserIds { get; set; } = new List<string>();

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }

}
