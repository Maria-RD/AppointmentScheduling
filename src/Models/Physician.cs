using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TurnsBackFront.Models
{
    public class Physician
    {
        [Key]
        public int PhysicianId { get; set; }
        [Required (ErrorMessage="You must enter a name")]
        public string Name { get; set; }
        [Required (ErrorMessage="You must enter a surname")]
        public string Surname { get; set; }
        [Required (ErrorMessage="You must enter an address ")]
        public string Address { get; set; }
        [Required (ErrorMessage="You must enter a phone")]
        public string Phone { get; set; }
        [Required (ErrorMessage="You must enter an email")]
        [EmailAddress]
        public string Email { get; set; }
        [Display (Name = "Opening hours")]
        [DataType (DataType.Time)]
        [DisplayFormat (DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime OpeningHoursFrom { get; set; }
        [Display (Name = "Closing hours")]
        [DataType (DataType.Time)]
        [DisplayFormat (DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime OpeningHoursTo { get; set; }
        [Required (ErrorMessage="You must enter the speciality")]
        public List<PhysicianSpeciality> PhysicianSpeciality { get; set; }
    }
}
