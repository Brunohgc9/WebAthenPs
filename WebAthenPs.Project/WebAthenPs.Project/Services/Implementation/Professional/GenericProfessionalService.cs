using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;
using Blazored.LocalStorage;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Components.Authorization;
using WebAthenPs.Models.DTOs.Professional;
using WebAthenPs.Project.Services.Interfaces.Professional;
using WebAthenPs.Project.Services.Interfaces.User;
using WebAthenPs.Models.DTOs.Client;

public class GenericProfessionalService : IGenericProfessionalService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly ILogger<GenericProfessionalService> _logger;
    private readonly AuthenticationStateProvider _authenticationStateProvider;
    private readonly IAuthService _authService;

    public GenericProfessionalService(IHttpClientFactory httpClientFactory, ILogger<GenericProfessionalService> logger, AuthenticationStateProvider authenticationStateProvider, IAuthService authService)
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
            throw new UnauthorizedAccessException("Usuário não está logado.");
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

    public async Task<GenericProfessionalDTO> CreateAsync(RegisterProfessionalModel model)
    {
        try
        {
            var httpClient = _httpClientFactory.CreateClient("APIWebAthenPs"); // Não precisa estar autenticado
            var response = await httpClient.PostAsJsonAsync($"api/GenericProfessional/", model);

            if (response.IsSuccessStatusCode)
            {
                var createdProfessional = await response.Content.ReadFromJsonAsync<GenericProfessionalDTO>();
                _logger.LogInformation("Profissional criado com sucesso.");
                return createdProfessional;
            }

            var errorContent = await response.Content.ReadAsStringAsync();
            _logger.LogError($"Erro ao criar o profissional. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
            return null;
        }
        catch (HttpRequestException httpEx)
        {
            _logger.LogError(httpEx, "Erro ao acessar a API para criar um profissional.");
            throw;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro inesperado ao criar um profissional.");
            throw;
        }
    }

    public async Task<GenericProfessionalDTO> GetByIdAsync(int id)
    {
        try
        {
            var httpClient = await CreateAuthorizedClientAsync();
            var professionalDto = await httpClient.GetFromJsonAsync<GenericProfessionalDTO>($"api/GenericProfessional/{id}");

            if (professionalDto == null)
            {
                _logger.LogWarning($"Profissional com ID {id} não encontrado.");
            }
            else
            {
                // Aqui você pode acessar o professionalType diretamente do DTO
                var professionalType = professionalDto.ProfessionalTypes; // Certifique-se de que esta propriedade exista no DTO
                _logger.LogInformation($"Tipo do profissional com ID {id}: {professionalType}");
            }

            return professionalDto;
        }
        catch (HttpRequestException httpEx)
        {
            _logger.LogError(httpEx, $"Erro ao acessar a API de profissionais para ID {id}. URL: api/GenericProfessional/{id}");
            throw;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Erro inesperado ao acessar a API de profissionais para ID {id}.");
            throw;
        }
    }


    public async Task<IEnumerable<GenericProfessionalDTO>> GetAllAsync()
    {
        try
        {
            var httpClient = await CreateAuthorizedClientAsync();
            var professionalsDto = await httpClient.GetFromJsonAsync<IEnumerable<GenericProfessionalDTO>>("api/GenericProfessional");

            if (professionalsDto == null)
            {
                _logger.LogWarning("Nenhum profissional encontrado na API em 'api/GenericProfessional'.");
            }
            return professionalsDto;
        }
        catch (HttpRequestException httpEx)
        {
            _logger.LogError(httpEx, "Erro ao acessar a API de profissionais.");
            throw;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro inesperado ao acessar a API de profissionais.");
            throw;
        }
    }

    public async Task<IEnumerable<GenericProfessionalDTO>> GetByName(string name)
    {
        try
        {
            var httpClient = await CreateAuthorizedClientAsync();
            var professionalsDto = await httpClient.GetFromJsonAsync<IEnumerable<GenericProfessionalDTO>>($"api/GenericProfessional/name/{name}");

            if (professionalsDto == null)
            {
                _logger.LogWarning($"Nenhum profissional encontrado com o nome {name}.");
            }
            return professionalsDto;
        }
        catch (HttpRequestException httpEx)
        {
            _logger.LogError(httpEx, $"Erro ao acessar a API de profissionais com o nome {name}.");
            throw;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Erro inesperado ao acessar a API de profissionais com o nome {name}.");
            throw;
        }
    }

    public async Task<GenericProfessionalDTO> UpdateAsync(int id, RegisterProfessionalModel model)
    {
        try
        {
            var httpClient = await CreateAuthorizedClientAsync();
            var response = await httpClient.PutAsJsonAsync($"api/GenericProfessional/{id}", model);

            if (response.IsSuccessStatusCode)
            {
                var updatedProfessional = await response.Content.ReadFromJsonAsync<GenericProfessionalDTO>();
                _logger.LogInformation("Profissional atualizado com sucesso.");
                return updatedProfessional;
            }

            var errorContent = await response.Content.ReadAsStringAsync();
            _logger.LogError($"Erro ao atualizar o profissional. StatusCode: {response.StatusCode}, Conteúdo: {errorContent}");
            return null;
        }
        catch (HttpRequestException httpEx)
        {
            _logger.LogError(httpEx, "Erro ao acessar a API para atualizar um profissional.");
            throw;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro inesperado ao atualizar um profissional.");
            throw;
        }
    }

    public async Task DeleteAsync(int id)
    {
        try
        {
            var httpClient = await CreateAuthorizedClientAsync();
            var response = await httpClient.DeleteAsync($"api/GenericProfessional/{id}");

            if (!response.IsSuccessStatusCode)
            {
                _logger.LogError($"Erro ao deletar o profissional com ID {id}. StatusCode: {response.StatusCode}");
            }
        }
        catch (HttpRequestException httpEx)
        {
            _logger.LogError(httpEx, $"Erro ao acessar a API para deletar o profissional com ID {id}. URL: api/GenericProfessional/{id}");
            throw;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Erro inesperado ao deletar o profissional com ID {id}.");
            throw;
        }
    }

    public async Task<IEnumerable<GenericProfessionalDTO>> GetByProfessionalTypeAsync(string professionalType)
    {
        try
        {
            var httpClient = await CreateAuthorizedClientAsync();
            var professionalsDto = await httpClient.GetFromJsonAsync<IEnumerable<GenericProfessionalDTO>>($"api/GenericProfessional/type/{professionalType}");

            if (professionalsDto == null || !professionalsDto.Any())
            {
                _logger.LogWarning($"Nenhum profissional encontrado com o tipo {professionalType}.");
            }
            return professionalsDto;
        }
        catch (HttpRequestException httpEx)
        {
            _logger.LogError(httpEx, $"Erro ao acessar a API de profissionais com o tipo {professionalType}.");
            throw;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Erro inesperado ao acessar a API de profissionais com o tipo {professionalType}.");
            throw;
        }
    }

    public async Task<IEnumerable<GenericProfessionalDTO>> GetAllAsync(string professionalType)
    {
        try
        {
            var httpClient = await CreateAuthorizedClientAsync();
            var professionalsDto = await httpClient.GetFromJsonAsync<IEnumerable<GenericProfessionalDTO>>($"api/GenericProfessional");

            if (professionalsDto == null || !professionalsDto.Any())
            {
                _logger.LogWarning($"Nenhum profissional encontrado para o tipo {professionalType}.");
            }
            return professionalsDto;
        }
        catch (HttpRequestException httpEx)
        {
            _logger.LogError(httpEx, $"Erro ao acessar a API de profissionais para o tipo {professionalType}.");
            throw;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Erro inesperado ao acessar a API de profissionais para o tipo {professionalType}.");
            throw;
        }
    }

    public async Task<GenericProfessionalDTO> GetByUserId(string userId)
    {
        try
        {
            var httpClient = await CreateAuthorizedClientAsync();
            var profDto = await httpClient.GetFromJsonAsync<GenericProfessionalDTO>($"api/GenericProfessional/user/{userId}");

            if (profDto == null)
            {
                _logger.LogWarning($"Cliente com UserId {userId} não encontrado.");
            }
            return profDto;
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
