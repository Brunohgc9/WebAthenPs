﻿using System.ComponentModel.DataAnnotations.Schema;
using WebAthenPs.API.Data;
using WebAthenPs.API.Entities.Project;

namespace WebAthenPs.API.Entities.Components.ChatEntities
{
    public class Chats
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<ChatAndUsers> ChatAndUsers { get; set; } = new List<ChatAndUsers>();
        public ICollection<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();

        [ForeignKey("ProjectId")]
        public Projecty? Projecty { get; set; }
        public int? ProjectId { get; set; }
        public bool IsGeneral { get; set; }
    }
}
