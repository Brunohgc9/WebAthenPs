using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Logging;
using WebAthenPs.Models.DTOs.Client;
using WebAthenPs.Project.Services.Interfaces.Client;

namespace WebAthenPs.Project.Services.Implementation.Client
{
    public class ClientService : IClientService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<ClientService> _logger;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public ClientService(
            IHttpClientFactory httpClientFactory,
            ILogger<ClientService> logger,
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

        public async Task<ClientDTO> CreateAsync(RegisterClientModel clientModel, string userId)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");


                var modelAsJson = JsonSerializer.Serialize(clientModel);
                var requestContent = new StringContent(modelAsJson, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("api/Clients", requestContent);

                if (response.IsSuccessStatusCode)
                {
                    var createdDto = JsonSerializer.Deserialize<ClientDTO>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return createdDto;
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error from server: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating client.");
                throw;
            }
        }



        public async Task<ClientDTO> GetById(int id)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var clientDto = await httpClient.GetFromJsonAsync<ClientDTO>($"api/Clients/{id}");

                if (clientDto == null)
                {
                    _logger.LogWarning($"Cliente com ID {id} não encontrado.");
                    return null;
                }
                return clientDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao acessar cliente com ID {id}.");
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
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao acessar clientes com o nome {name}.");
                throw;
            }
        }

        public async Task<ClientDTO> UpdateAsync(int id, ClientDTO clientDto)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var clientAsJson = JsonSerializer.Serialize(clientDto);
                var requestContent = new StringContent(clientAsJson, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync($"api/Clients/{id}", requestContent);

                if (response.IsSuccessStatusCode)
                {
                    var updatedDto = JsonSerializer.Deserialize<ClientDTO>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return updatedDto;
                }
                else
                {
                    _logger.LogError($"Erro ao atualizar cliente. Status code: {response.StatusCode}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao atualizar cliente com ID {id}.");
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
                    _logger.LogError($"Erro ao excluir cliente com ID {id}. Status code: {response.StatusCode}");
                    throw new Exception("Erro ao excluir cliente.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao excluir cliente com ID {id}.");
                throw;
            }
        }

        public async Task<IEnumerable<ClientDTO>> GetAll()
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var clientsDto = await httpClient.GetFromJsonAsync<IEnumerable<ClientDTO>>("api/Clients");

                if (clientsDto == null)
                {
                    _logger.LogWarning("Nenhum cliente encontrado na API.");
                }
                return clientsDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao acessar todos os clientes.");
                throw;
            }
        }
    }
}
