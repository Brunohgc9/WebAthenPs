using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs.Professional;

namespace WebAthenPs.Models.DTOs.Project
{
    public class CreateProjectDTO
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
        public string? Address { get; set; }
        public string? Neighborhood { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }

        public ICollection<GenericProfessionalDTO>? Professionals { get; set; } = new List<GenericProfessionalDTO>();
    }
}
