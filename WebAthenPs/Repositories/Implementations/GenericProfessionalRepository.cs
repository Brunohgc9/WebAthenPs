using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities;
using WebAthenPs.API.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAthenPs.API.Repositories.Implementations
{
    public class GenericProfessionalRepository : IGenericProfessionalRepository
    {
        private readonly ApplicationDbContext _context;

        public GenericProfessionalRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GenericProfessional>> GetAll()
        {
            var professionals = await _context.GenericProfessionals
                .Include(gp => gp.User) // Inclui o usuário associado ao profissional
                .Include(gp => gp.Client) // Inclui o cliente associado ao profissional
                .Include(gp => gp.Projects) // Inclui os projetos associados ao profissional
                .ToListAsync();
            return professionals;
        }

        public async Task<GenericProfessional> GetById(int id)
        {
            var professional = await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.Projects)
                .SingleOrDefaultAsync(gp => gp.GProfessionalId == id);
            return professional;
        }

        public async Task<IEnumerable<GenericProfessional>> GetByName(string name)
        {
            var professionals = await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.Projects)
                .Where(gp => gp.User.UserName == name)
                .Select(gp => new GenericProfessional
                {
                    GProfessionalId = gp.GProfessionalId,
                    UserId = gp.UserId,
                    User = new ApplicationUser
                    {
                        UserName = gp.User.UserName,
                        PhoneNumber = gp.User.PhoneNumber,
                        Email = gp.User.Email
                    },
                    ClientId = gp.ClientId,
                    Client = new Client
                    {
                        ClientId = gp.Client.ClientId,
                        User = gp.Client.User,
                        Houses = gp.Client.Houses
                    },
                    Projects = gp.Projects.Select(p => new Projects
                    {
                        ProjectId = p.ProjectId,
                        ProjectName = p.ProjectName
                    }).ToList(),
                    ProfessionalType = gp.ProfessionalType
                })
                .ToListAsync();
            return professionals;
        }

        public async Task<IEnumerable<GenericProfessional>> GetByProfessionalType(string professionalType)
        {
            var professionals = await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.Projects)
                .Where(gp => gp.ProfessionalType == professionalType)
                .Select(gp => new GenericProfessional
                {
                    GProfessionalId = gp.GProfessionalId,
                    UserId = gp.UserId,
                    User = new ApplicationUser
                    {
                        UserName = gp.User.UserName,
                        PhoneNumber = gp.User.PhoneNumber,
                        Email = gp.User.Email
                    },
                    ClientId = gp.ClientId,
                    Client = new Client
                    {
                        ClientId = gp.Client.ClientId,
                        User = gp.Client.User,
                        Houses = gp.Client.Houses
                    },
                    Projects = gp.Projects.Select(p => new Projects
                    {
                        ProjectId = p.ProjectId,
                        ProjectName = p.ProjectName
                    }).ToList(),
                    ProfessionalType = gp.ProfessionalType
                })
                .ToListAsync();
            return professionals;
        }
    }
}
