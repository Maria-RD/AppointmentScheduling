namespace TurnsBackFront.Models
{
    public class PhysicianSpeciality
    {
        public int PhysicianId { get; set; }
        public int SpecialityId { get; set; }
        public Physician Physician { get; set; }
        public Speciality Speciality { get; set; }
    }
}
