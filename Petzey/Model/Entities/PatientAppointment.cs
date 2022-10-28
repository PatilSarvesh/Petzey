namespace Petzey.Model.Entities
{
    public class PatientAppointment
    {
        public int PatientAppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public int AppointmentId { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
    }
}
