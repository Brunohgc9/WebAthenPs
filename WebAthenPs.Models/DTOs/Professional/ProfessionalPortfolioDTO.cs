using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.DTOs.Professional
{
    public class ProfessionalPortfolioDTO
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string Address { get; set; }
        public DateOnly CreatedAt { get; set; }
        public List<string> ProfessionalTypes { get; set; } = new List<string>();
        public List<ProjectProfessionalDTO> ProjectProfessionals { get; set; } = new List<ProjectProfessionalDTO>();
        
    }
}
