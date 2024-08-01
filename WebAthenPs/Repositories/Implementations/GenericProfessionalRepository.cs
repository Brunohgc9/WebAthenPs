using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities;
using WebAthenPs.API.Repositories.Interfaces;

namespace WebAthenPs.API.Repositories.Implementations
{
    public class GenericProfessionalRepository : IGenericProfessionlRepository
    {
        private readonly ApplicationDbContext _context;

        public GenericProfessionalRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(GenericProfessional genericProfessional)
        {
            if (genericProfessional == null)
                throw new ArgumentNullException(nameof(genericProfessional));

            // Adiciona o novo profissional ao contexto
            _context.GenericProfessionals.Add(genericProfessional);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var genericProfessional = await _context.GenericProfessionals.FindAsync(id);
            if (genericProfessional != null)
            {
                _context.GenericProfessionals.Remove(genericProfessional);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<GenericProfessional>> GetAllAsync()
        {
            return await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.Projects)
                .ToListAsync();
        }


        public async Task<GenericProfessional> GetByIdAsync(int id)
        {
            return await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.Projects)
                .FirstOrDefaultAsync(gp => gp.Id == id);
        }

        public async Task<GenericProfessional> GetByNameAsync(string name)
        {
            return await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.Projects)
                .FirstOrDefaultAsync(gp => gp.User.UserName == name); // Assumindo que 'name' corresponde ao UserName
        }

        public async Task<IEnumerable<GenericProfessional>> GetByProfessionalTypeAsync(string professionalType)
        {
            if (string.IsNullOrEmpty(professionalType))
                throw new ArgumentException("ProfessionalType cannot be null or empty", nameof(professionalType));

            return await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.Projects)
                .Where(gp => gp.ProfessionalType == professionalType)
                .ToListAsync();
        }

        public async Task UpdateAsync(GenericProfessional genericProfessional)
        {
            if (genericProfessional == null)
                throw new ArgumentNullException(nameof(genericProfessional));

            _context.GenericProfessionals.Update(genericProfessional);
            await _context.SaveChangesAsync();
        }
    }
}
