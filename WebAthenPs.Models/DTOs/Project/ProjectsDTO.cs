using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs.Client;
using WebAthenPs.Models.DTOs.Professional;

namespace WebAthenPs.Models.DTOs.Project
{
    public class ProjectsDTO
    {
        public int ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public string ConstructionType { get; set; }
        public string Status { get; set; }
        public decimal? Budget { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
        public int ClientId { get; set; }
        public string? ClientName { get; set; }  // Se necessário para exibir o nome do cliente
        public string? Address { get; set; }
        public string? Neighborhood { get; set; }  // Bairro
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string Country { get; set; }  // País
        public string? Step { get; set; }

        // Detalhes adicionais
        public decimal? TotalArea { get; set; }  // Área total do projeto
        public int? NumberOfRooms { get; set; }  // Número de quartos
        public int? NumberOfBathrooms { get; set; }  // Número de banheiros

        public ICollection<GenericProfessionalDTO>? LProfessionals { get; set; } = new List<GenericProfessionalDTO>();
        public ICollection<ProjectProfessionalDTO>? ProjectProfessionals { get; set; } = new List<ProjectProfessionalDTO>();
        public ClientDTO? Client { get; set; }

    }
}
