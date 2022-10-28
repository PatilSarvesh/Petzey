namespace Petzey.Model.Entities
{
    public class PatientAppointment : Appointment
    {
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
    }
}
