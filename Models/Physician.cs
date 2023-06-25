using System;
using System.ComponentModel.DataAnnotations;

namespace TurnsBackFront.Models
{
    public class Physician
    {
        [Key]
        public int PhysicianId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime OpeningHoursFrom { get; set; }
        public DateTime OpeningHoursTo { get; set; }
    }
}
