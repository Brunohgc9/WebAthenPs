using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Entities;
using WebAthenPs.API.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAthenPs.API.Data;

namespace WebAthenPs.API.Repositories
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
            return await _context.Clients
                .Include(c => c.User)
                .Include(c => c.Houses)
                .Include(c => c.GenericProfessionals)
                .ToListAsync();
        }

        public async Task<Client> GetById(int id)
        {
            return await _context.Clients
                .Include(c => c.User)
                .Include(c => c.Houses)
                .Include(c => c.GenericProfessionals)
                .FirstOrDefaultAsync(c => c.ClientId == id);
        }

        public async Task<IEnumerable<Client>> GetByName(string name)
        {
            return await _context.Clients
                .Include(c => c.User)
                .Include(c => c.Houses)
                .Include(c => c.GenericProfessionals)
                .Where(c => c.User.UserName.Contains(name))
                .ToListAsync();
        }

        public async Task<Client> Create(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public async Task Update(Client client)
        {
            _context.Entry(client).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }
        }
    }
}
