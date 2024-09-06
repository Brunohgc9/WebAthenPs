using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Project;
using WebAthenPs.API.Repositories.Interfaces;

public class ProjectRepository : IProjectRepository
{
    private readonly ApplicationDbContext _context;

    public ProjectRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Projecty>> GetAll()
    {
        return await _context.Projects
            .Include(p => p.Client)
                .ThenInclude(c => c.User) // Incluindo o User para o Client
            .Include(p => p.ProjectProfessionals)
                .ThenInclude(pp => pp.Professional) // Inclui o Professional
                    .ThenInclude(gp => gp.User) // Inclui o User relacionado ao Professional
            .ToListAsync();
    }


    public async Task<Projecty> GetById(int id)
    {
        return await _context.Projects
            .Include(p => p.Client)
                .ThenInclude(c => c.User)
            .Include(p => p.Professionals)
                .ThenInclude(gp => gp.User)
            .Include(p => p.ProjectProfessionals)
                .ThenInclude(pp => pp.Professional) // Inclui o Professional associado a cada ProjectProfessional
            .SingleOrDefaultAsync(i => i.ProjectId == id);
    }

    public async Task<Projecty> CreateNewProject(Projecty project)
    {
        if (project.ProjectProfessionals != null && project.ProjectProfessionals.Any())
        {
            _context.ProjectProfessionals.AddRange(project.ProjectProfessionals);
        }

        _context.Projects.Add(project);
        await _context.SaveChangesAsync();
        return project;
    }

    public async Task UpdateProject(Projecty project)
    {
        _context.Entry(project).State = EntityState.Modified;

        var existingProfessionals = await _context.ProjectProfessionals
            .Where(pp => pp.ProjectId == project.ProjectId)
            .ToListAsync();

        var professionalsToRemove = existingProfessionals
            .Where(ep => !project.ProjectProfessionals.Any(pp => pp.ProfessionalId == ep.ProfessionalId))
            .ToList();

        _context.ProjectProfessionals.RemoveRange(professionalsToRemove);

        var professionalsToAdd = project.ProjectProfessionals
            .Where(pp => !existingProfessionals.Any(ep => ep.ProfessionalId == pp.ProfessionalId))
            .ToList();

        _context.ProjectProfessionals.AddRange(professionalsToAdd);

        await _context.SaveChangesAsync();
    }

    public async Task DeleteProject(int id)
    {
        var project = await _context.Projects
            .Include(p => p.ProjectProfessionals)
                .ThenInclude(pp => pp.Professional) // Inclui o Professional associado a cada ProjectProfessional
            .SingleOrDefaultAsync(p => p.ProjectId == id);

        if (project != null)
        {
            _context.ProjectProfessionals.RemoveRange(project.ProjectProfessionals);
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Projecty>> GetByArea(decimal area)
    {
        return await _context.Projects
            .Where(a => a.TotalArea >= area)
            .OrderBy(a => a.TotalArea)
            .Include(p => p.Client)
                .ThenInclude(c => c.User)
            .Include(p => p.Professionals)
                .ThenInclude(gp => gp.User)
            .Include(p => p.ProjectProfessionals)
                .ThenInclude(pp => pp.Professional) // Inclui o Professional associado a cada ProjectProfessional
            .ToListAsync();
    }

    public async Task<IEnumerable<Projecty>> GetByClientId(int clientId)
    {
        return await _context.Projects
            .Where(p => p.ClientId == clientId)
            .Include(p => p.ProjectProfessionals)
                .ThenInclude(pp => pp.Professional) // Inclui o Professional associado a cada ProjectProfessional
            .ToListAsync();
    }

    public async Task<IEnumerable<Projecty>> GetByStatus(string status)
    {
        return await _context.Projects
            .Where(s => s.Status == status)
            .Include(p => p.Client)
                .ThenInclude(c => c.User)
            .Include(p => p.Professionals)
                .ThenInclude(gp => gp.User)
            .Include(p => p.ProjectProfessionals)
                .ThenInclude(pp => pp.Professional) // Inclui o Professional associado a cada ProjectProfessional
            .ToListAsync();
    }
}
