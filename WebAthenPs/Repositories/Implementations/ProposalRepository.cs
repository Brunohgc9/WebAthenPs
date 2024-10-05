using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Components;
using WebAthenPs.API.Repositories.Interfaces;

namespace WebAthenPs.API.Repositories.Implementations
{
    public class ProposalRepository : IProposalRepository
    {
        private readonly ApplicationDbContext _context;

        public ProposalRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Proposal> CreateAsync(Proposal proposal)
        {
            if (proposal == null)
                throw new ArgumentNullException(nameof(proposal));

            _context.Proposals.Add(proposal);
            await _context.SaveChangesAsync();

            // Retorna a proposta criada
            return proposal;
        }


        public async Task DeleteAsync(Guid proposalId)
        {
            var proposal = await _context.Proposals.FindAsync(proposalId);
            if (proposal != null)
            {
                _context.Proposals.Remove(proposal);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Proposal>> GetByClientIdAsync(int clientId)
        {
            return await _context.Proposals
                .Where(p => p.ClientId == clientId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Proposal>> GetByProfessionalIdAsync(int professionalId)
        {
            return await _context.Proposals
                .Where(p => p.ProfessionalId == professionalId)
                .ToListAsync();
        }


        public async Task<Proposal> GetByIdAsync(Guid proposalId)
        {
            return await _context.Proposals
                .Include(p => p.Client)
                .Include(p => p.Professional)
                .FirstOrDefaultAsync(p => p.ProposalId == proposalId);
        }

        public async Task UpdateAsync(Proposal proposal)
        {
            if (proposal == null)
                throw new ArgumentNullException(nameof(proposal));

            _context.Proposals.Update(proposal);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Proposal>> GetAllAsync()
        {
            return await _context.Proposals
                .Include(p => p.Client)
                    .ThenInclude(c => c.User) // Incluindo o User para o Client
                .Include(p => p.Professional)
                        .ThenInclude(gp => gp.User) // Inclui o User relacionado ao Professional
                .ToListAsync();
        }


    }
}
