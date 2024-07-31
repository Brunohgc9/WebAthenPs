using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities;
using WebAthenPs.API.Repositories.Interfaces;

namespace WebAthenPs.API.Repositories.Implementations
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationDbContext _context;

        public ClientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetAll()
        {
            var clients = await _context.Clients
                .Include(c => c.User) // Inclui o usuário associado ao cliente
                .Include(c => c.Houses) // Inclui as casas associadas ao cliente
                .Include(c => c.GenericProfessionals) // Inclui os profissionais genéricos associados ao cliente
                .ThenInclude(gp => gp.User) // Inclui o usuário associado aos profissionais genéricos
                .ToListAsync();
            return clients;
        }

        public async Task<Client> GetById(int id)
        {
            var client = await _context.Clients
                .Include(c => c.User)
                .Include(c => c.Houses)
                .Include(c => c.GenericProfessionals)
                .ThenInclude(gp => gp.User)
                .SingleOrDefaultAsync(c => c.ClientId == id);
            return client;
        }


        public async Task<IEnumerable<Client>> GetByName(string name)
        {
            var clients = await _context.Clients
                .Include(c => c.User) // Inclui o usuário associado ao cliente
                .Include(c => c.Houses) // Inclui as casas associadas ao cliente
                .Include(c => c.GenericProfessionals) // Inclui os profissionais genéricos associados ao cliente
                .ThenInclude(gp => gp.User) // Inclui o usuário associado aos profissionais genéricos
                .Where(c => c.User.UserName == name)
                .Select(c => new Client
                {
                    ClientId = c.ClientId,
                    UserId = c.UserId,
                    User = new ApplicationUser
                    {
                        UserName = c.User.UserName,
                        PhoneNumber = c.User.PhoneNumber,
                        Email = c.User.Email
                    },
                    Houses = c.Houses.Select(h => new Projects
                    {
                        ProjectId = h.ProjectId,
                        ProjectName = h.ProjectName
                    }).ToList(),
                    GenericProfessionals = c.GenericProfessionals.Select(gp => new GenericProfessional
                    {
                        Id = gp.Id,
                        User = new ApplicationUser
                        {
                            UserName = gp.User.UserName
                        }
                    }).ToList()
                })
                .ToListAsync();
            return clients;
        }

    }
}
