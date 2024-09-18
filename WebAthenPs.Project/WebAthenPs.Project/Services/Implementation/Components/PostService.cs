using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WebAthenPs.Models.DTOs.Components;
using WebAthenPs.Project.Services.Interfaces.Components;
using System.Net.Http.Headers;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;

namespace WebAthenPs.Project.Services.Implementation.Components
{
    public class PostService : IPostService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<PostService> _logger;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public PostService(
            IHttpClientFactory httpClientFactory,
            ILogger<PostService> logger,
            ILocalStorageService localStorage,
            AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _localStorage = localStorage;
            _authenticationStateProvider = authenticationStateProvider;
        }

        private async Task<HttpClient> CreateAuthorizedClientAsync()
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
            var token = await _localStorage.GetItemAsync<string>("authToken");

            if (!string.IsNullOrEmpty(token))
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
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
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API para buscar todos os posts.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao buscar todos os posts.");
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
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API para buscar o post com ID {id}.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao buscar o post com ID {id}.");
                throw;
            }
        }

        public async Task<PostDTO> CreatePostAsync(PostCreateDTO postCreateDto)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
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
                    _logger.LogError($"Erro ao atualizar o post. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
                    return null;
                }
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API para atualizar um post.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao atualizar um post.");
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
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API para deletar o post com ID {id}.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao deletar o post com ID {id}.");
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
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API para buscar posts do usuário com ID {userId}.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao buscar posts do usuário com ID {userId}.");
                throw;
            }
        }
    }
}
