using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Text.Json;
using System.Text;
using WebAthenPs.Models.DTOs.Components;
using WebAthenPs.Project.Services.Interfaces.Components;

namespace WebAthenPs.Project.Services.Implementation.Components
{
    public class ProposalService : IProposalService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public ProposalService(IHttpClientFactory httpClientFactory,
            ILocalStorageService localStorage,
            AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClientFactory = httpClientFactory;
            _localStorage = localStorage;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<ProposalDTO> CreateAsync(ProposalDTO proposalDTO)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
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
                    throw new Exception($"Error from server: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating proposal: {ex.Message}", ex);
            }
        }

        public async Task<ProposalDTO> GetByIdAsync(Guid id)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
                var response = await httpClient.GetAsync($"api/Proposal/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var dto = JsonSerializer.Deserialize<ProposalDTO>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return dto;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ProposalDTO>> GetByClientIdAsync(int clientId)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
                var response = await httpClient.GetAsync($"api/Proposal?clientId={clientId}");

                if (response.IsSuccessStatusCode)
                {
                    var dtoList = JsonSerializer.Deserialize<IEnumerable<ProposalDTO>>(
                        await response.Content.ReadAsStringAsync(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    return dtoList;
                }
                return Enumerable.Empty<ProposalDTO>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching proposals by client ID: {ex.Message}", ex);
            }
        }

        public async Task<ProposalDTO> UpdateAsync(Guid id, ProposalDTO proposalDTO)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
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
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs");
                var response = await httpClient.DeleteAsync($"api/Proposal/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Error deleting the proposal.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
