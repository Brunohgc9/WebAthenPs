﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Professional;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes.ProfessionalsRelation;
using WebAthenPs.API.Repositories.Interfaces;

namespace WebAthenPs.API.Repositories.Implementations
{
    public class GenericProfessionalRepository : IGenericProfessionlRepository
    {
        private readonly ApplicationDbContext _context;

        public GenericProfessionalRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Cria um profissional genérico e associa as especializações
        public async Task CreateAsync(GenericProfessional genericProfessional, List<string> professionalTypeNames)
        {
            if (genericProfessional == null)
                throw new ArgumentNullException(nameof(genericProfessional));

            if (professionalTypeNames == null || !professionalTypeNames.Any())
                throw new ArgumentException("A lista de tipos de profissionais não pode estar vazia.", nameof(professionalTypeNames));

            // Adiciona o profissional genérico ao banco
            _context.GenericProfessionals.Add(genericProfessional);
            await _context.SaveChangesAsync();

            // Cria os tipos de profissionais associados e retorna o ID da especialização
            var specializationId = await CreateProfessionalTypesAndReturnSpecializationIdAsync(genericProfessional, professionalTypeNames);

            // Atualiza o campo EspecializationsId com o ID da especialização gerada
            genericProfessional.EspecializationsId = specializationId;
            _context.GenericProfessionals.Update(genericProfessional);
            await _context.SaveChangesAsync();
        }



