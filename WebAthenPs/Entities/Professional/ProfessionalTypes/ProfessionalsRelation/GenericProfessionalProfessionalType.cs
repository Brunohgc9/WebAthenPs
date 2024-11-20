using System.ComponentModel.DataAnnotations.Schema;

namespace WebAthenPs.API.Entities.Professional.ProfessionalTypes.ProfessionalsRelation
{
    public class GenericProfessionalProfessionalType
    {
        public Guid Id { get; set; }


        [ForeignKey("genericId")]
        public GenericProfessional Professional { get; set; }

        public int genericId { get; set; }



    }
}
