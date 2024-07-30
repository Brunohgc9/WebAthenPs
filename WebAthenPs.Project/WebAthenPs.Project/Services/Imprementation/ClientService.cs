using WebAthenPs.Models.DTOs;
using WebAthenPs.Project.Services.Interfaces;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Blazored.LocalStorage;

namespace WebAthenPs.Project.Services.Imprementation
{
    public class ClientService : IClientService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ClientService> _logger;
        private readonly ILocalStorageService _localStorage;

        public ClientService(HttpClient httpClient, ILogger<ClientService> logger, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _logger = logger;
            _localStorage = localStorage;
        }

        public async Task<IEnumerable<ClientDTO>> GetAll()
        {
            try
            {
                var token = await _localStorage.GetItemAsync<string>("authToken");
                if (!string.IsNullOrEmpty(token))
                {
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }

                var clientsDto = await _httpClient.GetFromJsonAsync<IEnumerable<ClientDTO>>("api/Clients");
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
                var token = await _localStorage.GetItemAsync<string>("authToken");
                if (!string.IsNullOrEmpty(token))
                {
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }

                var clientDto = await _httpClient.GetFromJsonAsync<ClientDTO>($"api/Clients/{id}");
                if (clientDto == null)
                {
                    _logger.LogWarning($"Cliente com ID {id} não encontrado.");
                    return null;
                }

                // Obtém todos os projetos do cliente
                var projects = await _httpClient.GetFromJsonAsync<IEnumerable<ProjectsDTO>>($"api/Projects/client/{id}");
                if (projects != null)
                {
                    // Adiciona os profissionais dos projetos aos profissionais do cliente
                    var professionals = new HashSet<GProfessionalDTO>();
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
                var token = await _localStorage.GetItemAsync<string>("authToken");
                if (!string.IsNullOrEmpty(token))
                {
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }
                var clientsDto = await _httpClient.GetFromJsonAsync<IEnumerable<ClientDTO>>($"api/Clients/name/{name}");
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
    }
}
