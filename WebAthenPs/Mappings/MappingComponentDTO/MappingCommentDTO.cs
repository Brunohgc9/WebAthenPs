using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using WebAthenPs.API.Entities.Components;
using WebAthenPs.Models.DTOs.Components;

namespace WebAthenPs.API.Mappings.MappingCommentDTO
{
    public static class MappingCommentDTO
    {
        public static IEnumerable<CommentDTO> ConverterCommentsParaDTO(this IEnumerable<Comment> comments)
        {
            return comments?.Select(item => new CommentDTO
            {
                Id = item.Id,
                Content = item.Content,
                UserId = item.UserId,
                CreatedAt = item.CreatedAt
            }) ?? Enumerable.Empty<CommentDTO>();
        }

        public static CommentDTO ConverterCommentParaDTO(this Comment comment)
        {
            return new CommentDTO
            {
                Id = comment.Id,
                Content = comment.Content,
                UserId = comment.UserId,
                CreatedAt = comment.CreatedAt
            };
        }

        public static Comment CriarCommentEmDTO(this CommentCreateDTO commentCreateDTO)
        {
            return new Comment
            {
                Content = commentCreateDTO.Content,
                UserId = commentCreateDTO.UserId,
                PostId = commentCreateDTO.PostId,
                CreatedAt = DateTime.UtcNow // Define a data de criação como o momento atual
            };
        }

        public static Comment AtualizarCommentEmDTO(this CommentUpdateDTO commentUpdateDTO, Comment existingComment)
        {
            existingComment.Content = commentUpdateDTO.Content;
            existingComment.UpdatedAt = commentUpdateDTO.UpdatedAt;

            return existingComment;
        }

    }
}
