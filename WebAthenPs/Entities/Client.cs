﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAthenPs.API.Data;

namespace WebAthenPs.API.Entities
{
    public class Client
    {
        //Own Properties
        [Key]
        public int ClientId { get; set; }

        //Properties that will receive values from the ApplicationUser
        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }


        //Properties 1-N
        public ICollection<Projects> Houses { get; set; } = new List<Projects>();
        public ICollection<GenericProfessional> GenericProfessionals { get; set; }

    }
}