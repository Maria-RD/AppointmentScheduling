using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TurnsBackFront.Models
{
    public class Speciality
    {
        [Key]

        public int SpecialityId { get; set; }
        [StringLength(200)]
        [Required (ErrorMessage = "You must enter a description")]
        [Display (Name = "Description", Prompt = "Enter a description")]
        public string Description { get; set; }

        public List<PhysicianSpeciality> PhysicianSpeciality { get; set; }
    }
}