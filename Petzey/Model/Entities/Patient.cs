namespace Petzey.Model.Entities
{
    public class Patient
    {
        public int PatientId { get; set; }
        public Appointment Appointment { get; set; }
        public int AppointmentId { get; set; }
        public Vital Vital { get; set; }
        public int VitalId { get; set; }
        public Test Test { get; set; }
        public int TestId { get; set; }
        public List<Prescription> Prescription { get; set; }
        public int PrescriptionId { get; set; }
    }
}
