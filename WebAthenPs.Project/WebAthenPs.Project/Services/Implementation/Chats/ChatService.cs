using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Linq;

using WebAthenPs.Models.DTOs.Components.Chats;
using WebAthenPs.Project.Services.Interfaces.Chats;
using WebAthenPs.Project.Services.Interfaces.User;

namespace WebAthenPs.Project.Services.Implementation.Chat
{
    public class ChatService : IChatService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILogger<ChatService> _logger;
        private readonly IAuthService _authService;

        public ChatService(IHttpClientFactory httpClientFactory,
            ILocalStorageService localStorage,
            AuthenticationStateProvider authenticationStateProvider,
            ILogger<ChatService> logger,
            IAuthService authService)
        {
            _httpClientFactory = httpClientFactory;
            _localStorage = localStorage;
            _authenticationStateProvider = authenticationStateProvider;
            _logger = logger;
            _authService = authService;
        }

        private async Task<HttpClient> CreateAuthorizedClientAsync()
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");

            if (!await _authService.IsLoggedIn())
            {
                _logger.LogWarning("Usuário não está logado.");
                throw new UnauthorizedAccessException("Usuário não está logado.");
            }

            var token = await _authService.GetToken();

            if (!string.IsNullOrEmpty(token))
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            else
            {
                _logger.LogWarning("Token não encontrado ou está vazio.");
            }

            return httpClient;
        }

        public async Task<ChatDTO> CreateChatAsync(ChatDTO chatDto) // Corrigido
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var modelAsJson = JsonSerializer.Serialize(chatDto);
                var requestContent = new StringContent(modelAsJson, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("api/Chat", requestContent);

                if (response.IsSuccessStatusCode)
                {
                    var createdDto = JsonSerializer.Deserialize<ChatDTO>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return createdDto;
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"Erro ao criar chat. StatusCode: {response.StatusCode}, Conteúdo: {errorMessage}");
                    throw new Exception($"Error from server: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar chat.");
                throw new Exception($"Error creating chat: {ex.Message}", ex);
            }
        }

        public async Task<List<ChatDTO>> GetChatsByUserIdAsync(string userId) // Corrigido
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.GetAsync($"api/Chat/user/{userId}");

                if (response.IsSuccessStatusCode)
                {
                    var dtoList = JsonSerializer.Deserialize<List<ChatDTO>>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return dtoList;
                }

                _logger.LogWarning($"Nenhum chat encontrado para o usuário com ID {userId}.");
                return new List<ChatDTO>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar chats por ID do usuário.");
                throw new Exception($"Error fetching chats by user ID: {ex.Message}", ex);
            }
        }

        public async Task<MessageDTO> SendMessageAsync(MessageDTO messageDto) // Corrigido
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var modelAsJson = JsonSerializer.Serialize(messageDto);
                var requestContent = new StringContent(modelAsJson, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync($"api/Chat/{messageDto.ChatId}/messages", requestContent); // Considerando que a MessageDTO contém o ChatId

                if (response.IsSuccessStatusCode)
                {
                    var sentMessage = JsonSerializer.Deserialize<MessageDTO>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return sentMessage;
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"Erro ao enviar mensagem. StatusCode: {response.StatusCode}, Conteúdo: {errorMessage}");
                    throw new Exception($"Error sending message: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao enviar mensagem.");
                throw new Exception($"Error sending message: {ex.Message}", ex);
            }
        }

        public async Task<ChatDTO> GetChatByIdAsync(Guid chatId) // Implementado
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.GetAsync($"api/Chat/{chatId}");

                if (response.IsSuccessStatusCode)
                {
                    var dto = JsonSerializer.Deserialize<ChatDTO>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return dto;
                }

                _logger.LogWarning($"Chat com ID {chatId} não encontrado.");
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar chat por ID.");
                throw;
            }
        }

        public async Task DeleteChatAsync(Guid chatId) // Implementado
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.DeleteAsync($"api/Chat/{chatId}");

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogError($"Erro ao deletar chat com ID {chatId}. StatusCode: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao deletar chat.");
                throw;
            }
        }

        public async Task<IEnumerable<MessageDTO>> GetMessagesAsync(Guid chatId) // Implementado
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.GetAsync($"api/Chat/{chatId}/messages");

                if (response.IsSuccessStatusCode)
                {
                    var dtoList = JsonSerializer.Deserialize<IEnumerable<MessageDTO>>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return dtoList;
                }

                _logger.LogWarning($"Nenhuma mensagem encontrada para o chat com ID {chatId}.");
                return Enumerable.Empty<MessageDTO>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar mensagens do chat.");
                throw new Exception($"Error fetching messages for chat: {ex.Message}", ex);
            }
        }

    }
}
