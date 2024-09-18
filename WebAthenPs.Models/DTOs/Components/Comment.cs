    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace WebAthenPs.Models.DTOs.Components
    {
        public class CommentDTO
        {
            public int Id { get; set; }
            public string Content { get; set; }
            public string UserId { get; set; }
            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int PostId { get; set; }

    }

    public class CommentCreateDTO
        {
            public string Content { get; set; }
            public string UserId { get; set; }
            public int PostId { get; set; }
        }

        public class CommentUpdateDTO
        {
            public string Content { get; set; }
            public DateTime UpdatedAt { get; set; }
        public int PostId { get; set; }


    }
}
