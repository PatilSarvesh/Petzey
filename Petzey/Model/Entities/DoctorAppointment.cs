namespace Petzey.Model.Entities
{
    public class DoctorAppointment 
    {
        public string DoctorAppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public PetOwner PetOwner { get; set; }  
        public int PetOwnerId { get; set; }
    }
}
