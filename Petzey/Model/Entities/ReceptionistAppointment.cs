namespace Petzey.Model.Entities
{
    public class ReceptionistAppointment
    {
        public int ReceptionistAppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public int AppointmentId { get; set; }
        public int DoctorId { get; set; }
        public int PetOwnerId { get; set; }
    }
}
