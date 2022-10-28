namespace Petzey.Model.Entities
{
    public class DoctorAppointment 
    {
        public int DoctorAppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public int AppointmentId { get; set; }  
        public PetOwner PetOwner { get; set; }
        public int PetOwnerId { get; set; }
    }
}
