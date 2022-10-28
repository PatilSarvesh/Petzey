namespace Petzey.Model.Entities
{
    public class ReceptionistAppointment
    {
        public string ReceptionistAppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        public PetOwner PetOwner { get; set; }
        public int PetOwnerId { get; set; }
    }
}
