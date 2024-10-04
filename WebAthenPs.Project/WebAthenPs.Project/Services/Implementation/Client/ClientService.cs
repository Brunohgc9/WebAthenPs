using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Components.Authorization;
using WebAthenPs.Models.DTOs.Client;
using WebAthenPs.Project.Services.Interfaces.Client;
using WebAthenPs.Project.Services.Interfaces.User;

namespace WebAthenPs.Project.Services.Implementation
{
    public class ClientService : IClientService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<ClientService> _logger;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly IAuthService _authService;

        public ClientService(
            IHttpClientFactory httpClientFactory,
            ILogger<ClientService> logger,
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
                throw new UnauthorizedAccessException("Usuário não está logado."); // Ou trate como preferir
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

        public async Task<IEnumerable<ClientDTO>> GetAll()
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var clientsDto = await httpClient.GetFromJsonAsync<IEnumerable<ClientDTO>>("api/Clients");

                if (clientsDto == null)
                {
                    _logger.LogWarning("Nenhum cliente encontrado na API em 'api/Clients'.");
                }
                return clientsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API de clientes. URL: api/Clients");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao acessar a API de clientes.");
                throw;
            }
        }

        public async Task<ClientDTO> GetById(int id)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var clientDto = await httpClient.GetFromJsonAsync<ClientDTO>($"api/Clients/id/{id}");

                if (clientDto == null)
                {
                    _logger.LogWarning($"Cliente com ID {id} não encontrado.");
                }
                return clientDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de clientes para ID {id}. URL: api/Clients/{id}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao acessar a API de clientes para ID {id}.");
                throw;
            }
        }

        public async Task<ClientDTO> CreateClient(RegisterClientModel model)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.PostAsJsonAsync("api/Clients", model);

                if (response.IsSuccessStatusCode)
                {
                    var createdClient = await response.Content.ReadFromJsonAsync<ClientDTO>();
                    _logger.LogInformation("Cliente criado com sucesso.");
                    return createdClient;
                }

                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Erro ao criar o cliente. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
                return null;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API para criar um cliente.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao criar um cliente.");
                throw;
            }
        }

        public async Task DeleteClient(int id)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.DeleteAsync($"api/Clients/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogError($"Erro ao deletar o cliente com ID {id}. StatusCode: {response.StatusCode}");
                }
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API para deletar o cliente com ID {id}. URL: api/Clients/{id}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao deletar o cliente com ID {id}.");
                throw;
            }
        }

        public async Task<ClientDTO> UpdateClient(int id, ClientDTO dto)
        {
            // Validação do DTO
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), "O DTO do cliente não pode ser nulo.");
            }

            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.PutAsJsonAsync($"api/Clients/{id}", dto);

                if (response.IsSuccessStatusCode)
                {
                    var updatedClient = await response.Content.ReadFromJsonAsync<ClientDTO>();
                    _logger.LogInformation("Cliente atualizado com sucesso.");
                    return updatedClient;
                }

                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Erro ao atualizar o cliente. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
                return null;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API para atualizar um cliente.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao atualizar um cliente.");
                throw;
            }
        }

        public async Task<ClientDTO> CreateAsync(RegisterClientModel clientModel, string userId)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs"); // Não precisa estar autenticado
                var response = await httpClient.PostAsJsonAsync($"api/Clients/{userId}", clientModel);

                if (response.IsSuccessStatusCode)
                {
                    var createdClient = await response.Content.ReadFromJsonAsync<ClientDTO>();
                    _logger.LogInformation("Cliente criado com sucesso.");
                    return createdClient;
                }

                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Erro ao criar o cliente. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
                return null;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API para criar um cliente.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao criar um cliente.");
                throw;
            }
        }

        public async Task<IEnumerable<ClientDTO>> GetByName(string name)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var clientsDto = await httpClient.GetFromJsonAsync<IEnumerable<ClientDTO>>($"api/Clients/name/{name}");

                if (clientsDto == null)
                {
                    _logger.LogWarning($"Nenhum cliente encontrado com o nome {name}.");
                }
                return clientsDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de clientes com o nome {name}. URL: api/Clients/name/{name}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao acessar a API de clientes com o nome {name}.");
                throw;
            }
        }

        public async Task<ClientDTO> UpdateAsync(int id, ClientDTO clientDto)
        {
            // Validação do DTO
            if (clientDto == null)
            {
                throw new ArgumentNullException(nameof(clientDto), "O DTO do cliente não pode ser nulo.");
            }

            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.PutAsJsonAsync($"api/Clients/{id}", clientDto);

                if (response.IsSuccessStatusCode)
                {
                    var updatedClient = await response.Content.ReadFromJsonAsync<ClientDTO>();
                    _logger.LogInformation("Cliente atualizado com sucesso.");
                    return updatedClient;
                }

                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Erro ao atualizar o cliente. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
                return null;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, "Erro ao acessar a API para atualizar um cliente.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro inesperado ao atualizar um cliente.");
                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.DeleteAsync($"api/Clients/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogError($"Erro ao deletar o cliente com ID {id}. StatusCode: {response.StatusCode}");
                }
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API para deletar o cliente com ID {id}. URL: api/Clients/{id}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao deletar o cliente com ID {id}.");
                throw;
            }
        }

        public async Task<ClientDTO> GetByUserId(string userId)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var clientDto = await httpClient.GetFromJsonAsync<ClientDTO>($"api/Clients/user/{userId}");

                if (clientDto == null)
                {
                    _logger.LogWarning($"Cliente com UserId {userId} não encontrado.");
                }
                return clientDto;
            }
            catch (HttpRequestException httpEx)
            {
                _logger.LogError(httpEx, $"Erro ao acessar a API de clientes para UserId {userId}. URL: api/Clients/user/{userId}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro inesperado ao acessar a API de clientes para UserId {userId}.");
                throw;
            }
        }


    }
}
