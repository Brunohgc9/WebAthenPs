using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebAthenPs.API.Data;

namespace WebAthenPs.API.Entities.Components
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        // Texto da postagem
        public string? Content { get; set; }

        // Caminho ou URL da imagem
        public string? ImageUrl { get; set; }

        // ID do usuário que criou a postagem
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        // Data de criação da postagem
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Lista de IDs de usuários que curtiram a postagem
        public ICollection<string> LikedByUserIds { get; set; } = new HashSet<string>();

        // Lista de comentários na postagem
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
