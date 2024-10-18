using Microsoft.AspNetCore.Identity;
using WebAthenPs.API.Entities;
using WebAthenPs.API.Entities.Components.ChatEntities;

namespace WebAthenPs.API.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? Role { get; set; }
        public string? UserType { get; set; }
        public string? CPF { get; set; }
        public string? RG { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

        public ICollection<ChatAndUsers> ChatAndUsers { get; set; } = new List<ChatAndUsers>();
    }
}
