using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.Models
{
    public class RegisterProjectModel
    {
        public int ProjectId { get; set; }
        public string ConstructionType { get; set; }
        public string Status { get; set; }
        public decimal? Budget { get; set; }
        public int ClientId { get; set; }

        public string? Address { get; set; }
        public string? Neighborhood { get; set; }  // Bairro
        public string? City { get; set; }
        public string? State { get; set; }
        public string Country { get; set; }
        public string? ClientDescription { get; set; }

    }
}
