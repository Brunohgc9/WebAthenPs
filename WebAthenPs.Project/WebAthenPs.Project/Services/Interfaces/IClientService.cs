﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs;
using WebAthenPs.Models.Models;

namespace WebAthenPs.API.Services.Interfaces
{
    public interface IClientService
    {
        Task<ClientDTO> CreateAsync(RegisterClientModel clientModel, string userId);
        Task<IEnumerable<ClientDTO>> GetAll();
        Task<ClientDTO> GetById(int id);
        Task<IEnumerable<ClientDTO>> GetByName(string name);
        Task<ClientDTO> UpdateAsync(int id, ClientDTO clientDto);
        Task DeleteAsync(int id);
    }
}