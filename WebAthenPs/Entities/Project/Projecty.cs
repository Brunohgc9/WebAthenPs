using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAthenPs.API.Entities.Clients;
using WebAthenPs.API.Entities.Components;
using WebAthenPs.API.Entities.Professional;

namespace WebAthenPs.API.Entities.Project
{
    public class Projecty
    {
        // Identificação do Projeto
        [Key]
        public int ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public string Status { get; set; }

        // Cliente relacionado
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        public string? ClientDescription { get; set; }

        // Informações sobre o projeto
        public string? ProjectType { get; set; } // Construção ou reforma
        public string ConstructionType { get; set; } // Tipo de construção: residencial, comercial, etc.
        public string? ProjectSize { get; set; } // Ex: Grande porte como uma mansão, pequeno como uma reforma de apartamento
        public string? Description { get; set; }

        // Datas e orçamento
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Budget { get; set; }

        // Localização do projeto
        public string? Address { get; set; }
        public string? Neighborhood { get; set; } // Bairro
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string Country { get; set; }

        // Detalhes da construção
        public decimal? TotalArea { get; set; }
        public int? NumberOfRooms { get; set; }
        public int? NumberOfBathrooms { get; set; }

        // Fase atual do projeto
        public string? ActStep { get; set; }

        // Relacionamentos com profissionais e propostas
        public ICollection<GenericProfessional>? Professionals { get; set; } = new List<GenericProfessional>();
        public ICollection<ProjectProfessional> ProjectProfessionals { get; set; } = new List<ProjectProfessional>();
        public ICollection<Proposal>? ProjectProposals { get; set; } = new List<Proposal>();
    }
}