        private async Task<Guid> CreateProfessionalTypesAndReturnSpecializationIdAsync(GenericProfessional genericProfessional, List<string> professionalTypeNames)
        {
            // Cria uma nova entrada na tabela intermediária
            var professionalTypeEntry = new GenericProfessionalProfessionalType
            {
                genericId = genericProfessional.Id
            };

            // Adiciona a entrada na tabela intermediária
            _context.GenericProfessionalProfessionalTypes.Add(professionalTypeEntry);
            await _context.SaveChangesAsync();

            // Itera sobre os tipos de profissionais e cria uma instância para cada tipo
            foreach (var typeName in professionalTypeNames)
            {
                if (typeName.Equals("Architect", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Arquiteto
                    var architect = new Architect
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Architects.Add(architect);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.ArchitectId = architect.Id;
                }
                else if (typeName.Equals("CivilEngineer", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Engenheiro Civil
                    var civilEngineer = new CivilEngineer
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.CivilEngineers.Add(civilEngineer);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.CivilEngineerId = civilEngineer.Id;
                }
                else if (typeName.Equals("ElectricalEngineer", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Engenheiro Eletricista
                    var electricalEngineer = new ElectricalEngineer
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.ElectricalEngineers.Add(electricalEngineer);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.ElectricalEngineerId = electricalEngineer.Id;
                }
                else if (typeName.Equals("HydraulicEngineer", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Engenheiro Hidráulico
                    var hydraulicEngineer = new HydraulicEngineer
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.HydraulicEngineers.Add(hydraulicEngineer);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.HydraulicEngineerId = hydraulicEngineer.Id;
                }
                else if (typeName.Equals("Surveyor", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Agrimensor
                    var surveyor = new Surveyor
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Surveyors.Add(surveyor);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.SurveyorId = surveyor.Id;
                }
                else if (typeName.Equals("Foreman", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Mestre de Obras
                    var foreman = new Foreman
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Foremen.Add(foreman);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.ForemanId = foreman.Id;
                }
                else if (typeName.Equals("Mason", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Pedreiro
                    var mason = new Mason
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Masons.Add(mason);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.MasonId = mason.Id;
                }
                else if (typeName.Equals("Plumber", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Encanador
                    var plumber = new Plumber
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Plumbers.Add(plumber);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.PlumberId = plumber.Id;
                }
                else if (typeName.Equals("Electrician", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Eletricista
                    var electrician = new Electrician
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Electricians.Add(electrician);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.ElectricianId = electrician.Id;
                }
                else if (typeName.Equals("Carpenter", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Carpinteiro
                    var carpenter = new Carpenter
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Carpenters.Add(carpenter);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.CarpenterId = carpenter.Id;
                }
                else if (typeName.Equals("Roofer", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Telhadista
                    var roofer = new Roofer
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Roofers.Add(roofer);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.RooferId = roofer.Id;
                }
                else if (typeName.Equals("Plasterer", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Gesseiro
                    var plasterer = new Plasterer
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Plasterers.Add(plasterer);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.PlastererId = plasterer.Id;
                }
                else if (typeName.Equals("Tiler", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Azulejista
                    var tiler = new Tiler
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Tilers.Add(tiler);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.TilerId = tiler.Id;
                }
                else if (typeName.Equals("Painter", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Pintor
                    var painter = new Painter
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Painters.Add(painter);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.PainterId = painter.Id;
                }
                else if (typeName.Equals("Metalworker", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Serralheiro
                    var metalworker = new Metalworker
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Metalworkers.Add(metalworker);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.MetalworkerId = metalworker.Id;
                }
                else if (typeName.Equals("Glazier", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Vidraceiro
                    var glazier = new Glazier
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Glaziers.Add(glazier);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.GlazierId = glazier.Id;
                }
                else if (typeName.Equals("MarbleWorker", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Trabalhador de Mármore
                    var marbleWorker = new MarbleWorker
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.MarbleWorkers.Add(marbleWorker);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.MarbleWorkerId = marbleWorker.Id;
                }
                else if (typeName.Equals("Landscaper", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Paisagista
                    var landscaper = new Landscaper
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Landscapers.Add(landscaper);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.LandscaperId = landscaper.Id;
                }
                else if (typeName.Equals("Cabinetmaker", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Marceneiro
                    var cabinetmaker = new Cabinetmaker
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Cabinetmakers.Add(cabinetmaker);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.CabinetmakerId = cabinetmaker.Id;
                }
                else if (typeName.Equals("InteriorDesigner", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Designer de Interiores
                    var interiorDesigner = new InteriorDesigner
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.InteriorDesigners.Add(interiorDesigner);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.InteriorDesignerId = interiorDesigner.Id;
                }
                else if (typeName.Equals("Decorator", StringComparison.OrdinalIgnoreCase))
                {
                    // Cria um novo Decorador
                    var decorator = new Decorator
                    {
                        Id = Guid.NewGuid(),
                        ProfessionalTypeId = professionalTypeEntry.Id
                    };
                    _context.Decorators.Add(decorator);
                    await _context.SaveChangesAsync();

                    professionalTypeEntry.DecoratorId = decorator.Id;
                }
                else
                {
                    // Tipo não suportado
                    throw new NotSupportedException($"O tipo '{typeName}' não é suportado.");
                }
            }

            // Retorna o ID da especialização criada
            return professionalTypeEntry.Id;
        }




        // Deleta um profissional genérico
        public async Task DeleteAsync(int id)
        {
            var genericProfessional = await _context.GenericProfessionals.FindAsync(id);
            if (genericProfessional != null)
            {
                _context.GenericProfessionals.Remove(genericProfessional);
                await _context.SaveChangesAsync();
            }
        }

        // Obtém todos os profissionais genéricos
        public async Task<IEnumerable<GenericProfessional>> GetAllAsync()
        {
            return await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.ProjectProfessionals) // Inclui ProjectProfessionals
                    .ThenInclude(pp => pp.Project) // Inclui projetos associados
                .Include(gp => gp.GenericProfessionalType)
                .ThenInclude(gp => gp.Architect)
                .Include(pr => pr.Proposals)
                .ToListAsync();
        }

        // Obtém um profissional genérico por ID
        public async Task<GenericProfessional> GetByIdAsync(int id)
        {
            return await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.ProjectProfessionals)
                    .ThenInclude(pp => pp.Project)
                .Include(gp => gp.EspecializationsId)
                .Include(pr => pr.Proposals)
                .FirstOrDefaultAsync(gp => gp.Id == id);
        }

        // Obtém um profissional genérico por nome
        public async Task<GenericProfessional> GetByNameAsync(string name)
        {
            return await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.ProjectProfessionals)
                    .ThenInclude(pp => pp.Project)
                .Include(gp => gp.EspecializationsId)
                .Include(pr => pr.Proposals)
                .FirstOrDefaultAsync(gp => gp.User.UserName == name);
        }

        // Obtém os profissionais por tipo
        public async Task<IEnumerable<GenericProfessional>> GetByProfessionalTypeAsync(string professionalType)
        {
            if (string.IsNullOrEmpty(professionalType))
                throw new ArgumentException("ProfessionalType cannot be null or empty", nameof(professionalType));

            return await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.EspecializationsId)
                .Include(gp => gp.Client)
                .Include(gp => gp.ProjectProfessionals) // Inclui ProjectProfessionals
                    .ThenInclude(pp => pp.Project) // Inclui projetos associados
                .Include(pr => pr.Proposals)
                .Where(gp => gp.ProfessionalTypes.Contains(professionalType)) // Verifica se a lista contém o tipo
                .ToListAsync();
        }

        // Atualiza um profissional genérico
        public async Task UpdateAsync(GenericProfessional genericProfessional)
        {
            if (genericProfessional == null)
                throw new ArgumentNullException(nameof(genericProfessional));

            // Obtém o profissional existente com seus ProjectProfessionals
            var existingProfessional = await _context.GenericProfessionals
                .Include(gp => gp.EspecializationsId)
                .Include(gp => gp.ProjectProfessionals) // Inclui ProjectProfessionals
                    .ThenInclude(pp => pp.Project) // Inclui projetos associados
                .FirstOrDefaultAsync(gp => gp.Id == genericProfessional.Id);

            if (existingProfessional != null)
            {
                // Atualiza os valores do profissional existente com os valores do novo objeto
                _context.Entry(existingProfessional).CurrentValues.SetValues(genericProfessional);

                // Atualiza os ProjectProfessionals
                existingProfessional.ProjectProfessionals.Clear(); // Remove os antigos
                foreach (var pp in genericProfessional.ProjectProfessionals)
                {
                    existingProfessional.ProjectProfessionals.Add(pp); // Adiciona os novos
                }

                await _context.SaveChangesAsync();
            }
        }

        // Obtém um profissional pelo UserId
        public async Task<GenericProfessional> GetByUserId(string userId)
        {
            return await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.ProjectProfessionals)
                    .ThenInclude(pp => pp.Project)
                .Include(gp => gp.EspecializationsId)
                .Include(pr => pr.Proposals)
                .FirstOrDefaultAsync(gp => gp.UserId == userId);
        }

        // Obtém os profissionais por tipo
        public async Task<IEnumerable<GenericProfessional>> GetProfessionalsByTypeAsync(string type)
        {
            if (string.IsNullOrEmpty(type))
                throw new ArgumentException("Type cannot be null or empty", nameof(type));

            return await _context.GenericProfessionals
                .Include(gp => gp.User)
                .Include(gp => gp.Client)
                .Include(gp => gp.ProjectProfessionals)
                    .ThenInclude(pp => pp.Project)
                .Include(gp => gp.EspecializationsId)
                .Where(gp => gp.ProfessionalTypes.Contains(type))
                .ToListAsync();
        }

        // Obtém as especializações de um profissional
        public async Task<IEnumerable<GenericProfessionalProfessionalType>> GetSpecializationsByProfessionalIdAsync(int professionalId)
        {
            var professional = await _context.GenericProfessionals
                .Include(gp => gp.GenericProfessionalType)
                .FirstOrDefaultAsync(gp => gp.Id == professionalId);

            if (professional == null || professional.GenericProfessionalType == null)
                return new List<GenericProfessionalProfessionalType>();

            return await _context.Set<GenericProfessionalProfessionalType>()
                .Where(pt => pt.genericId == professional.Id)
                .ToListAsync();
        }

       

    }
}
