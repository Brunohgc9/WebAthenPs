﻿using System.ComponentModel.DataAnnotations.Schema;
using WebAthenPs.API.Entities.Professional.ProfessionalTypes.ProfessionalsRelation;

namespace WebAthenPs.API.Entities.Professional.ProfessionalTypes
{
    public class Roofer
    {
        public Guid Id { get; set; }

        [ForeignKey("ProfessionalTypeId")]
        public GenericProfessionalProfessionalType ProfessionalType { get; set; }
        public Guid ProfessionalTypeId { get; set; }
    }
}
