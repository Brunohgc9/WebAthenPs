using WebAthenPs.Models.DTOs;
using WebAthenPs.Project.Services.Interfaces;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebAthenPs.Project.Services.Imprementation
{
    public class ClientService : IClientService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ClientService> _logger;

        public ClientService(HttpClient httpClient, ILogger<ClientService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<IEnumerable<ClientDTO>> GetAll()
        {
            try
            {
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
                var clientDto = await _httpClient.GetFromJsonAsync<ClientDTO>($"api/Clients/{id}");
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

        public async Task<IEnumerable<ClientDTO>> GetByName(string name)
        {
            try
            {
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
