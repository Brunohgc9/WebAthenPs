using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WebAthenPs.Models.DTOs.Components;
using WebAthenPs.Project.Services.Interfaces.Components;

namespace WebAthenPs.Services.Implementation.Comments
{
    public class CommentService : ICommentService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<CommentService> _logger;

        public CommentService(IHttpClientFactory httpClientFactory, ILogger<CommentService> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        private async Task<HttpClient> CreateAuthorizedClientAsync()
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
            return httpClient;
        }

        public async Task<IEnumerable<CommentDTO>> GetAll()
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var commentsDto = await httpClient.GetFromJsonAsync<IEnumerable<CommentDTO>>("api/Comments");

                if (commentsDto == null)
                {
                    _logger.LogWarning("Nenhum comentário encontrado na API em 'api/Comments'.");
                }
                return commentsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API de comentários.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao acessar a API de comentários.");
                throw;
            }
        }

        public async Task<CommentDTO> GetById(int id)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var commentDto = await httpClient.GetFromJsonAsync<CommentDTO>($"api/Comments/{id}");

                if (commentDto == null)
                {
                    _logger.LogWarning($"Comentário com ID {id} não encontrado.");
                }
                return commentDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de comentários para ID {id}.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao acessar a API de comentários para ID {id}.");
                throw;
            }
        }

        // **NOVO**: Obter comentários pelo ID do post
        public async Task<IEnumerable<CommentDTO>> GetByPostId(int postId)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var commentsDto = await httpClient.GetFromJsonAsync<IEnumerable<CommentDTO>>($"api/Comments/post/{postId}");

                if (commentsDto == null || !commentsDto.Any())
                {
                    _logger.LogWarning($"Nenhum comentário encontrado para o post com ID {postId}.");
                }
                return commentsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de comentários para o post com ID {postId}.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao acessar a API de comentários para o post com ID {postId}.");
                throw;
            }
        }

        public async Task<CommentDTO> CreateComment(CommentCreateDTO dto)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.PostAsJsonAsync("api/Comments", dto);

                if (response.IsSuccessStatusCode)
                {
                    var createdComment = await response.Content.ReadFromJsonAsync<CommentDTO>();
                    _logger.LogInformation("Comentário criado com sucesso.");
                    return createdComment;
                }

                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Erro ao criar o comentário. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
                return null;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API para criar um comentário.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao criar um comentário.");
                throw;
            }
        }

        public async Task<CommentDTO> UpdateComment(int id, CommentUpdateDTO dto)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.PutAsJsonAsync($"api/Comments/{id}", dto);

                if (response.IsSuccessStatusCode)
                {
                    var updatedComment = await response.Content.ReadFromJsonAsync<CommentDTO>();
                    _logger.LogInformation("Comentário atualizado com sucesso.");
                    return updatedComment;
                }

                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Erro ao atualizar o comentário. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
                return null;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API para atualizar um comentário.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao atualizar um comentário.");
                throw;
            }
        }

        public async Task DeleteComment(int id)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.DeleteAsync($"api/Comments/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogError($"Erro ao deletar o comentário com ID {id}. StatusCode: {response.StatusCode}");
                }
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API para deletar o comentário com ID {id}.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao deletar o comentário com ID {id}.");
                throw;
            }
        }
    }
}
