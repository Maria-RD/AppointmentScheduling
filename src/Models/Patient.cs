using System.ComponentModel.DataAnnotations;

namespace TurnsBackFront.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Required (ErrorMessage="You must enter a name")]
        public string Name { get; set; }
        [Required (ErrorMessage="You must enter a surname")]
        public string Surname { get; set; }
        [Required (ErrorMessage="You must enter an address")]
        public string Address { get; set; }
        [Required (ErrorMessage="You must enter a phone")]
        public string Phone { get; set; }
        [Required (ErrorMessage="You must enter an email")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
