using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAthenPs.Models.DTOs.Professional;
using WebAthenPs.Models.DTOs.Project;

namespace WebAthenPs.Models.DTOs.Client
{
    public class ClientDTO
    {
        public int ClientId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public ICollection<ProjectsDTO> Houses { get; set; } = new List<ProjectsDTO>();
        public ICollection<GenericProfessionalDTO> GenericProfessionals { get; set; } = new List<GenericProfessionalDTO>();
    }
}
