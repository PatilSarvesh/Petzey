namespace Petzey.Model.Entities
{
    public class DoctorAppointment : Appointment
    {
        public PetOwner PetOwner { get; set; }  
        public int PetOwnerId { get; set; }
    }
}
