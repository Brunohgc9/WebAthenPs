using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs.User;
using WebAthenPs.Project.Services.Interfaces.User;
using System.Net.Http.Headers;

namespace WebAthenPs.Project.Services.Implementation.User
{
    public class UserService : IUserService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<UserService> _logger;
        private readonly IAuthService _authService;

        public UserService(
            IHttpClientFactory httpClientFactory,
            ILogger<UserService> logger,
            IAuthService authService)
        {
            _httpClientFactory = httpClientFactory;
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
                _logger.LogInformation($"Token: {token}");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            else
            {
                _logger.LogWarning("Token não encontrado ou está vazio.");
            }

            return httpClient;
        }

        public async Task<ApplicationUserDTO> GetUserInfo(string userId)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var userDto = await httpClient.GetFromJsonAsync<ApplicationUserDTO>($"api/Users/{userId}");

                if (userDto == null)
                {
                    _logger.LogWarning($"Usuário com ID {userId} não encontrado.");
                }
                return userDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de usuários para ID {userId}. URL: api/Users/{userId}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao acessar a API de usuários para ID {userId}.");
                throw;
            }
        }

        public async Task<string> UpdateUserInfo(string userId, UpdateUserModel model)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.PutAsJsonAsync($"api/Users/UpdateUserInfo/{userId}", model);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }

                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Erro ao atualizar o usuário. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
                return null;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API para atualizar o usuário com ID {userId}.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao atualizar o usuário com ID {userId}.");
                throw;
            }
        }

        public async Task<bool> DeleteAccount(string userId)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.DeleteAsync($"api/Users/DeleteAccount/{userId}");

                if (response.IsSuccessStatusCode)
                {
                    _logger.LogInformation($"Conta do usuário com ID {userId} excluída com sucesso.");
                    return true;
                }

                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Erro ao deletar a conta do usuário com ID {userId}. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
                return false;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API para deletar a conta do usuário com ID {userId}.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao deletar a conta do usuário com ID {userId}.");
                throw;
            }
        }

        public async Task<string> GetUserTypeById(string userId)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var userType = await httpClient.GetStringAsync($"api/Users/GetUserType/{userId}");

                return userType;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API para obter o tipo de usuário com ID {userId}.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao obter o tipo de usuário com ID {userId}.");
                throw;
            }
        }
    }
}
