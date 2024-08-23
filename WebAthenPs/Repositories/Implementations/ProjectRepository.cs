using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Project;
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


        public async Task<IEnumerable<Projecty>> GetAll()
        {
            var projects = await _context.Projects
                .Include(p => p.Client)
                .ThenInclude(c => c.User)
                .Include(p => p.Professionals)
                .ThenInclude(gp => gp.User)
                .ToListAsync();
            return projects;
        }

        public async Task<IEnumerable<Projecty>> GetByArea(decimal area)
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

        public async Task<Projecty> GetById(int id)
        {
            var projects = await _context.Projects
                .Include(p => p.Client)
                .ThenInclude(c => c.User)
                .Include(p => p.Professionals)
                .ThenInclude(gp => gp.User)
                .SingleOrDefaultAsync(i => i.ProjectId == id);
            return projects;
        }

        public async Task<IEnumerable<Projecty>> GetByStatus(string status)
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

        public async Task<Projecty> CreateNewProject(Projecty projecty)
        {
            _context.Projects.Add(projecty);
            await _context.SaveChangesAsync();
            return projecty;
        }
        public async Task UpdateProject(Projecty projecty)
        {
            _context.Entry(projecty).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProject(int id)
        {
            var projecty = await _context.Projects.FindAsync(id);
            if(projecty != null)
            {
                _context.Projects.Remove(projecty);
                await _context.SaveChangesAsync();
            }
        }

    }
}
