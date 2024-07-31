using System;
using System.Collections.Generic;

namespace WebAthenPs.Models.DTOs
{
    public class GProfessionalDTO
    {
        public int? GProfessionalId { get; set; }
        public string? UserId { get; set; }
        public string? UserName { get; set; }

        public string? ProfessionalType { get; set; }
        public List<ProjectsDTO> Projects { get; set; } = new List<ProjectsDTO>();

    }
}
