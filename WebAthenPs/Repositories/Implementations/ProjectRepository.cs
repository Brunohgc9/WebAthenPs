using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities;
using WebAthenPs.API.Repositories.Interfaces;

namespace WebAthenPs.API.Repositories.Implementations
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _context;

        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Projects>> GetAll()
        {
            var projects = await _context.Projects
                .Include(p => p.Client)
                .ThenInclude(c => c.User)
                .Include(p => p.Professionals)
                .ThenInclude(gp => gp.User)
                .ToListAsync();
            return projects;
        }

        public async Task<IEnumerable<Projects>> GetByArea(decimal area)
        {
            var projects = await _context.Projects
                .Where(a => a.TotalArea >= area)
                .OrderBy(a => a.TotalArea)
                .Include(p => p.Client)
                .ThenInclude(c => c.User)
                .Include(p => p.Professionals)
                .ThenInclude(gp => gp.User)
                .ToListAsync();
            return projects;
        }

        public async Task<Projects> GetById(int id)
        {
            var projects = await _context.Projects
                .Include(p => p.Client)
                .ThenInclude(c => c.User)
                .Include(p => p.Professionals)
                .ThenInclude(gp => gp.User)
                .SingleOrDefaultAsync(i => i.ProjectId == id);
            return projects;
        }

        public async Task<IEnumerable<Projects>> GetByStatus(string status)
        {
            var projects = await _context.Projects
                .Where(s => s.Status == status)
                .Include(p => p.Client)
                .ThenInclude(c => c.User)
                .Include(p => p.Professionals)
                .ThenInclude(gp => gp.User)
                .ToListAsync();
            return projects;
        }
    }
}
