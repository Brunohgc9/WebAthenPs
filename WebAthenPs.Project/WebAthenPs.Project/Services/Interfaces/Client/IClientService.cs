﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs.Client;

namespace WebAthenPs.Project.Services.Interfaces.Client
{
    public interface IClientService
    {
        Task<ClientDTO> CreateAsync(RegisterClientModel clientModel);
        Task<IEnumerable<ClientDTO>> GetAll();
        Task<ClientDTO> GetById(int id);
        Task<IEnumerable<ClientDTO>> GetByName(string name);
        Task<ClientDTO> UpdateAsync(int id, ClientDTO clientDto);
        Task DeleteAsync(int id);

        Task<ClientDTO> GetByUserId(string userId);

    }
}
