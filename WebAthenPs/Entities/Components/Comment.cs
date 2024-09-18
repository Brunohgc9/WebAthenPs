using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebAthenPs.API.Data;

namespace WebAthenPs.API.Entities.Components
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        // Texto do comentário
        public string Content { get; set; }

        // ID do usuário que fez o comentário
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        // Data de criação do comentário
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // ID da postagem à qual o comentário pertence
        public int PostId { get; set; }

        [ForeignKey("PostId")]
        public Post Post { get; set; }
    }
}
