using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Clients;
using WebAthenPs.API.Entities.Professional;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes;
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
                .Include(gp => gp.ProjectProfessionals) // Inclui ProjectProfessionals
                    .ThenInclude(pp => pp.Project) // Inclui projetos associados
                .Include(pr => pr.Proposals)
                .ToListAsync();
        }

        public async Task<GenericProfessional> GetByIdAsync(int id)
        {
            return await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.ProjectProfessionals)
                    .ThenInclude(pp => pp.Project)
                .Include(gp => gp.Architect) // Inclui o arquiteto
                                .Include(pr => pr.Proposals)
                .FirstOrDefaultAsync(gp => gp.Id == id);
        }



        public async Task<GenericProfessional> GetByNameAsync(string name)
        {
            return await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.ProjectProfessionals) // Inclui ProjectProfessionals
                    .ThenInclude(pp => pp.Project) // Inclui projetos associados
                                    .Include(pr => pr.Proposals)
                .FirstOrDefaultAsync(gp => gp.User.UserName == name); // Assumindo que 'name' corresponde ao UserName
        }

        public async Task<IEnumerable<GenericProfessional>> GetByProfessionalTypeAsync(string professionalType)
        {
            if (string.IsNullOrEmpty(professionalType))
                throw new ArgumentException("ProfessionalType cannot be null or empty", nameof(professionalType));

            return await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.ProjectProfessionals) // Inclui ProjectProfessionals
                    .ThenInclude(pp => pp.Project) // Inclui projetos associados
                                    .Include(pr => pr.Proposals)
                .Where(gp => gp.ProfessionalTypes.Contains(professionalType)) // Verifica se a lista contém o tipo
                .ToListAsync();
        }

        public async Task UpdateAsync(GenericProfessional genericProfessional)
        {
            if (genericProfessional == null)
                throw new ArgumentNullException(nameof(genericProfessional));

            // Obtém o profissional existente com seus ProjectProfessionals
            var existingProfessional = await _context.GenericProfessionals
                .Include(gp => gp.ProjectProfessionals) // Inclui ProjectProfessionals
                    .ThenInclude(pp => pp.Project) // Inclui projetos associados
                .FirstOrDefaultAsync(gp => gp.Id == genericProfessional.Id);

            if (existingProfessional != null)
            {
                // Atualiza os valores do profissional existente com os valores do novo objeto
                _context.Entry(existingProfessional).CurrentValues.SetValues(genericProfessional);

                // Atualiza os ProjectProfessionals
                existingProfessional.ProjectProfessionals.Clear(); // Remove os antigos
                foreach (var pp in genericProfessional.ProjectProfessionals)
                {
                    existingProfessional.ProjectProfessionals.Add(pp); // Adiciona os novos
                }

                await _context.SaveChangesAsync();
            }
        }

        public async Task<GenericProfessional> GetByUserId(string userId)
        {
            return await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.ProjectProfessionals)
                    .ThenInclude(pp => pp.Project)
                .Include(gp => gp.Architect) // Inclui o arquiteto
                                .Include(pr => pr.Proposals)
                .FirstOrDefaultAsync(gp => gp.UserId == userId);
        }

    }
}
