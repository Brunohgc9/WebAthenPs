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
using WebAthenPs.Models.DTOs.Components;
using WebAthenPs.Project.Services.Interfaces.Components;
using WebAthenPs.Project.Services.Interfaces.User;

namespace WebAthenPs.Project.Services.Implementation.Components
{
    public class ProposalService : IProposalService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILogger<ProposalService> _logger;
        private readonly IAuthService _authService;

        public ProposalService(IHttpClientFactory httpClientFactory,
            ILocalStorageService localStorage,
            AuthenticationStateProvider authenticationStateProvider,
            ILogger<ProposalService> logger,
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

        public async Task<ProposalDTO> CreateAsync(ProposalDTO proposalDTO)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var modelAsJson = JsonSerializer.Serialize(proposalDTO);
                var requestContent = new StringContent(modelAsJson, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("api/Proposal", requestContent);

                if (response.IsSuccessStatusCode)
                {
                    var createdDto = JsonSerializer.Deserialize<ProposalDTO>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return createdDto;
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"Erro ao criar proposta. StatusCode: {response.StatusCode}, Conteúdo: {errorMessage}");
                    throw new Exception($"Error from server: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar proposta.");
                throw new Exception($"Error creating proposal: {ex.Message}", ex);
            }
        }

        public async Task<ProposalDTO> GetByIdAsync(Guid id)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.GetAsync($"api/Proposal/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var dto = JsonSerializer.Deserialize<ProposalDTO>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return dto;
                }

                _logger.LogWarning($"Proposta com ID {id} não encontrada.");
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar proposta por ID.");
                throw;
            }
        }

        public async Task<IEnumerable<ProposalDTO>> GetByClientIdAsync(int clientId)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.GetAsync($"api/Proposal/client/{clientId}");

                if (response.IsSuccessStatusCode)
                {
                    var dtoList = JsonSerializer.Deserialize<IEnumerable<ProposalDTO>>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return dtoList;
                }

                _logger.LogWarning($"Nenhuma proposta encontrada para o cliente com ID {clientId}.");
                return Enumerable.Empty<ProposalDTO>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar propostas por ID do cliente.");
                throw new Exception($"Error fetching proposals by client ID: {ex.Message}", ex);
            }
        }

        public async Task<ProposalDTO> UpdateAsync(Guid id, ProposalDTO proposalDTO)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var modelAsJson = JsonSerializer.Serialize(proposalDTO);
                var requestContent = new StringContent(modelAsJson, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync($"api/Proposal/{id}", requestContent);

                if (response.IsSuccessStatusCode)
                {
                    var updatedDto = JsonSerializer.Deserialize<ProposalDTO>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return updatedDto;
                }

                _logger.LogWarning($"Erro ao atualizar proposta com ID {id}. StatusCode: {response.StatusCode}");
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao atualizar proposta.");
                throw;
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.DeleteAsync($"api/Proposal/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogError($"Erro ao deletar proposta com ID {id}. StatusCode: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao deletar proposta.");
                throw;
            }
        }

        public async Task<IEnumerable<ProposalDTO>> GetByProfessionalIdAsync(int professionalId)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.GetAsync($"api/Proposal/professional/{professionalId}");

                if (response.IsSuccessStatusCode)
                {
                    var dtoList = JsonSerializer.Deserialize<IEnumerable<ProposalDTO>>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return dtoList;
                }

                _logger.LogWarning($"Nenhuma proposta encontrada para o profissional com ID {professionalId}.");
                return Enumerable.Empty<ProposalDTO>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar propostas por ID do profissional.");
                throw new Exception($"Error fetching proposals by professional ID: {ex.Message}", ex);
            }
        }

        // Novo método para aceitar ou rejeitar propostas
        public async Task RespondToProposalAsync(Guid id, bool isAccepted)
        {
            try
            {
                var httpClient = await CreateAuthorizedClientAsync();
                var response = await httpClient.PutAsync($"api/Proposal/{id}/respond", new StringContent(JsonSerializer.Serialize(isAccepted), Encoding.UTF8, "application/json"));

                if (!response.IsSuccessStatusCode)
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"Erro ao responder proposta com ID {id}. StatusCode: {response.StatusCode}, Conteúdo: {errorMessage}");
                    throw new Exception($"Error responding to proposal: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao responder proposta.");
                throw;
            }
        }
    }
}
