using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities;
using WebAthenPs.API.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System;

namespace WebAthenPs.API.Repositories.Implementations
{
    public class GenericProfessionalRepository : Repository<GenericProfessional>, IGenericProfessionalRepository
    {
        private readonly ApplicationDbContext db;

        public GenericProfessionalRepository(ApplicationDbContext context) : base(context) { }


        public async Task<IEnumerable<GenericProfessional>> GetAll()
        {
            var professionals = await _db.GenericProfessionals
                .Include(gp => gp.User) // Inclui o usuário associado ao profissional
                .Include(gp => gp.Client) // Inclui o cliente associado ao profissional
                .Include(gp => gp.Projects) // Inclui os projetos associados ao profissional
                .ToListAsync();
            return professionals;
        }

        public async Task<GenericProfessional> GetById(int id)
        {
            var professional = await _db.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.Projects)
                .SingleOrDefaultAsync(gp => gp.Id == id);
            return professional;
        }

        public async Task<IEnumerable<GenericProfessional>> GetByName(string name)
        {
            var professionals = await _db.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.Projects)
                .Where(gp => gp.User.UserName == name)
                .Select(gp => new GenericProfessional
                {
                    Id = gp.Id,
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
            var professionals = await _db.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.Projects)
                .Where(gp => gp.ProfessionalType == professionalType)
                .Select(gp => new GenericProfessional
                {
                    Id = gp.Id,
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
