using System.ComponentModel.DataAnnotations;

namespace TurnsBackFront.Models
{
    public class Speciality
    {
        [Key]

        public int SpecialityId { get; set; }
        public string Description { get; set; }
    }
}