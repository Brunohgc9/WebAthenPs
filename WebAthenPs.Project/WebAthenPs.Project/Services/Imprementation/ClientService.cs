using WebAthenPs.Models.DTOs;
using WebAthenPs.Project.Services.Interfaces;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Text.Json;
using System.Text;

namespace WebAthenPs.Project.Services.Imprementation
{
    public class ClientService : IClientService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<ClientService> _logger;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public ClientService(IHttpClientFactory httpClientFactory, ILogger<ClientService> logger, ILocalStorageService localStorage, AuthenticationStateProvider authenticationStateProvider)
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
                var clientDto = await httpClient.GetFromJsonAsync<ClientDTO>($"api/Clients/{id}");

                if (clientDto == null)
                {
                    _logger.LogWarning($"Cliente com ID {id} não encontrado.");
                    return null;
                }

                // Obtém todos os projetos do cliente
                var projects = await httpClient.GetFromJsonAsync<IEnumerable<ProjectsDTO>>($"api/Projects/client/{id}");
                if (projects != null)
                {
                    // Adiciona os profissionais dos projetos aos profissionais do cliente
                    var professionals = new HashSet<GenericProfessionalDTO>();
                    foreach (var project in projects)
                    {
                        if (project.Professionals != null)
                        {
                            foreach (var professional in project.Professionals)
                            {
                                professionals.Add(professional);
                            }
                        }
                    }
                    clientDto.GenericProfessionals = professionals.ToList();
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

        public async Task<ClientDTO> CreateAsync(ClientDTO clientDto)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var clientAsJson = JsonSerializer.Serialize(clientDto);
                var requestContent = new StringContent(clientAsJson, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("api/Clients", requestContent);

                if (response.IsSuccessStatusCode)
                {
                    var createdDto = JsonSerializer.Deserialize<ClientDTO>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return createdDto;
                }
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar cliente.");
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
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao atualizar cliente.");
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
                _logger.LogError(ex, "Erro ao excluir cliente.");
                throw;
            }
        }
    }
}
