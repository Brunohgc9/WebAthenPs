﻿using WebAthenPs.API.Entities;

namespace WebAthenPs.API.Repositories.Interfaces
{
    public interface IGenericProfessionlRepository
    {
        Task<GenericProfessional> GetByIdAsync(int id);
        Task<GenericProfessional> GetByNameAsync(string name);
        Task<IEnumerable<GenericProfessional>> GetByProfessionalTypeAsync(string professionalType);
        Task CreateAsync(GenericProfessional genericProfessional);
        Task DeleteAsync(int id);
        Task UpdateAsync(GenericProfessional genericProfessional);
    }
}