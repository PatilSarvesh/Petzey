namespace Petzey.Model.Entities
{
    public class PatientAppointment
    {
        public string PatientAppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
    }
}
