using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAthenPs.Models.DTOs
{
    public class ClientDTO
    {
        public int ClientId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }  
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public ICollection<ProjectsDTO> Houses { get; set; } = new List<ProjectsDTO>();
        public ICollection<GProfessionalDTO> GenericProfessionals { get; set; } = new List<GProfessionalDTO>();
    }
}
