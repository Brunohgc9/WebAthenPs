using System;
using System.Collections.Generic;
using System.Linq;
using WebAthenPs.API.Entities.Components;
using WebAthenPs.Models.DTOs.Components;

namespace WebAthenPs.API.Mappings
{
    public static class MappingComponentsDTO
    {
        // Método para converter uma coleção de Post para uma coleção de PostDTO
        public static IEnumerable<PostDTO> ConverterPostsParaDTO(this IEnumerable<Post> posts)
        {
            return posts?.Select(post => new PostDTO
            {
                Id = post.Id,
                Content = post.Content,
                ImageUrl = post.ImageUrl,
                UserId = post.UserId,
                CreatedAt = post.CreatedAt,
                LikedByUserIds = post.LikedByUserIds.ToList(), // Converte ICollection<string> para List<string>
                Comments = post.Comments?.Select(comment => new CommentDTO
                {
                    Id = comment.Id,
                    Content = comment.Content,
                    UserId = comment.UserId,
                    CreatedAt = comment.CreatedAt,
                    PostId = comment.PostId
                }).ToList() ?? new List<CommentDTO>()
            }) ?? Enumerable.Empty<PostDTO>();
        }

        // Método para converter um único Post para PostDTO
        public static PostDTO ConverterPostParaDTO(this Post post)
        {
            return new PostDTO
            {
                Id = post.Id,
                Content = post.Content,
                ImageUrl = post.ImageUrl,
                UserId = post.UserId,
                CreatedAt = post.CreatedAt,
                LikedByUserIds = post.LikedByUserIds.ToList(), // Converte ICollection<string> para List<string>
                Comments = post.Comments?.Select(comment => new CommentDTO
                {
                    Id = comment.Id,
                    Content = comment.Content,
                    UserId = comment.UserId,
                    CreatedAt = comment.CreatedAt,
                    PostId = comment.PostId
                }).ToList() ?? new List<CommentDTO>()
            };
        }

        // Método para criar um Post a partir de PostCreateDTO
        public static Post CriarPostEmDTO(this PostCreateDTO postCreateDTO)
        {
            return new Post
            {
                Content = postCreateDTO.Content,
                ImageUrl = postCreateDTO.ImageUrl,
                UserId = postCreateDTO.UserId,
                CreatedAt = DateTime.UtcNow // Define a data de criação como o momento atual
            };
        }

        // Método para atualizar um Post existente com base em PostUpdateDTO
        public static Post AtualizarPostEmDTO(this PostUpdateDTO postUpdateDTO, Post existingPost)
        {
            existingPost.Content = postUpdateDTO.Content;
            existingPost.ImageUrl = postUpdateDTO.ImageUrl;
            existingPost.UpdatedAt = postUpdateDTO.UpdatedAt;
            return existingPost;
        }

        // Método para converter uma coleção de Comment para uma coleção de CommentDTO
        public static IEnumerable<CommentDTO> ConverterComentariosParaDTO(this IEnumerable<Comment> comments)
        {
            return comments?.Select(comment => new CommentDTO
            {
                Id = comment.Id,
                Content = comment.Content,
                UserId = comment.UserId,
                CreatedAt = comment.CreatedAt,
                PostId = comment.PostId
            }) ?? Enumerable.Empty<CommentDTO>();
        }

        // Método para converter um único Comment para CommentDTO
        public static CommentDTO ConverterComentarioParaDTO(this Comment comment)
        {
            return new CommentDTO
            {
                Id = comment.Id,
                Content = comment.Content,
                UserId = comment.UserId,
                CreatedAt = comment.CreatedAt,
                PostId = comment.PostId
            };
        }

        // Método para criar um Comment a partir de CommentCreateDTO
        public static Comment CriarComentarioEmDTO(this CommentCreateDTO commentCreateDTO)
        {
            return new Comment
            {
                Content = commentCreateDTO.Content,
                UserId = commentCreateDTO.UserId,
                PostId = commentCreateDTO.PostId,
                CreatedAt = DateTime.UtcNow // Define a data de criação como o momento atual
            };
        }

        // Método para atualizar um Comment existente com base em CommentUpdateDTO
        public static Comment AtualizarComentarioEmDTO(this CommentUpdateDTO commentUpdateDTO, Comment existingComment)
        {
            existingComment.Content = commentUpdateDTO.Content;
            existingComment.UpdatedAt = DateTime.UtcNow; // Atualiza a data de modificação
            return existingComment;
        }
    }
}
