using System.ComponentModel.DataAnnotations;

namespace Turns.Models
{
    public class Speciality
    {
        [Key]

        public int SpecialityId { get; set; }
        public string Description { get; set; }
    }
}