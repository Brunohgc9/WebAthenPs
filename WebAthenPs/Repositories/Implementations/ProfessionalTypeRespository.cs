using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes;
using WebAthenPs.API.Repositories.Interfaces;

namespace WebAthenPs.API.Repositories.Implementations
{
    public class ArchitectRepository : IArchitectRepository
    {
        private readonly ApplicationDbContext _context;

        public ArchitectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Architect architect)
        {
            if (architect == null)
                throw new ArgumentNullException(nameof(architect));

            _context.Architects.Add(architect);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var architect = await _context.Architects.FindAsync(id);
            if (architect != null)
            {
                _context.Architects.Remove(architect);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Architect>> GetAllAsync()
        {
            return await _context.Architects
                .Include(a => a.Professional)
                .ThenInclude(p => p.User) // Adicione isso para garantir que User é carregado
                .ToListAsync();
        }


        public async Task<Architect> GetByIdAsync(Guid id)
        {
            return await _context.Architects
                .Include(a => a.Professional)
                .FirstOrDefaultAsync(a => a.ArchId == id);
        }

        public async Task UpdateAsync(Architect architect)
        {
            if (architect == null)
                throw new ArgumentNullException(nameof(architect));

            _context.Architects.Update(architect);
            await _context.SaveChangesAsync();
        }
    }
}
