using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Project;
using WebAthenPs.API.Repositories.Interfaces;
using WebAthenPs.Models.DTOs.Professional;
using WebAthenPs.Models.DTOs.Professional.ProfessionalTypes;

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
            .Include(p => p.ProjectProposals) // Inclui as propostas do projeto
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

        // Gerenciamento de profissionais
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

        // Gerenciamento de propostas
        var existingProposals = await _context.Proposals
            .Where(p => p.ProjectId == project.ProjectId)
            .ToListAsync();

        var proposalsToRemove = existingProposals
            .Where(ep => !project.ProjectProposals.Any(pp => pp.ProposalId == ep.ProposalId))
            .ToList();

        _context.Proposals.RemoveRange(proposalsToRemove);

        var proposalsToAdd = project.ProjectProposals
            .Where(pp => !existingProposals.Any(ep => ep.ProposalId == pp.ProposalId))
            .ToList();

        _context.Proposals.AddRange(proposalsToAdd);

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

    public async Task AddProfessionalToProject(ProjectProfessional projectProfessional)
    {
        if (projectProfessional == null)
            throw new ArgumentNullException(nameof(projectProfessional), "Dados do profissional do projeto não podem ser nulos.");

        var project = await _context.Projects
            .Include(p => p.ProjectProfessionals)
            .FirstOrDefaultAsync(p => p.ProjectId == projectProfessional.ProjectId);

        if (project == null)
            throw new Exception("Projeto não encontrado.");

        var professional = await _context.GenericProfessionals.FindAsync(projectProfessional.ProfessionalId);
        if (professional == null)
            throw new Exception("Profissional não encontrado.");

        project.ProjectProfessionals.Add(projectProfessional);

        await _context.SaveChangesAsync();
    }



    public async Task<IEnumerable<GenericProfessionalDTO>> GetProfessionalsByProject(int projectId)
    {
        var projectProfessionals = await _context.ProjectProfessionals
            .Where(pp => pp.ProjectId == projectId)
            .Include(pp => pp.Professional)  // Inclui o profissional associado
                .ThenInclude(prof => prof.User)  // Inclui o usuário associado ao profissional
            .Include(pp => pp.Professional.GenericProfessionalType)  // Inclui o tipo de profissional
            .ToListAsync();

        // Mapeia para um DTO que combina todas as informações
        return projectProfessionals.Select(pp => new GenericProfessionalDTO
        {
            Id = pp.Professional.Id,
            UserId = pp.Professional.UserId,
            UserName = pp.Professional.User?.UserName ?? string.Empty,
            PhoneNumber = pp.Professional.User?.PhoneNumber,
            Email = pp.Professional.User?.Email,
            ProfessionalTypes = pp.Professional.ProfessionalTypes,


             GenericProfessionalTypeDTO = pp.Professional.GenericProfessionalType != null
          ? new GenericProfessionalProfessionalTypeDTO
          {
              Id = pp.Professional.GenericProfessionalType.Id,
              GenericId = pp.Professional.GenericProfessionalType.genericId,

              ArchitectId = pp.Professional.GenericProfessionalType.ArchitectId,
              CivilEngineerId = pp.Professional.GenericProfessionalType.CivilEngineerId,
              ElectricalEngineerId = pp.Professional.GenericProfessionalType.ElectricalEngineerId,
              HydraulicEngineerId = pp.Professional.GenericProfessionalType.HydraulicEngineerId,
              SurveyorId = pp.Professional.GenericProfessionalType.SurveyorId,
              ForemanId = pp.Professional.GenericProfessionalType.ForemanId,
              MasonId = pp.Professional.GenericProfessionalType.MasonId,
              PlumberId = pp.Professional.GenericProfessionalType.PlumberId,
              ElectricianId = pp.Professional.GenericProfessionalType.ElectricianId,
              CarpenterId = pp.Professional.GenericProfessionalType.CarpenterId,
              RooferId = pp.Professional.GenericProfessionalType.RooferId,
              PlastererId = pp.Professional.GenericProfessionalType.PlastererId,
              TilerId = pp.Professional.GenericProfessionalType.TilerId,
              PainterId = pp.Professional.GenericProfessionalType.PainterId,
              MetalworkerId = pp.Professional.GenericProfessionalType.MetalworkerId,
              GlazierId = pp.Professional.GenericProfessionalType.GlazierId,
              MarbleWorkerId = pp.Professional.GenericProfessionalType.MarbleWorkerId,
              LandscaperId = pp.Professional.GenericProfessionalType.LandscaperId,
              CabinetmakerId = pp.Professional.GenericProfessionalType.CabinetmakerId,
              InteriorDesignerId = pp.Professional.GenericProfessionalType.InteriorDesignerId,
              DecoratorId = pp.Professional.GenericProfessionalType.DecoratorId
          }
          : null,
            // Atribuindo um único ProjectProfessionalDTO
            ProjectProfessionals = pp.Professional.ProjectProfessionals?.Select(p => new ProjectProfessionalDTO
            {
                Salary = p.Salary,
                ContractedAs = p.ContractedAs,
            }).ToList() // Convertendo a seleção em uma lista




        }).ToList();

    }


}
