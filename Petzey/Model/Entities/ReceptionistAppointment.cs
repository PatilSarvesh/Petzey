namespace Petzey.Model.Entities
{
    public class ReceptionistAppointment : Appointment
    {
        public PetOwner PetOwner { get; set; }
        public int PetOwnerId { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
    }
}
