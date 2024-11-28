using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components.Authorization;
using WebAthenPs.Models.DTOs.Components;
using WebAthenPs.Project.Services.Interfaces.Components;
using WebAthenPs.Project.Services.Interfaces.User;

namespace WebAthenPs.Project.Services.Implementation.Components
{
    public class PostService : IPostService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<PostService> _logger;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly IAuthService _authService;

        public PostService(
            IHttpClientFactory httpClientFactory,
            ILogger<PostService> logger,
            AuthenticationStateProvider authenticationStateProvider,
            IAuthService authService)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _authenticationStateProvider = authenticationStateProvider;
            _authService = authService;
        }


        private async Task<HttpClient> CreateAuthorizedClientAsync()
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");

            // Verifica se o usuário está logado
            if (!await _authService.IsLoggedIn())
            {
                _logger.LogWarning("Usuário não está logado.");
                throw new UnauthorizedAccessException("Usuário não está logado.");
            }

            var token = await _authService.GetToken(); // Obtém o token descriptografado

            if (!string.IsNullOrEmpty(token))
            {
                _logger.LogInformation($"Token: {token}");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            else
            {
                _logger.LogWarning("Token não encontrado ou está vazio.");
            }

            return httpClient;
        }

        public async Task<IEnumerable<PostDTO>> GetAllPostsAsync()
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                return await httpClient.GetFromJsonAsync<IEnumerable<PostDTO>>("api/Posts");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar todos os posts.");
                throw;
            }
        }

        public async Task<PostDTO> GetPostByIdAsync(int id)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                return await httpClient.GetFromJsonAsync<PostDTO>($"api/Posts/{id}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao buscar o post com ID {id}.");
                throw;
            }
        }

        public async Task<IEnumerable<PostDTO>> GetPostsByUserIdAsync(string userId)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                return await httpClient.GetFromJsonAsync<IEnumerable<PostDTO>>($"api/Posts/user/{userId}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao buscar posts do usuário {userId}.");
                throw;
            }
        }

        public async Task<PostDTO> CreatePostAsync(PostCreateDTO postCreateDto)
        {
            try
            {
                // Obtém o UserId diretamente do serviço de autenticação
                var userId = await _authService.GetUserIdFromToken();
                if (string.IsNullOrEmpty(userId))
                {
                    _logger.LogWarning("Usuário não autenticado ao tentar criar um post.");
                    throw new UnauthorizedAccessException("Usuário não autenticado.");
                }

                // Atribui o UserId ao DTO
                postCreateDto.UserId = userId;

                // Cria o cliente HTTP autorizado
                var httpClient = await CreateAuthorizedClientAsync();

                // Envia a requisição para criar o post
                var response = await httpClient.PostAsJsonAsync("api/Posts", postCreateDto);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<PostDTO>();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"Erro ao criar o post. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
                    return null;
                }
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API para criar um post.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao criar um post.");
                throw;
            }
        }


        public async Task<PostDTO> UpdatePostAsync(int id, PostUpdateDTO postUpdateDto)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.PutAsJsonAsync($"api/Posts/{id}", postUpdateDto);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<PostDTO>();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"Erro ao atualizar o post com ID {id}. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao atualizar o post.");
                throw;
            }
        }

        public async Task DeletePostAsync(int id)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.DeleteAsync($"api/Posts/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"Erro ao deletar o post com ID {id}. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao deletar o post com ID {id}.");
                throw;
            }
        }

    }
}
